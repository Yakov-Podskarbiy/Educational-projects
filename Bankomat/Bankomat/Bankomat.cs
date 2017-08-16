using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
   public class Bankomat
    {
        public string b_id;
        public  string _50;
        public string _100;
        public string _500;
        public string _1000;
        public string _5000;

        public int read_sum;

        public int sum;
       
       public void Input ( )
       
       {
           Console.WriteLine("ID:");

           b_id = Console.ReadLine();
          
           Console.WriteLine("50:");

           _50 = Console.ReadLine();

           Console.WriteLine("100:");

           _100 = Console.ReadLine();

           Console.WriteLine("500:");

           _500 = Console.ReadLine();

           Console.WriteLine("1000:");

           _1000 = Console.ReadLine();

           Console.WriteLine("5000:");

           _5000 = Console.ReadLine();

           sum = Int32.Parse(_50)*50 + Int32.Parse(_100)*100 + Int32.Parse(_500)*500 + Int32.Parse(_1000)*1000 + Int32.Parse(_5000)*5000;
           
       }

       public void Output()

       {

 
       }

       public void Check(string input_sum)
       {
           if(input_sum < sum)

       }
     

      
       
       
           
       

    }

   



}
