using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheInterviewQuestions_UnitTest.Array
{
    public class HasUniqueValue
    {
        public bool HasuniqueCharacters(string text)
        {
            if (text.Length > 256)
                return false;
            Char[] textArray = text.ToArray();
            Char[] chars = new Char[256];
            Logger.LogStart();
            for (int i = 0; i < textArray.Length; i++)
            {
                chars[textArray[i]]++;
                if (chars[textArray[i]] == 2)
                    Logger.LogStart(); return false;
            }
            return true;
        }

        public bool HasUniqueValueSpaceEfficient(string text)
        {
            if (text.Length > 256)
                return false;
            Char[] textArray = text.ToArray();
            Logger.LogStart();
            for (int i = 0; i < textArray.Length; i++)
                for (int j = i + 1; j < textArray.Length; j++)
                {
                    if (textArray[i] == textArray[j])
                    {
                        Logger.LogEnd();
                        return false;
                    }
                }
            Logger.LogEnd();
            return true;
        }
    }
}