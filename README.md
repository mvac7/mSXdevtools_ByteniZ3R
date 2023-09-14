# ByteniZ3R devtool 
(formerly called BytesGen)

![ByteniZ3R title logo](https://github.com/mvac7/mSXdevtools_ByteniZ3R/raw/main/GFX/ByteniZ3R_logo.png)
    
```
Short:        Waveform data table generator.         
Architecture: Microsoft .Net Framework 4.0
Programming language: Visual BASIC .net
License:      GNU General Public License v3   
```

## Sorry! This text is pending correction of the English translation
                                                               

<br/>

---

## Description

Generates tables of 8bits signed or unsigned values, from waveforms in different programming languages (BASIC, C or ASM).
It can be useful for generating graphics or creating paths to move [Sprites](https://en.wikipedia.org/wiki/Sprite_(computer_graphics)).

This tool is designed for the cross-development of computer programs with 8bits processors.

It includes [`examples`](Examples/) for various development environments of the MSX system (Assembler, C and MSX BASIC), 
which is what I know (sorry developers of other platforms).

This project is open source, so you can improve or adapt the tool to your needs.
   
This software was developed in Microsoft Visual Studio Community 2019.

You can access the documentation here with [`ByteniZ3R devtool User Guide`](Docs/HOWTO.md).
 

<br/>

---

## License

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

## Requirements:

* Windows OS with .net framework v4.0
* Display with minimum resolution: XVGA (1024x768)

<br/>

---

## Features

- 8bits signed or unsigned values
- 9 waveform generators: Sine, 1/2 Sine Upper, 1/2 Sine Lower, Cosine, Square, Triangle, Sawtooth, Reverse Sawtooth and Noise.
- Maximum and minimum adjustment.
- Phase and Frequency adjustmens.
- BASIC, C or Assembler output.
- Supports several number systems and data formats (decimal, hexadecimal or binary)
- Edit info project (Name, Version, Author, Group, and Description).
- Save/Load project files.
- Save output to source code 
- Save output to binary file

![ByteniZ3R screenshot](https://github.com/mvac7/mSXdevtools_ByteniZ3R/raw/main/GFX/screenshots/ByteniZ3R_v0916b_screenshot01.png)

<br/>

---

## History of versions

This application started in the year 2013 as a tool called BytesGen, to generate tables of random numbers.
I used it for the development of the visual effects application veejingSX for MSX computers.

Later I would add the option to load binary files and dump them in tables formatted for different programming languages.

The next step was to add waveforms. One of the applications for which I wanted to use it is to create paths for the movement of sprites, 
although I was also thinking of a future version (probably v1) that would allow generating samples for the SCC (requires signed Byte numbers).

In March 2022, I resumed this project which I had pending a v0.9b Release. 
Updated some classes, removed binary loading, and gave the frontend a new look.
The decision to remove the binary load is due to the fact that I have been developing several specific applications for different compressors for some time. 
This functionality is no longer required.

### ByteniZ3R v1.0b (? 2023)

- Added 8bits signed type.
- Expand max length to 2048 Bytes.
- Added 1/2 Sine Upper and 1/2 Sine Lower waveforms.
- Updated graphical interface (piXelST style). Added new UI controls and 32px icons.
- The waveform is drawn at the defined size (Before it was adjusted to the size of the box).
- The file format has been improved, so it is not compatible with the previous version (sorry).
- Added different assembler formats: asMSX, tniASM, SJasm and sdasz80(SDCC).

<br/>

### ByteniZ3R v0.9.17b (7 June 2022)

- Removed binary file handling function. (Apps for this feature will be available soon.) 
- Removed compress data (No compression is obtained with this data type)
- Add Reverse Sawtooth waveform
- Updated graphical interface (piXel style)
- Configure colors of the graph and the data output.
- Accepts tabs in the assembler output data format (add <tab>)
- It allows to obtain the data in binary numbers.
- Added binary number system in output data settings.

<br/>

### ByteniZ3R v0.9.1b (August 2021)

- Save/Load Project File.
- Add Project Info
- Move Random tab to waveform.
- Added Square waveform
- Added Triangle waveform
- Added Sawtooth waveform
- Added Phase property, to move the waveform.
- Added Frequency property.
- Added sliders in all wave form values.
- Improvements in the visualization of the graphic output of the wave.
- In the output it shows the parameters in a comment.
- Save binary file from output (with compression). For assemblers and compilers that allow to include binary files.
- Refresh output data and graphic when the input data are modified.
- Show hex dump from a loaded binary file.
- Config for paths and default output type data.
- More internal improvements.

<br/>

### BytesGen! v0.8.1b (January 2018) 

Not published.

<br/>

### BytesGen! v0.8b (May 2016) 

Not published.

<br/>

### BytesGen! v0.7.2.0b (February 2014)

- Output Textbox and buttons, added to the Output GroupBox.
- Clear button

<br/>

### BytesGen! v0.7.1.0b (?) 

Not published.

- Basic line changes do increase to 10 (before = 15). 
- Drag & drop a file from the system to the input file (binary file).
- Added new output formats data (hex).
- Output is cleared when switching tabs.

<br/>

### BytesGen v0.7.0.0b (May 2013) First published version

Requires: PC with Windows System and Framework 2.0

- Sinus table generator.
- Cosinus table generator.
- Random table generator.
- Data dump from a binary file.
- Supports output formats: C, MSX BASIC, Assembler and SDCC Assembler.

[Google Code](https://code.google.com/archive/p/bytes-gen/)

---
