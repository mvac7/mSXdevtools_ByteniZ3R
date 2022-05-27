;--------------------------------------------------------
; File Created by SDCC : free open source ANSI-C Compiler
; Version 4.1.0 #12072 (MINGW64)
;--------------------------------------------------------
	.module ByteniZ3R_test
	.optsdcc -mz80
	
;--------------------------------------------------------
; Public variables in this module
;--------------------------------------------------------
	.globl _main
	.globl _PUTSPRITE
	.globl _CopyToVRAM
	.globl _COLOR
	.globl _SetSpritesZoom
	.globl _SetSpritesSize
	.globl _SCREEN
	.globl _YDATA
	.globl _SPRITE_DATA
;--------------------------------------------------------
; special function registers
;--------------------------------------------------------
;--------------------------------------------------------
; ram data
;--------------------------------------------------------
	.area _DATA
;--------------------------------------------------------
; ram data
;--------------------------------------------------------
	.area _INITIALIZED
;--------------------------------------------------------
; absolute external ram data
;--------------------------------------------------------
	.area _DABS (ABS)
;--------------------------------------------------------
; global & static initialisations
;--------------------------------------------------------
	.area _HOME
	.area _GSINIT
	.area _GSFINAL
	.area _GSINIT
;--------------------------------------------------------
; Home
;--------------------------------------------------------
	.area _HOME
	.area _HOME
;--------------------------------------------------------
; code
;--------------------------------------------------------
	.area _CODE
;src\ByteniZ3R_test.c:54: void main(void) {
;	---------------------------------
; Function main
; ---------------------------------
_main::
;src\ByteniZ3R_test.c:56: char x=0;
;src\ByteniZ3R_test.c:57: boolean right=true;
	ld	bc, #0x0100
;src\ByteniZ3R_test.c:59: COLOR(15,1,1);    
	push	bc
	ld	de, #0x0101
	push	de
	ld	a, #0x0f
	push	af
	inc	sp
	call	_COLOR
	pop	af
	inc	sp
	ld	a, #0x02
	push	af
	inc	sp
	call	_SCREEN
	inc	sp
	ld	a, #0x01
	push	af
	inc	sp
	call	_SetSpritesSize
	inc	sp
	xor	a, a
	push	af
	inc	sp
	call	_SetSpritesZoom
	inc	sp
	ld	hl, #0x0020
	push	hl
	ld	hl, #0x3800
	push	hl
	ld	hl, #_SPRITE_DATA
	push	hl
	call	_CopyToVRAM
	ld	hl, #6
	add	hl, sp
	ld	sp, hl
	pop	bc
;src\ByteniZ3R_test.c:66: while(1){
	ld	e, #0x00
00109$:
;src\ByteniZ3R_test.c:67: HALT;
	halt	
;src\ByteniZ3R_test.c:68: PUTSPRITE(0, x, YDATA[i], RED, 0);
	ld	hl, #_YDATA+0
	ld	d, #0x00
	add	hl, de
	ld	a, (hl)
	push	bc
	push	de
	ld	h, #0x00
	push	hl
	inc	sp
	ld	h, #0x08
	push	hl
	inc	sp
	ld	b, a
	push	bc
	xor	a, a
	push	af
	inc	sp
	call	_PUTSPRITE
	pop	af
	pop	af
	inc	sp
	pop	de
	pop	bc
;src\ByteniZ3R_test.c:69: if (right){
	ld	a, b
	or	a, a
	jr	Z, 00106$
;src\ByteniZ3R_test.c:70: x++;
	inc	c
;src\ByteniZ3R_test.c:71: if(x==239) right=false;
	ld	a, c
	sub	a,#0xef
	jr	NZ, 00107$
	ld	b,a
	jr	00107$
00106$:
;src\ByteniZ3R_test.c:73: x--;
;src\ByteniZ3R_test.c:74: if(x==0) right=true;
	dec	c
	ld	a, c
	jr	NZ, 00107$
	ld	b, #0x01
00107$:
;src\ByteniZ3R_test.c:76: i++;    
	inc	e
;src\ByteniZ3R_test.c:79: }
	jr	00109$
_SPRITE_DATA:
	.db #0x07	; 7
	.db #0x1f	; 31
	.db #0x3f	; 63
	.db #0x7f	; 127
	.db #0x7f	; 127
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0x7f	; 127
	.db #0x7f	; 127
	.db #0x3f	; 63
	.db #0x1f	; 31
	.db #0x07	; 7
	.db #0xe0	; 224
	.db #0xf8	; 248
	.db #0xfc	; 252
	.db #0xfe	; 254
	.db #0xfe	; 254
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xff	; 255
	.db #0xfe	; 254
	.db #0xfe	; 254
	.db #0xfc	; 252
	.db #0xf8	; 248
	.db #0xe0	; 224
_YDATA:
	.db #0xaf	; 175
	.db #0xaf	; 175
	.db #0xae	; 174
	.db #0xac	; 172
	.db #0xaa	; 170
	.db #0xa7	; 167
	.db #0xa3	; 163
	.db #0x9f	; 159
	.db #0x9a	; 154
	.db #0x95	; 149
	.db #0x8f	; 143
	.db #0x89	; 137
	.db #0x83	; 131
	.db #0x7c	; 124
	.db #0x75	; 117	'u'
	.db #0x6f	; 111	'o'
	.db #0x68	; 104	'h'
	.db #0x60	; 96
	.db #0x5a	; 90	'Z'
	.db #0x53	; 83	'S'
	.db #0x4c	; 76	'L'
	.db #0x46	; 70	'F'
	.db #0x40	; 64
	.db #0x3a	; 58
	.db #0x35	; 53	'5'
	.db #0x30	; 48	'0'
	.db #0x2c	; 44
	.db #0x28	; 40
	.db #0x25	; 37
	.db #0x23	; 35
	.db #0x21	; 33
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x21	; 33
	.db #0x23	; 35
	.db #0x25	; 37
	.db #0x28	; 40
	.db #0x2c	; 44
	.db #0x30	; 48	'0'
	.db #0x35	; 53	'5'
	.db #0x3a	; 58
	.db #0x40	; 64
	.db #0x46	; 70	'F'
	.db #0x4c	; 76	'L'
	.db #0x53	; 83	'S'
	.db #0x5a	; 90	'Z'
	.db #0x60	; 96
	.db #0x67	; 103	'g'
	.db #0x6f	; 111	'o'
	.db #0x75	; 117	'u'
	.db #0x7c	; 124
	.db #0x83	; 131
	.db #0x89	; 137
	.db #0x8f	; 143
	.db #0x95	; 149
	.db #0x9a	; 154
	.db #0x9f	; 159
	.db #0xa3	; 163
	.db #0xa7	; 167
	.db #0xaa	; 170
	.db #0xac	; 172
	.db #0xae	; 174
	.db #0xaf	; 175
	.db #0xaf	; 175
	.db #0xaf	; 175
	.db #0xae	; 174
	.db #0xac	; 172
	.db #0xaa	; 170
	.db #0xa7	; 167
	.db #0xa3	; 163
	.db #0x9f	; 159
	.db #0x9a	; 154
	.db #0x95	; 149
	.db #0x8f	; 143
	.db #0x89	; 137
	.db #0x83	; 131
	.db #0x7c	; 124
	.db #0x75	; 117	'u'
	.db #0x6f	; 111	'o'
	.db #0x68	; 104	'h'
	.db #0x60	; 96
	.db #0x5a	; 90	'Z'
	.db #0x53	; 83	'S'
	.db #0x4c	; 76	'L'
	.db #0x46	; 70	'F'
	.db #0x40	; 64
	.db #0x3a	; 58
	.db #0x35	; 53	'5'
	.db #0x30	; 48	'0'
	.db #0x2c	; 44
	.db #0x28	; 40
	.db #0x25	; 37
	.db #0x23	; 35
	.db #0x21	; 33
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x21	; 33
	.db #0x23	; 35
	.db #0x25	; 37
	.db #0x28	; 40
	.db #0x2c	; 44
	.db #0x30	; 48	'0'
	.db #0x35	; 53	'5'
	.db #0x3a	; 58
	.db #0x40	; 64
	.db #0x46	; 70	'F'
	.db #0x4c	; 76	'L'
	.db #0x53	; 83	'S'
	.db #0x5a	; 90	'Z'
	.db #0x60	; 96
	.db #0x67	; 103	'g'
	.db #0x6f	; 111	'o'
	.db #0x75	; 117	'u'
	.db #0x7c	; 124
	.db #0x83	; 131
	.db #0x89	; 137
	.db #0x8f	; 143
	.db #0x95	; 149
	.db #0x9a	; 154
	.db #0x9f	; 159
	.db #0xa3	; 163
	.db #0xa7	; 167
	.db #0xaa	; 170
	.db #0xac	; 172
	.db #0xae	; 174
	.db #0xaf	; 175
	.db #0xaf	; 175
	.db #0xaf	; 175
	.db #0xae	; 174
	.db #0xac	; 172
	.db #0xaa	; 170
	.db #0xa7	; 167
	.db #0xa3	; 163
	.db #0x9f	; 159
	.db #0x9a	; 154
	.db #0x95	; 149
	.db #0x8f	; 143
	.db #0x89	; 137
	.db #0x83	; 131
	.db #0x7c	; 124
	.db #0x75	; 117	'u'
	.db #0x6f	; 111	'o'
	.db #0x68	; 104	'h'
	.db #0x60	; 96
	.db #0x5a	; 90	'Z'
	.db #0x53	; 83	'S'
	.db #0x4c	; 76	'L'
	.db #0x46	; 70	'F'
	.db #0x40	; 64
	.db #0x3a	; 58
	.db #0x35	; 53	'5'
	.db #0x30	; 48	'0'
	.db #0x2c	; 44
	.db #0x28	; 40
	.db #0x25	; 37
	.db #0x23	; 35
	.db #0x21	; 33
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x21	; 33
	.db #0x23	; 35
	.db #0x25	; 37
	.db #0x28	; 40
	.db #0x2c	; 44
	.db #0x30	; 48	'0'
	.db #0x35	; 53	'5'
	.db #0x3a	; 58
	.db #0x40	; 64
	.db #0x46	; 70	'F'
	.db #0x4c	; 76	'L'
	.db #0x53	; 83	'S'
	.db #0x5a	; 90	'Z'
	.db #0x60	; 96
	.db #0x67	; 103	'g'
	.db #0x6f	; 111	'o'
	.db #0x75	; 117	'u'
	.db #0x7c	; 124
	.db #0x83	; 131
	.db #0x89	; 137
	.db #0x8f	; 143
	.db #0x95	; 149
	.db #0x9a	; 154
	.db #0x9f	; 159
	.db #0xa3	; 163
	.db #0xa7	; 167
	.db #0xaa	; 170
	.db #0xac	; 172
	.db #0xae	; 174
	.db #0xaf	; 175
	.db #0xaf	; 175
	.db #0xaf	; 175
	.db #0xae	; 174
	.db #0xac	; 172
	.db #0xaa	; 170
	.db #0xa7	; 167
	.db #0xa3	; 163
	.db #0x9f	; 159
	.db #0x9a	; 154
	.db #0x95	; 149
	.db #0x8f	; 143
	.db #0x89	; 137
	.db #0x83	; 131
	.db #0x7c	; 124
	.db #0x75	; 117	'u'
	.db #0x6f	; 111	'o'
	.db #0x67	; 103	'g'
	.db #0x60	; 96
	.db #0x5a	; 90	'Z'
	.db #0x53	; 83	'S'
	.db #0x4c	; 76	'L'
	.db #0x46	; 70	'F'
	.db #0x40	; 64
	.db #0x3a	; 58
	.db #0x35	; 53	'5'
	.db #0x30	; 48	'0'
	.db #0x2c	; 44
	.db #0x28	; 40
	.db #0x25	; 37
	.db #0x23	; 35
	.db #0x21	; 33
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x20	; 32
	.db #0x21	; 33
	.db #0x23	; 35
	.db #0x25	; 37
	.db #0x28	; 40
	.db #0x2c	; 44
	.db #0x30	; 48	'0'
	.db #0x35	; 53	'5'
	.db #0x3a	; 58
	.db #0x40	; 64
	.db #0x46	; 70	'F'
	.db #0x4c	; 76	'L'
	.db #0x53	; 83	'S'
	.db #0x5a	; 90	'Z'
	.db #0x60	; 96
	.db #0x67	; 103	'g'
	.db #0x6f	; 111	'o'
	.db #0x75	; 117	'u'
	.db #0x7c	; 124
	.db #0x83	; 131
	.db #0x89	; 137
	.db #0x8f	; 143
	.db #0x95	; 149
	.db #0x9a	; 154
	.db #0x9f	; 159
	.db #0xa3	; 163
	.db #0xa7	; 167
	.db #0xaa	; 170
	.db #0xac	; 172
	.db #0xae	; 174
	.db #0xaf	; 175
	.area _CODE
	.area _INITIALIZER
	.area _CABS (ABS)
