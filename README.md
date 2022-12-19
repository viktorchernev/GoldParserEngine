# GoldParserEngine
This is a rewrite of Devin Cook's GOLD Parser engine. 

ILSpy disassembly of version 5.0 of the engine have been used as a 
starting point, as well as the following repository of user @meziantou - 
https://github.com/meziantou/GoldParser-Engine/

The code has been cleaned up (from disassembly) and organized in 
namespaces and folders. ArrayLists have been replaced with List<T>,
and weird boxing and unboxing have been removed. Some methods and fields 
have been renamed to more appropriately represent their function.

Grammar and EGT format readers have been added that can be used to translate 
.egt files' contents to JSON and plain text. Those classes are public and 
can be used separately from the parser in order to view the contents of a 
compiled grammar files

P.S. Still needs to be tested ...
