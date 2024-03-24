using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidBraces
{
    public class Brace
    {
        private int braceCountNormalOpen = 0; // {
        private int braceCountSquareOpen = 0; // [
        private int braceCountBracketOpen = 0; // (   
        private int braceCountNormalClose = 0; // }
        private int braceCountSquareClose = 0; // ]
        private int braceCountBracketClose = 0; // ) 


        public static bool ValidBraces(string braces)
        {
            char [] chars = braces.ToCharArray();
            int total = 0;

            total += chars.Count(c => c == '[' || c == '{' || c == '(');
            total -= chars.Count(c => c == ']' || c == '}' || c == ')');

            return total == 0;
        }
    }
}
