using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_28._11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manager.q1();
            //Manager.q2();
            //Manager.q3();

            try
            {
                Manager.Read10Strings();
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }





            Console.WriteLine();
        }
    }
}
