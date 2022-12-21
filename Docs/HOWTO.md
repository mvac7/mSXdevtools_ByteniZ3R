# ByteniZ3R devtool DOC
#### version 0.9.17b

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
- [7 Programming information](#7-Programming-information)
   - [7.1 Examples](#71-Examples)
   - [7.2 How to read data in MSX BASIC](#72-How-to-read-data-in-MSX-BASIC)


<br/>

---

## 1 Description

Generates tables of 8 bits unsigned values, from waveforms in different programming languages (BASIC, C or ASM).
It can be useful for movement paths for graphic figures [(Sprites)](https://en.wikipedia.org/wiki/Sprite_(computer_graphics)) or visual effects.

It includes examples for various development environments of the MSX system (Assembler, C and BASIC), 
which is what I know (sorry developers of other platforms).

This tool is designed for the cross-development of computer programs with 8-bit processors.

This project is open source, so you can improve or adapt the tool to your needs.
   
This software was developed in Microsoft Visual Studio Community 2019.                

   
<br/>

---

## 2 License

Copyright (C) 2022 mvac7

This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.
 
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

* 7 waveform generators: Sine, Cosine, Square, Triangle, Sawtooth, Reverse Sawtooth and Noise.
* Maximum and minimum adjustment.
* Phase and Frequency adjustmens.
* BASIC, C or Assembler output.
* Supports several number systems and data formats (decimal, hexadecimal or binary)
* Edit info project (Name, Version, Author, Group, and Description).
* Save/Load project files.
* Save output to source code 
* Save output to binary file

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
   
* `New` Start a new project. Delete all the information of the current project.
   
* `Load Project` Shows a dialog that allows you to load projects saved in native format (.XBYT).
   
**Attention!** You can also load a project by dragging and dropping the file to the main window.     
   
* `Save Project` Save the configuration of a project (.XBYT)
   
* `Edit Project info` Allows you to edit the name, version, group, author and description of the project.
   
* `Config` It shows a window where you can edit the paths of the different files of the devtools applications, and the default configuration of the data output format.
   
* `About` Version and license information for the application.

<br/>

### 6.3 Waveforms

There are 7 waveform generators available: Sine, Cosine, Square, Triangle, Sawtooth, Reverse Sawtooth and Noise.
   
It has several parameters to adjust the form:
   
* `Length` (8-1024): Number of bytes dedicated to drawing the shape.
* `Min & Max` (0-255): Defines the smallest and the highest value of the form.
* `Phase` (0-359): Shifts the wave n degrees.
* `Frecuency` (1-256): Number of times the shape will be repeated.

<br/>

### 6.4 Data output format

In the output area, we have a form to define the format, such as the programming language, numeric format and compression.

#### Languages: 
* Assembler
* BASIC 
* C 


#### Number sys:  
Supports various number systems and formats for different compilers or assemblers.

Name              | Example     | Language
----------------- | ----------- | -----------------------
decimal     n     |   15        | Assembler, C or BASIC
decimal     nnn   |  015        | Assembler, C or BASIC
decimal     nnnd  |  015d       | Assembler
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
                    

#### Size Line: 
* 1,2,4,8, 16, 24 or 32
 

#### Assembler Config 

* `Field Name` Name of the label that will be added to the output to be able to access it from the program.
               
* `Command` Command used for assembler data. Default = "DB"
    You can add `<tab>` in front of it, so that it includes a tab in the output. Example: `<tab>DB`
                     

#### C Config 
* `Field Name` Name of the Array that will be used in the output source code.
* `Type` Variable declaration type. Default = "const char"
               


#### BASIC Config

* `Initial Line` Start line number. Default = 1000
* `Increment` Increment between lines. Default = 10
* `Remove 0` (checkbutton): It does not show the zeros to save on the size of the listings. 

<br/>

### 6.5 Saving the result   

Once we have the data, you can copy and paste the code into your programming environment.
   
You have two options:
* You can select the text you want to copy and use the 'Copy' option from the context menu (keyboard shortcut Ctrl+C)
* You can click on the "Copy All" button located at the bottom left of the ByteniZ3R main window.
    
...or you can also:  
   
* `Save Source` Saves the output text with the extension of the selected language (.BAS; .C; .ASM/.S)
* `Save Binary` Save the output data to a binary file.



<br/>

---

## 7 Programming information


### 7.1 Examples 
  
The application includes a folder (Examples\) where you will find programming examples:


#### Assembler
  
* `\Assembler\Test1_asMSX`  Test output data in asMSX assembler
* `\Assembler\Test1_Sjasm`  Test output data in Sjasm assembler
* `\Assembler\Test2_asMSX`  Test import binary files in asMSX assembler


#### BASIC
  
* `\BASIC\`             Several examples with different formats and data. 


#### C
  
* `\C\Test1`                Test at SDCC compilator


<br/>

### 7.2 How to read data in MSX BASIC

For MSX BASIC it can be generated in different formats, but there are two ways that I recommend depending on what you need:



#### That occupies little
   
If we work with a very large list and we need to reduce size, the best way is to use the `hex FF` format and remove0. 
In this way, a value will occupy 0 to 2 Bytes, but it has a drawback: execution is slower, 
because each alphanumeric data must be converted to a numeric value using the VAL instruction.    

```basic
100 FOR BC=0 to 31
110 READ A$
120 PRINT VAL("&H"+A$)
130 NEXT
140 END
200 REM ByteniZ3R v0.9.16.0
210 REM Project: Example BASIC
220 REM Sine
230 REM Length=32; Min=0; Max=255; Phase=0; Freq=1
240 DATA 80,99,B2,C8,DC,EC,F7,FE
250 DATA FF,FB,F2,E4,D3,BD,A6,8C
260 DATA 73,59,42,2C,1B,D,4,
270 DATA 1,8,13,23,37,4D,66,7F
```

    
#### Make it fast
  
If we want the data block to be read as fast as possible, the best way is in decimal `dec n` or hexadecimal `hex &HFF`. 
This way is about twice as fast as the previous one.
  
```basic
100 FOR BC=0 to 31
110 READ A
120 PRINT A
130 NEXT
140 END  
200 REM ByteniZ3R v0.9.16.0
210 REM Project: Example BASIC
220 REM Sine
230 REM Length=32; Min=0; Max=255; Phase=0; Freq=1
240 DATA 128,153,178,200,220,236,247,254
250 DATA 255,251,242,228,211,189,166,140
260 DATA 115,89,66,44,27,13,4,
270 DATA 1,8,19,35,55,77,102,127
```



<br/>

---

![Creative Commons License](https://i.creativecommons.org/l/by-nc/4.0/88x31.png) 
<br/>This document is licensed under a [Creative Commons Attribution-NonCommercial 4.0 International License](http://creativecommons.org/licenses/by-nc/4.0/).