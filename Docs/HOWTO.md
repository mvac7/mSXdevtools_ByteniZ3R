# ByteniZ3R devtool
#### version 1.0b (August 2023)

---
## Index

- [1 Description](#1-Description)
- [2 License](#2-License)
- [3 Requirements](#3-Requirements)
- [4 How to Install and Run](#4-How-to-Install-and-Run)
- [5 Features](#5-Features)
- [6 User Guide](#6-User-Guide)
   - [6.1 How does it work](#61-How-does-it-work)
   - [6.2 Project Menu](#62-Project-Menu)
   - [6.3 Waveforms](#63-Waveforms)
   - [6.4 Data output format](#64-Data-output-format)
   - [6.5 Save the data table](#65-Save-the-data-table)
   - [6.6 Copy/Paste waveform](#66-Copy/Paste-waveform)
   - [6.7 Keyboard shortcuts](#67-Keyboard-shortcuts)
- [7 Programming information](#7-Programming-information)
   - [7.1 Examples](#71-Examples)
   - [7.2 How to read data in MSX BASIC](#72-How-to-read-data-in-MSX-BASIC)
- [8 References](#8-References)

<br/>

---

## 1 Description

Generates tables of 8bits signed or unsigned values, from waveforms in different programming languages (BASIC, C or ASM).
It can be useful for generating graphics or creating paths to move [Sprites](https://en.wikipedia.org/wiki/Sprite_(computer_graphics)).

This tool is designed for the cross-development of computer programs with 8bits processors.

It includes examples for various development environments of the MSX system (Assembler, C and MSX BASIC), 
which is what I know (sorry developers of other platforms).

This project is open source, so you can improve or adapt the tool to your needs.
   
This software was developed in Microsoft Visual Studio Community 2019.                

   
<br/>

---

## 2 License

Copyright (C) 2023 mvac7

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.
If not, see <http://www.gnu.org/licenses/>.
 
<br/>

---

## 3 Requirements

* Computer with .net framework v4.0
* Display with minimum resolution: XVGA (1024x768)

<br/>

---

## 4 How to Install and Run
 
This application does not contain an installer and does not write to the System registry.
   
You will only have to unpack the files included in the ZIP of the release, in the place you want on your disk. 
   
For run, execute `ByteniZ3R`  

<br/>

---

## 5 Features

- 8bits signed or unsigned values
- 9 waveform generators: Sine, 1/2 Sine Upper, 1/2 Sine Lower, Cosine, Square, Triangle, Sawtooth, Reverse Sawtooth and Noise.
- Maximum and minimum adjustment.
- Length, Phase and Frequency adjustmens.
- BASIC, C or Assembler output.
- Supports several number systems and data formats (decimal, hexadecimal or binary)
- Edit info project (Name, Version, Author, Group, and Description).
- Application Settings. Set default source code format and colors.
- Save/Load project files.
- Save output to source code 
- Save output to binary file

<br/>

---

## 6 User Guide

### 6.1 How does it work

The graphical interface is designed to be used in a top-down flow.

You can start by giving the project a name and information about it (version, author and description), although it is optional.

The next step will be to choose the type of waveform that we want to generate and modify its properties.
   
Now you must configure the output format, indicating the programming language and the numerical system (decimal, hexadecimal or binary).
   
Finally, you'll need to move the data into your project, either copying the text or saving the output to a text or binary file.

<br/>

### 6.2 Project Menu
    
At the top of the main window we have the project menu, with the following options:
   
- `New` Start a new project. Delete all the information of the current project.   
- `Load Project` Shows a dialog that allows you to load projects saved in native format (.XBYT).

| **Attention!** |
| :---           |
| You can also load a project by Drag & Drop the file to the main window. |
   
- `Save Project` Save the configuration of a project (Project info, Waveform and Source code format) in .XBYT file.  
- `Save As Project` Save the project with another file name.
- `Edit Project info` Allows you to edit the name, version, group, author and description of the project.
- `Application Settings` Shows a window where you can edit the colors of the graph and the data output box; and configure the default format of the source code.
- `Help` Shows a window with the User Guide.
- `About` Shows a window with application version and license information.

<br/>

### 6.3 Waveforms

There are 9 waveform generators available: Sine, 1/2 Sine Upper, 1/2 Sine Lower, Cosine, Square, Triangle, Sawtooth, Reverse Sawtooth and Noise.
   
It has several parameters to adjust the form:
   
- `Length` (8-1024): Number of bytes dedicated to drawing the shape.
- `Min value` and  `Max value` (Unsigned:0 to 255 or Signed:-128 to 127): Defines the smallest and the highest value of the form.
- `Phase` (0-359): Shifts the wave n degrees.
- `Frecuency` (1-256): Number of times the shape will be repeated.
- `Type Selector` Indicates whether the output values are signed or unsigned.

<br/>

### 6.4 Data output format
In the output area, we have a form to define the format, such as the programming language, numeric format and compression.


#### Programming language
Includes presets for some assemblers.
 
- BASIC 
- C 
- Assembler default
- Assembler asMSX
- Assembler tniASM
- Assembler SJasm
- Assembler SDCC 

#### Numeric system
Supports various number systems and formats for different programming languages.

Name              | Example     | Language
----------------- | ----------- | -----------------------
decimal n         |   15        | Assembler, C or BASIC
decimal nnn       |  015        | Assembler, C or BASIC
decimal nnnd      |  015d       | Assembler
hexadecimal FF    |   0F        | BASIC           
hexadecimal $FF   |  $0F        | Assembler
hexadecimal #FF   |  #0F        | Assembler
hexadecimal 0FFh  |  00Fh       | Assembler
hexadecimal 0xFF  | 0x0F        | C or Assembler           
hexadecimal &HFF  | &H0F        | BASIC
binary 00000000   |   00001111  | BASIC
binary 00000000b  |   00001111b | Assembler
binary %00000000  |  %00001111  | Assembler
binary 0b00000000 | 0b00001111  | C or Assembler
binary &B00000000 | &B00001111  | BASIC
                    

#### Line size

Number of elements per line (1,2,4,8, 16, 24 or 32).
 

#### Assembler Config 

- `Field Name` Name of the label that will be added to the output to be able to access it from the program.
               
- `Command` Command used for assembler data. Default = "DB"
    You can add `<tab>` in front of it, so that it includes a tab in the output. Example: `<tab>DB`
                     

#### C Config

- `Field Name` Name of the Array that will be used in the output source code.
- `Unsigned` Declaration for unsigned Byte type. Default = `const char`
- `Signed` Declaration for signed Byte type. Default = `const signed char`
               

#### BASIC Config

- `Initial Line` Start line number. Default = 1000
- `Increment` Increment between lines. Default = 10
- `Remove 0` (checkbutton): It does not show the zeros to save on the size of the listings. 

<br/>

### 6.5 Save the data table  

Once we have the data, you can copy and paste the code into your programming environment.

- `Copy All` Copy all source code to clipboard.
- `Save Source` Saves the output text with the extension of the selected language (.BAS; .C; .ASM/.S)
- `Save Binary` Save the output data to a binary file.

<br/>

### 6.6 Copy/Paste waveform

If you open some source code from a development environment with a table generated by ByteniZ3R, you will see that in the initial comments, there is a line where the waveform parameters are displayed (begins with `WF:`).

```basic
2000 REM ByteniZ3R devtool v1-beta
2001 REM Project: New Project
2002 REM WF: Sawtooth Signed Length=64 Min=-128 Max=0 Phase=0 Freq=2
2010 DATA &H80,&H82,&H84,&H86,&H88,&H8A,&H8C,&H8E
...
```

If you copy this line to the clipboard (`CTRL` + `C`), without the comment statement, then you can paste it into the application (`CTRL` + `V`), which will update the waveform parameters.

`WF: Sawtooth Signed Length=64 Min=-128 Max=0 Phase=0 Freq=2`

<br/>

#### For versions prior to 1b

If you have code generated by versions prior to v1, for this functionality to work you must make the following modifications:
- Add `WF:` to the beginning of the comment.
- Next, copy the name of the waveform, separated by spaces.

**Example 1 Original:**
```assembler
; ByteniZ3R v0.9.13.0
; Sine
; Length=256; Min=32; Max=208; Phase=0; Freq=3
```

**Example 1 Modified:**
```assembler
; ByteniZ3R v0.9.13.0
; WF: Sine Length=256; Min=32; Max=208; Phase=0; Freq=3
```

---

**Example 2 Original:**
```basic
1000 REM ByteniZ3R v0.9.17.0
1010 REM Project: New Project
1020 REM Noise (Random)
1030 REM Length=95; Min=48; Max=212
```

**Example 2 Modified:**
```basic
1000 REM ByteniZ3R v0.9.17.0
1010 REM Project: New Project
1030 REM WF: Noise (Random) Length=95; Min=48; Max=212
```


<br/>

### 6.7 Keyboard shortcuts

| Shortcut     | Description  |
| :---         | :---         | 
| **F1**       | Help         |
| **Ctrl + N** | New Project  |
| **Ctrl + O** | Load Project |
| **Ctrl + S** | Save Project |
| **Ctrl + A** | Copy All source code |
| **Ctrl + v** | Copy Waveform from clipboard (see ) |

<br/>

---

## 7 Programming information


### 7.1 Examples 
  
The application includes a folder `Examples\` where you will find programming examples:


#### Assembler
  
- `Assembler\Test1_asMSX` Test output data in asMSX assembler
- `Assembler\Test1_Sjasm` Test output data in Sjasm assembler
- `Assembler\Test2_asMSX` Test import binary files in asMSX assembler


#### BASIC
  
- `BASIC\` Several examples with different formats and data. 


#### C
  
- `C\Test1` Test at SDCC compilator


<br/>

### 7.2 How to read data in MSX BASIC

For MSX BASIC you can generate the data in different formats, but there are two ways that I recommend depending on what you need:


#### That occupies little
   
If you have a very large program and need to reduce the size, the best way is to use the `hex FF` format and remove0. 
In this way, a value will occupy 0 to 2 Bytes, but it has a drawback: execution is slower, 
because each alphanumeric data must be converted to a numeric value using the VAL instruction.    

```basic
10 DIM AR(31)
20 RESTORE 210:L=31:GOSUB 110
30 FOR BC=0 to L
40 PRINT USING "### : ###";BC;AR(BC)
50 NEXT
60 END
100 REM ----------------------
101 REM Data Loader
102 REM Imput:  L=Length-1
103 REM Output: AR()
104 REM ----------------------
110 FOR BC=0 to L
120 READ A$:AR(BC)=VAL("&H"+A$)
130 NEXT
140 RETURN
150 REM ----------------------
200 REM ByteniZ3R devtool v0.9.28.0-beta
201 REM Project: Example for BASIC
202 REM WF: Sine Unsigned Length=32 Min=0 Max=255 Phase=0 Freq=1
210 DATA 80,99,B2,C8,DC,EC,F7,FE
220 DATA FF,FB,F2,E4,D3,BD,A6,8C
230 DATA 73,59,42,2C,1B,0D,04,00
240 DATA 01,08,13,23,37,4D,66,7F
```

    
#### Make it fast
  
If you want the data block to be read as fast as possible, the best way is in decimal `dec n` or hexadecimal `hex &HFF`. 
This way is about twice as fast as the previous one.
  
```basic
10 DIM AR(31)
20 RESTORE 210:L=31:GOSUB 110
30 FOR BC=0 to L
40 PRINT USING "### : ###";BC;AR(BC)
50 NEXT
60 END
100 REM ----------------------
101 REM Data Loader
102 REM Imput:  L=Length-1
103 REM Output: AR()
104 REM ----------------------
110 FOR BC=0 to L
120 READ A:AR(BC)=A
130 NEXT
140 RETURN
150 REM ----------------------  
200 REM ByteniZ3R devtool v0.9.28.0-beta
201 REM Project: Example for BASIC
202 REM WF: Sine Unsigned Length=32 Min=0 Max=255 Phase=0 Freq=1
210 DATA 128,153,178,200,220,236,247,254
220 DATA 255,251,242,228,211,189,166,140
230 DATA 115,89,66,44,27,13,4,0
240 DATA 1,8,19,35,55,77,102,127
```

<br/>

---

## 8 References

- Sjasm [Numeric constants](https://www.xl2s.tk/sjasmman4.html)
- Sjasm [Data definition](https://www.xl2s.tk/sjasmman6.html)
- asMSX [manual](https://github.com/Fubukimaru/asMSX/blob/master/doc/asmsx.md)

<br/>

---

![Creative Commons License](https://i.creativecommons.org/l/by-nc/4.0/88x31.png) 
<br/>This document is licensed under a [Creative Commons Attribution-NonCommercial 4.0 International License](http://creativecommons.org/licenses/by-nc/4.0/).