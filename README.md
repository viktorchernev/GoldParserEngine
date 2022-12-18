# GoldParserEngine
This is a rewrite of Devin Cook's GOLD Parser engine. 

I have done this because I wanted to understand the engine well, in order
to be able to utilise it in some project efficiently, and possibly port
it to JavaScript and/or PHP, if it haven't been ported yet. But that is
another story.

I have used an IlSpy disassembly of version 5.0 as I wasn't able to find
up to date source code, as well as @meziatou's version of the engine - 
https://github.com/meziantou/GoldParser-Engine/ , which is very similar.

I have cleaned up the code, added documentation and organized everything
better into namespaces, and fixed naming of some fields and methods. 

Also, I have added grammar readers that can be used to translate .egt files 
contents to JSON and plain text. Those classes are public and can be used 
separately from the parser in order to view the contents of a compiled 
grammar files
