; ==============================================================================
;   ByteniZ3R Test
;   Assemble with sjasm
; ==============================================================================


  DEFPAGE 1,4000h,2000h
		

VDPVRAM   EQU   $98 ;VRAM Data (Read/Write)
VDPSTATUS EQU   $99 ;VDP Status Registers

;system vars
MSXVER EQU $002D
FORCLR EQU $F3E9 ;Foreground colour
BAKCLR EQU $F3EA ;Background colour
BDRCLR EQU $F3EB ;Border colour
CLIKSW EQU $F3DB ;0 disabled / 1 enabled
RG1SAV EQU $F3E0 ;VDP REG 1
EXTVDP EQU $FFE7 ;

;BIOS (info by MSX Assembly Page)
;http://map.grauw.nl/resources/msxbios.php
DISSCR EQU $0041 ;inhibits the screen display
ENASCR EQU $0044 ;displays the screen
WRTVDP EQU $0047 ;write data in the VDP-register
RDVRM  EQU $004A ;Reads the content of VRAM
WRTVRM EQU $004D ;Writes data in VRAM
SETRD  EQU $0050 ;Enable VDP to read
SETWRT EQU $0053 ;Enable VDP to write
FILVRM EQU $0056 ;fill VRAM with value
LDIRMV EQU $0059 ;Block transfer to memory from VRAM
LDIRVM EQU $005C ;Block transfer to VRAM from memory
CHGMOD EQU $005F ;Switches to given screenmode
CHGCLR EQU $0062 ;Changes the screencolors
CLRSPR EQU $0069 ;Initialises all sprites
INITXT EQU $006C ;Switches to SCREEN 0 (text screen with 40 * 24 characters)
INIT32 EQU $006F ;Switches to SCREEN 1 (text screen with 32*24 characters)
INIGRP EQU $0072 ;Switches to SCREEN 2 (high resolution screen with 256*192 pixels)
INIMLT EQU $0075 ;Switches to SCREEN 3 (multi-color screen 64*48 pixels)
SETTXT EQU $0078 ;Switches to VDP in SCREEN 0 mode
SETT32 EQU $007B ;Switches VDP in SCREEN mode 1
SETGRP EQU $007E ;Switches VDP to SCREEN 2 mode
SETMLT EQU $0081 ;Switches VDP to SCREEN 3 mode
CALPAT EQU $0084 ;Returns the address of the sprite pattern table
CALATR EQU $0087 ;Returns the address of the sprite attribute table
GSPSIZ EQU $008A ;Returns current sprite size
GRPPRT EQU $008D ;Displays a character on the graphic screen

GICINI EQU $0090 ;Initialises PSG and sets initial value for the PLAY statement
WRTPSG EQU $0093 ;Writes data to PSG-register
RDPSG  EQU $0096 ;Reads value from PSG-register

; more BIOS functions
CHKRAM EQU $0000 ;Tests RAM and sets RAM slot for the system
ENASLT EQU $0024 ;Switches indicated slot at indicated page on perpetual
CHGET  EQU $009F ;One character input
POSIT  EQU $00C6
GTSTCK EQU $00D5 ;Returns the joystick status
GTTRIG EQU $00D8 ;Returns current trigger status
SNSMAT EQU $0141 ;Returns the value of the specified line from the keyboard matrix
KILBUF EQU $0156 ;Clear keyboard buffer




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



;ROM HEADER ####################################################################

  page 1

  code                        


  db  "AB"
  dw  INIT
  dw  $0000
  dw  $0000
  dw  $0000
  dw  $0000
  dw  $0000
  dw  $0000
  

;END ROM HEADER ################################################################

INIT:
  di
	ld   SP,[$fc4a] ; Stack at the top of memory.
	ei



	
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
  
  ;screen 1
  ld   A,1
	call CHGMOD
	
	;set sprite mode (16x16,no zoom)
  ld   DE,$0100
  call SETUPSPRITES
  
  ;vuelca a VRAM los patrones de sprite 
  ld   HL,SPRITE_DATA
  ld   DE,BASE9  
  ld   BC,32*1
  call LDIRVM
  

  ;vuelca a VRAM los atributos de sprite (OAM)
  ld   HL,SPRITE_ATTRS
  ld   DE,BASE8  
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


//pausa en ciclos de VBLANK.
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






; sprite pattern
SPRITE_DATA:
  ; TOMATO
  db $05,$07,$1F,$3F,$7F,$7F,$7F,$7D
  db $7F,$7F,$78,$3F,$1F,$04,$04,$0C
  db $40,$C0,$F0,$F8,$FC,$FC,$FC,$7C
  db $FC,$FC,$3C,$F8,$F0,$40,$40,$60
  




; Sine
; Length=255; Min=64; Max=240; Freq=1; Phase=0
DATAX:
  db $98,$94,$8F,$8B,$87,$83,$7E,$7A,$76,$72,$6F,$6B,$67,$64,$60,$5D
  db $5A,$57,$54,$51,$4F,$4D,$4A,$48,$47,$45,$44,$43,$42,$41,$40,$40
  db $40,$40,$40,$41,$42,$43,$44,$45,$47,$48,$4A,$4D,$4F,$51,$54,$57
  db $5A,$5D,$60,$64,$67,$6B,$6F,$72,$76,$7A,$7E,$83,$87,$8B,$8F,$94
  db $98,$9C,$A1,$A5,$A9,$AD,$B2,$B6,$BA,$BE,$C1,$C5,$C9,$CC,$D0,$D3
  db $D6,$D9,$DC,$DF,$E1,$E3,$E6,$E8,$E9,$EB,$EC,$ED,$EE,$EF,$F0,$F0
  db $F0,$F0,$F0,$EF,$EE,$ED,$EC,$EB,$E9,$E8,$E6,$E3,$E1,$DF,$DC,$D9
  db $D6,$D3,$D0,$CC,$C9,$C5,$C1,$BE,$BA,$B6,$B2,$AD,$A9,$A5,$A1,$9C
  db $98,$94,$8F,$8B,$87,$83,$7E,$7A,$76,$72,$6F,$6B,$67,$64,$60,$5D
  db $5A,$57,$54,$51,$4F,$4D,$4A,$48,$47,$45,$44,$43,$42,$41,$40,$40
  db $40,$40,$40,$41,$42,$43,$44,$45,$47,$48,$4A,$4D,$4F,$51,$54,$57
  db $5A,$5D,$60,$64,$67,$6B,$6F,$72,$76,$7A,$7E,$83,$87,$8B,$8F,$94
  db $98,$9C,$A1,$A5,$A9,$AD,$B2,$B6,$BA,$BE,$C1,$C5,$C9,$CC,$D0,$D3
  db $D6,$D9,$DC,$DF,$E1,$E3,$E6,$E8,$E9,$EB,$EC,$ED,$EE,$EF,$F0,$F0
  db $F0,$F0,$F0,$EF,$EE,$ED,$EC,$EB,$E9,$E8,$E6,$E3,$E1,$DF,$DC,$D9
  db $D6,$D3,$D0,$CC,$C9,$C5,$C1,$BE,$BA,$B6,$B2,$AD,$A9,$A5,$A1,$9C
  
  
  
; Cosine
; Length=255; Min=1; Max=175; Freq=1; Phase=0
DATAY:
  db $AF,$AF,$AF,$AF,$AF,$AE,$AE,$AE,$AD,$AD,$AC,$AC,$AB,$AB,$AA,$A9
  db $A8,$A7,$A7,$A6,$A5,$A4,$A3,$A1,$A0,$9F,$9E,$9C,$9B,$9A,$98,$97
  db $95,$94,$92,$91,$8F,$8D,$8C,$8A,$88,$86,$84,$83,$81,$7F,$7D,$7B
  db $79,$77,$75,$73,$71,$6F,$6D,$6B,$69,$66,$64,$62,$60,$5E,$5C,$5A
  db $57,$55,$53,$51,$4F,$4D,$4B,$49,$46,$44,$42,$40,$3E,$3C,$3A,$38
  db $36,$34,$32,$30,$2E,$2D,$2B,$29,$27,$25,$24,$22,$20,$1F,$1D,$1B
  db $1A,$18,$17,$16,$14,$13,$12,$10,$0F,$0E,$0D,$0C,$0B,$0A,$09,$08
  db $07,$06,$06,$05,$04,$04,$03,$03,$02,$02,$02,$02,$01,$01,$01,$01
  db $01,$01,$01,$01,$02,$02,$02,$02,$03,$03,$04,$04,$05,$06,$06,$07
  db $08,$09,$0A,$0B,$0C,$0D,$0E,$0F,$10,$12,$13,$14,$16,$17,$18,$1A
  db $1B,$1D,$1F,$20,$22,$24,$25,$27,$29,$2B,$2C,$2E,$30,$32,$34,$36
  db $38,$3A,$3C,$3E,$40,$42,$44,$46,$49,$4B,$4D,$4F,$51,$53,$55,$57
  db $5A,$5C,$5E,$60,$62,$64,$66,$69,$6B,$6D,$6F,$71,$73,$75,$77,$79
  db $7B,$7D,$7F,$81,$83,$84,$86,$88,$8A,$8C,$8D,$8F,$91,$92,$94,$95
  db $97,$98,$9A,$9B,$9C,$9E,$9F,$A0,$A1,$A3,$A4,$A5,$A6,$A7,$A7,$A8
  db $A9,$AA,$AB,$AB,$AC,$AC,$AD,$AD,$AE,$AE,$AE,$AF,$AF,$AF,$AF,$AF