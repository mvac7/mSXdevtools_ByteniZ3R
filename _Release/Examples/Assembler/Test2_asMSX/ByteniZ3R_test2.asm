; ==============================================================================
;   ByteniZ3R Test waveform
;   Assemble with asMSX https://github.com/Fubukimaru/asMSX
; ==============================================================================


    .page	1
	.ROM
	.SIZE 16
	.BIOS
	
		

;system vars
MSXVER EQU $002D
FORCLR EQU $F3E9 ;Foreground colour
BAKCLR EQU $F3EA ;Background colour
BDRCLR EQU $F3EB ;Border colour
CLIKSW EQU $F3DB ;0 disabled / 1 enabled
RG1SAV EQU $F3E0 ;VDP REG 1
EXTVDP EQU $FFE7 ;



;screen 1
BASE5  EQU $1800 ;name table
BASE6  EQU $2000 ;color table
BASE7  EQU $0000 ;character pattern table
BASE8  EQU $1B00 ;sprite attribute table (OAM)
BASE9  EQU $3800 ;sprite pattern table

;screen 2
BASE10 EQU $1800 ;name table
BASE11 EQU $2000 ;color table
BASE12 EQU $0000 ;character pattern table
BASE13 EQU $1B00 ;sprite attribute table
BASE14 EQU $3800 ;sprite pattern table



;variables


;constantes




	
MAIN:

  xor  A
  ld   [CLIKSW],A    ;keys click off
  
 	;color 15,4,4 
  ld   A,15
  ld   [FORCLR],A
  ld   A,4
  ld   [BAKCLR],A
  ld   A,4
  ld   [BDRCLR],A  
  call CHGCLR 
  
  ;screen1
  ld   A,1
	call CHGMOD
	
	;set sprite mode (16x16, no zoom)
  ld   DE,$0100
  call SETUPSPRITES

  
  ;vuelca a VRAM los patrones de sprite  
  ld   HL,SPRITE_DATA
  ld   DE,BASE14  
  ld   BC,32*1
  call LDIRVM
 

  ;vuelca a VRAM los atributos de sprite (OAM)
  ld   HL,SPRITE_ATTRS
  ld   DE,BASE13  
  ld   BC,4*1
  call LDIRVM


TOMOVE:  

  ld   IX,DATAX  ;tabla de valores para X del sprite
  ld   IY,DATAY  ;tabla de valores para Y del sprite

  ld   B,$FF     ; for B=0 TO &hFF  
BUCLE1:
  HALT
  ld   HL,BASE8  ;apunta a la OAM del plano de sprite 0
  ld   A,[IY]
  call WRTVRM    ;VPOKE HL,A (coordenada Y)
  inc  HL
  ld   A,[IX]
  call WRTVRM    ;VPOKE HL,A (coordenada X)
  
  inc  IX
  inc  IY
  djnz BUCLE1    ;NEXT
  
  jr   TOMOVE    ;goto TOMOVE (repite infinitamente)

  
;END ---------------------------------------------------------------------------
  
  
  
  
 






  

; set size and zoom of the sprites
; D size -> 0=8x8, 1=16x16
; E zoom -> 1=x2
SETUPSPRITES:
 
  ;in A,(VDPSTATUS)
  
  ld B,0
  
  ld A,D
  cp 1
  jr NZ,STSP1
  set 1,b ; --- if 16x16 sprites => set bit 1

STSP1:
  ld A,E
  cp 1
  jr NZ,STSP2
  set 0,b ; --- if zoom sprites => set bit 0

STSP2:
  ld HL,RG1SAV ; --- read vdp(1) from mem
  ld A,[HL]
  and $fc
  or B
  
  ld  B,A
  ld  C,$01
  call  WRTVDP
  
  ret


//pausa en ciclos de VBLANK. PAL 1seg=50, NTSC 1seg=60. 
; BC = num cicles 
WAIT:
  dec BC
	ld A,B
	or C
	ret Z
	
	halt
  jr  WAIT
  
  











;SPRITE ATRIBUTE DATAS #########################################################
;Y,X,SPR,COLOR
;SPR*4 in 16x16 mode
SPRITE_ATTRS:
  db 208,0,0,8

;db 0,16,4,11
;db 0,32,8,3
;db 0,48,12,14

;db 17,0,16,8
;db 17,16,20,9
;db 17,32,24,12             
;db 17,48,28,10 

;END SPRITE ATRIBUTE DATAS #####################################################






SPRITE_DATA:
  ; TOMATO
  db $05,$07,$1F,$3F,$7F,$7F,$7F,$7D
  db $7F,$7F,$78,$3F,$1F,$04,$04,$0C
  db $40,$C0,$F0,$F8,$FC,$FC,$FC,$7C
  db $FC,$FC,$3C,$F8,$F0,$40,$40,$60
  




; ByteniZ3R v0.9.13.0
; Sine
; Length=256; Min=32; Max=208; Phase=0; Freq=3
DATAX:
.INCBIN "Test_posX.BIN"
  
  
  
; ByteniZ3R v0.9.13.0
; Cosine
; Length=256; Min=0; Max=175; Phase=0; Freq=1
DATAY:
.INCBIN "Test_posY.BIN"
