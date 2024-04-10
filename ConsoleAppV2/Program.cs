using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppV2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            act1();
            act2();
            act3(num);
            act4();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            act5(list);
            act6();
            act7();
            act8();
            act9();

            Console.WriteLine("Hello, World!");
        }

        public static void act1()
        {
            try
            {
                string filePath = "D:\\Activity\\orders1.csv";
                string fileContents = System.IO.File.ReadAllText(filePath);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static void act2()
        {
            try
            {
                Console.WriteLine("Enter numbers:");
                string inpNum = Console.ReadLine();
                int num = Int32.Parse(inpNum);
                if(num < 0)
                {
                    Console.WriteLine("This number is lessthan 0.");
                }
                else if(num > 1000 )
                {
                    Console.WriteLine("This number is greather than 1000.");
                }
            }
            catch (Exception)
            {
            }
        }

        public static void act3(int[] arrNum)
        {
            //Console.WriteLine("Enter numbers:");
            //string inpNum = Console.ReadLine();
            //int num = Int32.Parse(inpNum);
            try
            {
                if (arrNum != null)
                {
                    double totalSum = arrNum.Sum();
                    decimal aveNum = (decimal)totalSum / arrNum.Length;
                    Console.WriteLine("Average number is "+aveNum+".");
                }
                else
                {
                    Console.WriteLine("Array is empty");
                }                    
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void act4()
        {
            Console.WriteLine("Enter numbers:");
            string inpNum = Console.ReadLine();
            int num = Int32.Parse(inpNum);
        }

        public static void act5(List<int> listNum)
        {
            //Console.WriteLine("Enter numbers:");
            //string inpNum = Console.ReadLine();
            //int num = Int32.Parse(inpNum);
            foreach (var i in listNum)
            {
                if(i < -2147483648 || i > 2147483648)
                {
                    Console.WriteLine("this is not the range of int32.");
                }
            }
            
        }

        public static void act6()
        {
            Console.WriteLine("Enter numbers:");
            string inpNum = Console.ReadLine();
            int num1 = Int32.Parse(inpNum);
            Console.WriteLine("Enter numbers:");
            string inpNum2 = Console.ReadLine();
            int num2 = Int32.Parse(inpNum2);

            try
            {
                double ret = num1 / num2;
                if(ret <= 0)
                {
                    Console.WriteLine("result is 0.");
                }
                else
                {
                    Console.WriteLine("The result is" + ret.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void act7()
        {
            DateTime dt = new DateTime();
            string dt_now = dt.ToString("dd/mm/yyyyy");
            Console.WriteLine(dt_now);
        }

        public static void act8()
        {
            try
            {
                Console.WriteLine("Enter numbers:");
                string inpNum = Console.ReadLine();
                int num = Int32.Parse(inpNum);
                double sqrnum = Math.Sqrt(num);

                if (sqrnum < 0)
                {
                    Console.WriteLine("less than 0 or negative");
                }
            }
            catch (Exception)
            {
                throw;

            }            
        }

        public static void act9()
        {
            try
            {
                Console.WriteLine("Enter numbers:");
                string inpStr = Console.ReadLine();
                if(inpStr != null)
                {
                    inpStr = inpStr.ToUpper();
                    Console.WriteLine(inpStr);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
