using System;
using System.Collections.Generic;
using System.Text;

namespace MultitapConverter
{
    public class MultitapEncoder
    { 
        public string EncodeToMultitap(string message)
        {
            if (message.Length > 255)
                throw new ArgumentOutOfRangeException("Message cannot have length bigger than 255.");


            
        }

        public string DecodeFromMultitap(string multitapCode)
        {
            throw new NotImplementedException();
        }
    }
}
