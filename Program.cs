using System;

namespace P1
{
    class Program
    {
        public static double add(double a, double b)
        {
            return a+b;
        }
        public static double sub(double a, double b)
        {
            return a-b;
        }
        public static double  mul(double a, double b)
        {
            return a*b;
        }

        public static double div(double a, double b)
        {
            return a/b;
        }
        static void Main(string[] args)
        {
            var name="";
            var a=0.0;
            var b=0.0;
            var se=0;
            var sum=0.0m;
            var sub =0.0m;
            var mul=0.0m;
            var div=0.0m;
            var quit =false;
            var choice='e';

            while(name=="")
            {
                Console.WriteLine($"Hello User!!");
                Console.WriteLine($"Enter your name:");
                name=Console.ReadLine();

            }
            Console.WriteLine($"Welcome to basic Arthimetic operations App{name}!!");

do{
            Console.WriteLine($"Enter the value of a:");
            var ad=Console.ReadLine();
            a=Convert.ToDouble(ad);
            Console.WriteLine($"Enter the value of b:");
            var ac=Console.ReadLine();
            b=Convert.ToDouble(ac);
            Console.WriteLine($"Please select your choices");
            Console.WriteLine($"Enter 1 for Addition, 2 for Subtraction, 3 for multiplication, 4 for division");
            var ch=Console.ReadLine();
            se=Convert.ToInt16(ch);
            switch(se)
            {
                case 1:var su =Program.add(a,b);
                       sum = Convert.ToDecimal(su);
                       Console.WriteLine($"Sum is {sum}");
                break;
                case 2:var sb = Program.sub(a,b);
                 sub = Convert.ToDecimal(sb);
                    Console.WriteLine($"Subtraction value is{sub}");
                break;

                case 3:var ml=Program.mul(a,b);
                 mul = Convert.ToDecimal(ml);
                Console.WriteLine($"Multiplication value is{mul}");
                break;
                case 4:var s=Program.div(a,b);
                div=Convert.ToDecimal(s);
                Console.WriteLine($"Division value is {div}");
                break;

            }

            Console.WriteLine($"Press e to exit or any key to continue");
            var x=Console.ReadLine();
            choice=Convert.ToChar(x);
            if (choice == 'e')
            {
                quit = true;
                Console.WriteLine($"Thank you for using my app");
            }
        }
        while(quit==false);


            
        }
    }
}
