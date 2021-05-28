using System;
using System.Collections.Generic;
using System.Text;

namespace MultitapConverter
{
    public class MultitapEncoder
    {
        Dictionary<string, string> dictionaryKeys;

        public MultitapEncoder()
        {
            dictionaryKeys = new Dictionary<string, string>
            {
                {"A","2"}, {"B","22"}, {"C","222"}, {"D","3"}, {"E","33" }, {"F","333"},
                {"G","4"}, {"H","44"}, {"I","444"}, {"J","5"}, {"K","55"}, {"L","555"}, {"M","6"},
                {"N","66"}, {"O","666"}, {"P","7"}, {"Q","77"}, {"R","777"}, {"S","7777"},
                {"T","8"}, {"U","88"}, {"V","888"}, {"W","9"}, {"X","99"}, {"Y","999"}, {"Z","9999"},
                {" ","0"}
            };
        }

        public string EncodeToMultitap(string message)
        {
            message = message.ToUpper();

            if (message.Length > 255)
                return "Message cannot have length bigger than 255.";

            string result = "";
            string previousKeyLastDigit = " ";
            foreach (char c in message)
            {
                if (char.IsDigit(c))
                    return "Message cannot have any digits.";

                if (dictionaryKeys.TryGetValue(c.ToString(), out string value))
                {
                    if (value.StartsWith(previousKeyLastDigit))
                        result += "_";

                    result += value;
                    previousKeyLastDigit = value.Substring(0,1);
                }                
            }
            return result;
        }

        public string DecodeFromMultitap(string multitapCode)
        {
            throw new NotImplementedException();
            //while (message.Length > 0)
            //{
            //    for(int i=3; i>0; i--)
            //    {
            //        string firstValues = message.Substring(0, i);

            //        *buscar no dicionario se o valor existe
            //        *retirar codigo usado da string
            //    }
            //}
        }
    }
}
