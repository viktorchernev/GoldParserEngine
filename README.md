# GoldParserEngine
This is a rewrite of Devin Cook's GOLD Parser engine. 

IlSpy disassembly of version 5.0 have been used, as well as the following 
repository of user @meziatou - https://github.com/meziantou/GoldParser-Engine/

ArrayLists have been replaced to more convenient generic List<T>. 
Boxing and unboxing have been removed. Codebase have been organised in
namespaces and some methods and fields have been renamed for clarity sake.
Documentation comments have been added to all public classes and members.

Grammar reader classes are added, that can be used to translate .egt files 
contents to JSON and plain text. Those classes are public and can be found
in the "GoldParser.Helpers" namespace, and can be used separately from the 
parser in order to view the contents of compiled grammar files (.egt) - 
both the file structure and the grammar structure.

The "debug data" folder contaings output information from running those
reader classes on a custom .egt file, containing the tables for a simple 
markup language called Describe. Most of the modern programming languages
like C# or JavaScript will have way larger grammar tables...

The "grammars for the engine" folder contains grammars for the Gold Parser 
engine written by different people over time and downloaded from the
original website - https://goldparser.org/
