; ==============================================================================
;   ByteniZ3R Test binary
;   Assemble with asMSX
; ==============================================================================

    .page	1
	.ROM
	.SIZE 16
	.BIOS
    	

;system vars
;MSXVER EQU $002D
FORCLR EQU $F3E9 ;Foreground colour
BAKCLR EQU $F3EA ;Background colour
BDRCLR EQU $F3EB ;Border colour
CLIKSW EQU $F3DB ;0 disabled / 1 enabled








; AJUSTES INICIALES
		
		DI
				

	;color ,5,5  
  ld   A,1
  ld   [BAKCLR],A
  ld   A,1
  ld   [BDRCLR],A  
  call CHGCLR
	
  ;screen 2
  ld   A,2
  call CHGMOD
	
	
	

  ld   HL,EGYPTIAN_RLEWB
  ld   DE,0
  call unRLEWBtoVRAM


 


LOOP:		
  halt
  
  
  ld   A,7         
  call SNSMAT
  sub  A,11111011B    ;ESC
  JR   Z,EXIT_HELP
	
  jp   LOOP

EXIT_HELP:

  call CHKRAM



.INCLUDE	"unRLEWBtoVRAM_asmsx.asm"



EGYPTIAN_RLEWB:
.INCBIN	"../../../Binaries/EGYPTIAN_RLEWB.BIN"
