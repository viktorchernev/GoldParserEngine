using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldParser.Grammar;

namespace GoldParser.Helpers
{
    public static class GrammarToText
    {
        public static string productionToText(GrammarProduction production, bool alwaysDelimitTerminals)
        {
            return production.Head.ToString() + " ::= " + symbolListToString(production.Handle, " ", alwaysDelimitTerminals);
        }
        public static string symbolListToString(List<GrammarSymbol> list, string separator, bool alwaysDelimitTerminals)
        {
            string result = "";
            for (int n = 0; n <= list.Count - 1; n++)
            {
                GrammarSymbol symbol = list[n];
                result += (n == 0 ? "" : separator) + symbol.ToString(alwaysDelimitTerminals);
            }

            return result;
        }


        public static string symbolToText(GrammarSymbol symbol, bool alwaysDelimitTerminals)
        {
            switch (symbol.Type)
            {
                case GrammarSymbolType.Nonterminal:
                    return "<" + symbol.Name + ">";
                case GrammarSymbolType.Terminal:
                    return symbolFormatLiteral(symbol.Name, alwaysDelimitTerminals);
                default:
                    return "(" + symbol.Name + ")";
            }
        }
        public static string symbolFormatLiteral(string source, bool forceDelimit)
        {
            if (source == "'") return "''";

            for (int i = 0; i < source.Length && !forceDelimit; i++)
            {
                char ch = source[i];
                forceDelimit = !(char.IsLetter(ch) || ch == '.' || ch == '_' || ch == '-');
            }

            if (forceDelimit) return "'" + source + "'";
            return source;
        }
    }
}
