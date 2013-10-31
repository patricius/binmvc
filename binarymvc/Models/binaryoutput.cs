using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace binarymvc.Models
{
    public class binaryoutput
    {
    

        public String Binary
        {
            get; set;
        }


        public binaryoutput()
        {
           
        }

        public   binaryoutput(int input) {
   
        StringBuilder Binary2 = new StringBuilder();
      
              
            int remainder;
            
            if (input > 0)
            {
                do
                {
                    remainder = input % 2;
                    input = input / 2;
                    Binary2.Insert(0, remainder);
                } while (input > 0);
            }
            Binary = Binary2.ToString();
        }
}
}