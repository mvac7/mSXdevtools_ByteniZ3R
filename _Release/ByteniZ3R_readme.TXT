ByteniZ3R devtool 
(formerly called BytesGen)

Short:        Another generator of data tables in Bytes.         
Author:       mvac7
Version:      0.9.1b (August 2021)
Architecture: Microsoft .Net Framework 4.0
Programming language: Visual BASIC .net
License:      GNU General Public License v3  


--------------------------------------------------------------------------------
Index:

  1. Description
  2. License
  3. Requirements
  4. How to Install and Run
  5. News in version
  
  6. User Guide
  6.1 How does it work
  6.2 Project Menu
  6.3 Waveforms
  6.4 Data output format
  6.5 Saving the result
  
  7 Programming information
  7.1 How to read data in MSX BASIC



--------------------------------------------------------------------------------
1. Description

  Generates tables of 8 bits unsigned values, from waveforms or binary files, 
  in different programming languages (BASIC, C or ASM).

  This tool made for cross-developing MSX programs but can be useful for anyone 
  who needs 8bit data tables. 
     
  This software was developed in Microsoft Visual Basic 2010 Express. 
     
  The most current versions have a new name because one day I woke up with the 
  need to provide a unique and cool name. 
  The thinking brain behind the new name is Mr. Fubukimaru.



--------------------------------------------------------------------------------
3. License

   Copyright (C) 2021 mvac7

   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
   See the GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <http://www.gnu.org/licenses/>.



--------------------------------------------------------------------------------
3. Requirements 
 
   PC with Windows OS and Framework 4.0
   
   

--------------------------------------------------------------------------------
4. How to Install and Run
 
Unpack ByteniZ3R ZIP somewhere on your hard disk (It is not inside a folder). 
   
For run, execute ByteniZ3R.exe  
   


--------------------------------------------------------------------------------
5. News in version 
   
     * Save/Load Project.
     * Add Project Info.
     * Move Random tab to waveform.
     * Add Square waveform.
     * Add Triangle waveform.
     * Add Sawtooth waveform.
     * Add Reverse Sawtooth waveform.
     * Add Phase property, to move the waveform.
     * Add Frequency property.
     * Add sliders in all wave form values.
     * Improvements in the visualization of the graphic output of the wave.
     * In the output it shows the parameters in a comment.
     * Save binary file from output (with compression). For assemblers and 
       compilers that allow to include binary files.
     * Refresh output data and graphic when the input data are modified.
     * Show hex dump from a loaded binary file.
     * Config for paths and default output type data.
     * More internal improvements.


--------------------------------------------------------------------------------
6. User Guide:

6.1. How does it work

The flow of utilization is from top to bottom and from left to right.

In any use case, we can start by giving the project a name and information about
it (group, author and description), and then choose the type of data we want to 
generate and modify its properties.
   
The next step will be to indicate the output format, such as the programming 
language and number system (decimal, hexadecimal or binary).
   
Finally, we can select the output text and copy it to our programming 
environment or save it to a text or binary file.
         


6.2 Project Menu
    
At the top of the main window we have the project menu, with the following 
options:
   
   New > Start a new project. Delete all the information of the current project.
   
   Load Project > Shows a dialog that allows you to load projects saved in 
   native format (.XBYT).
   
   Attention! You can also load a project by dragging and dropping the file to 
   the main window.     
   
   Save Project > Save the configuration of a project (.XBYT)
   
   Edit Project info > Allows you to edit the name, version, group, author and 
   description of the project.
   
   Config > It shows a window where you can edit the paths of the different 
   files of the devtools applications, and the default configuration of the data
   output format.
   
   Help > It is not available in this version.
   
   About > Version and license information for the application.
   

  
6.3 Waveforms

   It has 6 waveform generators, which can be useful for movement paths for 
   graphic figures (Sprites) or visual effects.
   
   Attention! In a future version, it can be generated in signed byte format, 
   so it can be used to generate Waves for the SCC sound processor.
   
   The waveforms are: Sine, Cosine, Square, Triangle, Sawtooth and Noise.
   
   It has several parameters to adjust the form:
   
   > Length (8-1024): Number of bytes dedicated to drawing the shape.
   > Min & Max (0-255): Defines the smallest and the highest value of the form.
   > Phase (0-359): Shifts the wave n degrees.
   > Frecuency (1-256): Number of times the shape will be repeated.

                 
                 

6.4 Data output format

   In the output area, we have a form to define the format, such as the 
   programming language, numeric format and compression.

   Code type: 
              BASIC 
              C 
              Assembler

   Number System:  
            Supports various number systems and formats for different 
            compilers or assemblers.
            
              decimal nnn 
              decimal nnnd 
              hexadecimal FF 
              hexadecimal 0xFF 
              hexadecimal $FF 
              hexadecimal #FF 
              hexadecimal 0FFh 
              hexadecimal &HFF


   Size Line: 
               1,2,4,8, 16, 24 or 32
 

   Assembler > Command. 
               Command used for assembler data.
               Default = "DB"
                     
   C > Type  > Variable declaration type
               Default = "const char"
               
   C y Assembler > Field name
               Name of the field or label.

   BASIC
         > Initial Line: Start line number. Default = 1000
         > Increment: Increment between lines. Default = 10
         > Remove 0 (checkbutton): It does not show the zeros to save on the 
                                   size of the listings. 



6.5 Saving the result   

   Once we have the data, we can copy and paste the code to our editor or work 
   environment, selecting the text and using the "Copy" option from the context 
   menu (Ctrl+C) or we can copy all the text by pressing the "Copy All" button 
   located in the lower right part of the main window.
   
   or you can also:  
   
     [Save BIN] Save the output to a binary file.
   
     [Save TXT] Saves the output text with the extension of the selected 
                language (.BAS; .C; .ASM/.S)    
   


--------------------------------------------------------------------------------   
7 Programming information

  Here you will find some advice on how to read the data.
  
  The application includes a folder (code_examples\) where you will find 
  programming examples.
  
   
  
7.1 How to read data in MSX BASIC

   For MSX BASIC it can be generated in different formats, but there are two 
   ways that I recommend depending on what you need:


   * That occupies little
   
   If we work with a very large list and we need to reduce size, the best way 
   is to use the "hex FF" format and remove0. In this way, a value will occupy 
   0 to 2 Bytes, but it has a drawback: execution is slower, because each 
   alphanumeric data must be converted to a numeric value using the VAL 
   instruction.    

    20 FOR BC=0 to 15
    30 READ A$
    40 PRINT VAL("&H"+A$)
    50 NEXT
    60 END
    90 DATA ,1,4,8,D,13,1A,22
    91 DATA 2B,35,40,4B,57,63,70,7C

    
   * Make it fast
  
   If we want the data block to be read as fast as possible, the best way is in 
   decimal "dec nnn". This way is about twice as fast as the previous one.
  
    20 FOR BC=0 to 15
    30 READ A
    40 PRINT A
    50 NEXT
    60 END  
    90 DATA 0,1,4,8,13,19,26,34
    91 DATA 43,53,64,75,87,99,112,124