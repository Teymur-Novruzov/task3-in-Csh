using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace task3_10._04._2022___task1
//{
//    struct Point
//    {
//        public int x { get; set; }
//        public int y { get; set; }
//        public Point(int new_x, int new_y)
//        {
//            this.x = new_x;
//            this.y = new_y;
//        }
//        public override string ToString()
//        {
//            return $@" x is : {x}
// y is : {y}".ToString();
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point point1 = new Point(10, 1);
//            Console.WriteLine(point1);
//        }
//    }
//}

//namespace task_2
//{
//    class Counter
//    {
//        public int min { get; set; }
//        public int max { get; set; }
//        public int currentData { get; set; }
//        public Counter(int new_min,int new_max)
//        {
//            this.min = new_min;
//            this.max = new_max;
//            this.currentData = new_min;
//        }
//        public void Increment()
//        {
//            if (this.currentData == this.max)
//            {
//                this.currentData = this.min;
//            }
//            else
//            {
//            ++currentData;
//            }
//        }
//        public int getCurrent()
//        {
//            return this.currentData;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Counter c=new Counter(0,3);
//            c.Increment();
//            Console.WriteLine(c.getCurrent());
//            c.Increment();
//            Console.WriteLine(c.getCurrent()); 
//        }
//    }
//}

namespace task_3
{
    class Fraction
    {
        public int suret_1 { get; set; }
        public int mexrec_1 { get; set; }
        public int suret_2 { get; set; }
        public int mexrec_2 { get; set; }
        public int final_suret { get; set; }
        public int final_mexrec { get; set; }
        public void Start()
        {
            suret_1=Start_1();
            mexrec_1 = Start_2();
            suret_2=Start_1();
            mexrec_2 = Start_2();
            Picture();
            Final_funk();
        }
        public void Final_funk()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"                  {final_suret}
Your number is : ---
                  {final_mexrec}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" If you want again press '+' ");
            Console.WriteLine();
            Console.Write(" ===> : ");
            string again = Console.ReadLine();
            if (again == "+")
            {
                Start();
            }
        }
        public void Picture()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($@"   {suret_1}     {suret_2}
  --- ? ---
   {mexrec_1}     {mexrec_2}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Enter Your Choice : ");
            Console.WriteLine();
            Console.WriteLine($@" a) +    b) -    c) *    d) /  ");
            Console.WriteLine();
            Console.Write(" ===> : ");
            string choice_4 = Console.ReadLine();
            if (choice_4 == "a" || choice_4 == "A")
            {
                First_choice();
            }
            else if(choice_4 == "b" || choice_4 == "B")
            {
                Second_choice();
            }
            else if(choice_4 == "c" || choice_4 == "C")
            {
                Third_choice();
            }
            else if(choice_4 == "d" || choice_4 == "D")
            {
                Fourth_choice();
            }
            else
            {
                Picture();
            }
        }
        public void First_choice()
        {
            if (mexrec_1 == mexrec_2)
            {
                this.final_suret = this.suret_1 + this.suret_2;
                this.final_mexrec = this.mexrec_1;
            }
            else
            {
                final_mexrec = mexrec_1 * mexrec_2;
                suret_1 = suret_1 * mexrec_2;
                suret_2 = suret_2 * mexrec_1;
                final_suret = suret_1 + suret_2;
            }
        }
        public void Second_choice()
        {
            if (mexrec_1 == mexrec_2)
            {
                this.final_suret = this.suret_1 - this.suret_2;
                this.final_mexrec = this.mexrec_1;
            }
            else
            {
                final_mexrec = mexrec_1 * mexrec_2;
                suret_1 = suret_1 * mexrec_2;
                suret_2 = suret_2 * mexrec_1;
                final_suret = suret_1 - suret_2;
            }

        } 
        public void Third_choice()
        {      
            this.final_suret = this.suret_1 * this.suret_2;
            this.final_mexrec = this.mexrec_1*this.mexrec_2;     
        }
        public void Fourth_choice()
        {
            this.final_suret = this.suret_1 * this.mexrec_2;
            this.final_mexrec = this.mexrec_1*this.suret_2;
        }
        public int Start_1()
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write(" kesrin suretini daxil edin : ");
            return Check_int_1();
        } 
        public int Start_2()
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write(" kesrin mexrecini daxil edin : ");
            return Check_int_2();
        }
        public int Check_int_1()
        { 
            int number_1;
            bool check;
            string new_number;
            new_number=Console.ReadLine();
            check=int.TryParse(new_number, out number_1);
            if (check==true)
            {
                return number_1;
            }
            else
            {
                Start_1();
            }
            return number_1;
        }
        public int Check_int_2()
        { 
            int number_1;
            bool check;
            string new_number;
            new_number=Console.ReadLine();
            check=int.TryParse(new_number, out number_1);
            if (check==true&&number_1>0)
            {
                return number_1;
            }
            else
            {
                Start_2();
            }
            return number_1;
        }
    }
    
   class Program
    {
        static void Console_informations()
        {
            Console.Title = " Task three ";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 30;
            Console.WindowWidth = 50;
        }
        static void Main()
        {
            Console_informations();
            Fraction fraction = new Fraction();
            fraction.Start();
        }
    }
}
