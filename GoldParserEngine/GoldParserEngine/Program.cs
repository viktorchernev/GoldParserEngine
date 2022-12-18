using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldParser.Helpers;
using Microsoft.VisualBasic.CompilerServices;

namespace GoldParser
{
    internal class Program
    {
        static void Main(string[] args)
		{
            //https://github.com/meziantou/GoldParser-Engine/

            string filepath = @"C:\Users\vikto\Desktop\A.egt";

            //string toparse = @"C:\Users\vikto\Desktop\PORT\smartphone-locks.ds";
            //Parser parser = new Parser();
            //parser.LoadTables(filepath);
            //parser.Parse();

            string json = GrammarToJSON.ReadFile(filepath);
            bool breakpointer = true;
		}


		//structure = new CGTStructure(header, receaords);
		//content = new CGTContent(structure);
		//dfaStates = CreateDFAStates(content);
		//parserStates = CreateParserStates(content);
	}
}
