using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exception_Handling_28._11._22
{
    internal class Manager
    {
        public static void q1()
        {
            try
            {
                int num1, num2 ,result; 
                num1 = int.Parse(Console.ReadLine());   
                num2 = int.Parse(Console.ReadLine());  
                result = num1 / num2;
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("0");
            }

        }
        public static void q2()
        {
            int result = 0;
            while(result == 0)
            {
                try
                {
                    int num1;
                    num1 = int.Parse(Console.ReadLine());
                    result = 770 / num1;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    result = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    result = 0;
                }
            }
           
        }
        // read file
        public static void q3()
        {
            string str;
            try
            {
                
                string file = "C:\\Users\\User\\source\\repos\\Exception_Handling_28.11.22\\Exception_Handling_28.11.22\\q3.txt";
                str = File.ReadAllText(file);
                Console.WriteLine(str);
            }
            catch(FileNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Read10Strings()
        {
            string[] str = new string[10];
            int sum = 0;
            for (int i = 0; i < 10;i++)
            {
                str[i] = Console.ReadLine();
                sum = sum + str[i].Length;   
                if(sum > 100)
                {
                    throw new OverflowException("String length bigger then 100");
                    
                }
            }
        }
    }
}
