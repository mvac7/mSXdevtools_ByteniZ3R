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
	DB $78,$7E,$85,$8B,$92,$98,$9E,$A4,$A9,$AE,$B3,$B8,$BC,$C0,$C4,$C7
	DB $C9,$CC,$CD,$CF,$D0,$D0,$D0,$CF,$CE,$CD,$CB,$C8,$C5,$C2,$BE,$BA
	DB $B6,$B1,$AC,$A6,$A1,$9B,$95,$8F,$88,$82,$7B,$75,$6E,$68,$61,$5B
	DB $55,$4F,$4A,$44,$3F,$3A,$36,$32,$2E,$2B,$28,$25,$23,$22,$21,$20
	DB $20,$20,$21,$23,$24,$27,$29,$2C,$30,$34,$38,$3D,$42,$47,$4C,$52
	DB $58,$5E,$65,$6B,$72,$78,$7E,$85,$8B,$92,$98,$9E,$A4,$A9,$AE,$B3
	DB $B8,$BC,$C0,$C4,$C7,$C9,$CC,$CD,$CF,$D0,$D0,$D0,$CF,$CE,$CD,$CB
	DB $C8,$C5,$C2,$BE,$BA,$B6,$B1,$AC,$A6,$A1,$9B,$95,$8F,$88,$82,$7B
	DB $75,$6E,$68,$61,$5B,$55,$4F,$4A,$44,$3F,$3A,$36,$32,$2E,$2B,$28
	DB $25,$23,$22,$21,$20,$20,$20,$21,$23,$24,$27,$29,$2C,$30,$34,$38
	DB $3D,$42,$47,$4C,$52,$58,$5E,$65,$6B,$72,$78,$7E,$85,$8B,$92,$98
	DB $9E,$A4,$A9,$AE,$B3,$B8,$BC,$C0,$C4,$C7,$C9,$CC,$CD,$CF,$D0,$D0
	DB $D0,$CF,$CE,$CD,$CB,$C8,$C5,$C2,$BE,$BA,$B6,$B1,$AC,$A6,$A1,$9B
	DB $95,$8F,$88,$82,$7B,$75,$6E,$68,$61,$5B,$55,$4F,$4A,$44,$3F,$3A
	DB $36,$32,$2E,$2B,$28,$25,$23,$22,$21,$20,$20,$20,$21,$23,$24,$27
	DB $29,$2C,$30,$34,$38,$3D,$42,$47,$4C,$52,$58,$5E,$65,$6B,$72,$78

  
  
  
; ByteniZ3R v0.9.13.0
; Cosine
; Length=256; Min=0; Max=175; Phase=0; Freq=1
DATAY:
	DB $AF,$AF,$AF,$AF,$AF,$AE,$AE,$AE,$AD,$AD,$AC,$AC,$AB,$AB,$AA,$A9
	DB $A8,$A7,$A7,$A6,$A5,$A4,$A2,$A1,$A0,$9F,$9E,$9C,$9B,$9A,$98,$97
	DB $95,$94,$92,$90,$8F,$8D,$8B,$8A,$88,$86,$84,$82,$80,$7F,$7D,$7B
	DB $79,$77,$75,$73,$70,$6E,$6C,$6A,$68,$66,$64,$62,$60,$5D,$5B,$59
	DB $57,$55,$53,$51,$4E,$4C,$4A,$48,$46,$44,$42,$40,$3D,$3B,$39,$37
	DB $35,$33,$31,$30,$2E,$2C,$2A,$28,$26,$25,$23,$21,$1F,$1E,$1C,$1B
	DB $19,$18,$16,$15,$13,$12,$11,$0F,$0E,$0D,$0C,$0B,$0A,$09,$08,$07
	DB $06,$06,$05,$04,$03,$03,$02,$02,$01,$01,$01,$01,$00,$00,$00,$00
	DB $00,$00,$00,$00,$01,$01,$01,$01,$02,$02,$03,$03,$04,$05,$06,$06
	DB $07,$08,$09,$0A,$0B,$0C,$0D,$0E,$0F,$11,$12,$13,$15,$16,$18,$19
	DB $1B,$1C,$1E,$1F,$21,$23,$25,$26,$28,$2A,$2C,$2E,$30,$31,$33,$35
	DB $37,$39,$3B,$3D,$40,$42,$44,$46,$48,$4A,$4C,$4E,$51,$53,$55,$57
	DB $59,$5B,$5D,$60,$62,$64,$66,$68,$6A,$6C,$6E,$70,$73,$75,$77,$79
	DB $7B,$7D,$7F,$80,$82,$84,$86,$88,$8A,$8B,$8D,$8F,$90,$92,$94,$95
	DB $97,$98,$9A,$9B,$9C,$9E,$9F,$A0,$A1,$A2,$A4,$A5,$A6,$A7,$A7,$A8
	DB $A9,$AA,$AB,$AB,$AC,$AC,$AD,$AD,$AE,$AE,$AE,$AF,$AF,$AF,$AF,$AF
