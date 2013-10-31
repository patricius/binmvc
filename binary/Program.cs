//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace binary
//{
//    class Program
//    {
//         static void Main(string[] args)
//         {
//             Program p = new Program();
//             Console.WriteLine(p.ConvertToBinary());
//             Console.ReadLine();
//         }
//        public string ConvertToBinary(int n) {
   
//        StringBuilder sb1 = new StringBuilder();
//            string s;
              
//            int remainder;
            
//            if (input > 0)
//            {
//                do
//                {
//                    remainder = input % 2;
//                    input = input / 2;
//                    sb1.Insert(0, remainder);
//                } while (input > 0);
//            }
//            return sb1.ToString();
//        }
//    }

