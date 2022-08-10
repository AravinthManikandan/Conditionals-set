using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_conventions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region q1


            //Console.WriteLine("enter the number");
            //int x = int.Parse(Console.ReadLine());
            //if (x > 0)
            //{ Console.WriteLine("the given no is positive"); }
            //else if (x == 0)
            //{ Console.WriteLine(" the given no is zero"); }
            //else 
            //{Console.WriteLine("the given no is negative"); }
            #endregion
            #region q2


            //Console.WriteLine("enter the first number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the second number");
            //int b = int.Parse(Console.ReadLine());
            //if (a == b)
            //{ Console.WriteLine("the two integers are equal"); }
            //else
            //{ Console.WriteLine("the two integers are not equal"); }
            #endregion
            #region q3


            //Console.WriteLine("enter the first integer");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("enter the second integer");
            //float b = float.Parse(Console.ReadLine());
            //if (a == b)
            //{ Console.WriteLine("the given floating points are equal"); }
            //else
            //{ Console.WriteLine("the given floating points are not equal"); }
            #endregion
            #region q4


            //Console.WriteLine("enter the number");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{ Console.WriteLine("even"); }
            //else
            //{ Console.WriteLine("odd"); }
            #endregion
            #region q5


            //Console.WriteLine("enter a year");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 4 == 0 && a % 100 ==0 && a % 400 == 0)
            //{ Console.WriteLine("leap year"); }
            //else
            //{ Console.WriteLine("not a leap year"); }
            #endregion
            #region q6


            //Console.WriteLine("enter the age");
            //int a = int.Parse(Console.ReadLine());
            //if (a >= 18)
            //{ Console.WriteLine("he/she is eligible for voteing"); }
            //else
            //{ Console.WriteLine("he/she is not eligible for voting"); }
            #endregion
            #region q7


            //Console.WriteLine("enter the height 1 in cm");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("enter the height 2 in cm");
            //float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("enter the height 3 in cm");
            //float c = float.Parse(Console.ReadLine());
            //if (a>=160)
            //{
            //    Console.WriteLine("the height 1 taller");
            //}
            //if (b>=150)
            //{ 
            //    Console.WriteLine("the height 2 medium"); 
            //}
            //else
            //{ 
            //    Console.WriteLine("the height is 3 is smaller"); 
            //}
            #endregion
            #region q8
            //Console.WriteLine("first number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("second number");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("third number");
            //int c = int.Parse(Console.ReadLine());


            //int largest = a;
            //if (b > largest)
            //{
            //    largest = b;
            //}
            //if (c > largest)
            //{
            //    largest = c;
            //}
            //Console.WriteLine("the largest of three no is: " + largest);


            #endregion
            #region q9
            //Console.WriteLine("first number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("second number");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("third number");
            //int c = int.Parse(Console.ReadLine());


            //int smallest = a;
            //if (b < smallest)
            //{
            //    smallest = b;
            //}
            //if (c < smallest)
            //{
            //    smallest = c;
            //}
            //Console.WriteLine("the smallest of three no is: " + smallest);


            #endregion
            #region q10
            //Console.WriteLine("first number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("second number");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("third number");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("fourth number");
            //int d = int.Parse(Console.ReadLine());

            //int largest = a;
            //if (b > largest)
            //{
            //    largest = b;
            //}
            //if (c > largest)
            //{
            //    largest = c;
            //}
            //if (d > largest)
            //{
            //    largest = d;
            //}
            //Console.WriteLine("the largest of three no is: " + largest);


            #endregion
            #region q11
            // Console.WriteLine("first number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("second number");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("third number");
            //int c = int.Parse(Console.ReadLine());
            //if (Math.Abs(a - b) < Math.Abs(a - c))
            //{
            //    if (Math.Abs(a - b) < Math.Abs(b - c))
            //    {
            //        Console.WriteLine("closer pair is :" + a + ",," + b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("closer pair is :" + b + ",," + c);
            //    }
            //}
            //else
            //{
            //    if (Math.Abs(a - c) < Math.Abs(b - c))
            //    {
            //        Console.WriteLine("closer pair is :" + a + ",," + c);
            //    }
            //    else
            //    {
            //        Console.WriteLine("closer pair is :" + b + ",," + c);
            //    }

            #endregion
            #region q12


            //Console.WriteLine("first number");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("second number");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("third number");
            //int c = int.Parse(Console.ReadLine());
            //if (Math.Abs(a - b) > Math.Abs(a - c))
            //{
            //    if (Math.Abs(a - b) > Math.Abs(b - c))
            //    {
            //        Console.WriteLine("farther pair is :" + a + ":" + b);
            //    }
            //    else
            //    {
            //        Console.WriteLine("farther pair is :" + b + ":" + c);
            //    }
            //}
            //else
            //{
            //    if (Math.Abs(a - c) > Math.Abs(b - c))
            //    {
            //        Console.WriteLine("farther pair is :" + a + ":" + c);
            //    }
            //    else
            //    {
            //        Console.WriteLine("father pair is :" + b + ":" + c);
            //    }
            #endregion
            #region q13

            int d = GetInteger("Enter the first number: ");
            PrintMessage(d.ToString());
            int e = GetInteger("Enter the second number: ");
            PrintMessage(e.ToString());
            int f = GetInteger("Enter the third number: ");
            PrintMessage(f.ToString());

            if ((d < e) && (d < f) && (e < f))
            {
                Console.WriteLine("the sorting order of three number is 1st num, 2nd num, 3rd num ");
            }
            else if ((e < f) && (e < d) && (d < f))
            {
                Console.WriteLine("the sorting order of three number is 2nd num, 1st num, 3rd num ");
            }
            else if ((f < d) && (f < e) && (d < e))
            {
                Console.WriteLine("the sorting order of three number is 3rd num, 1st num, 2nd num ");
            }
            else if ((d < e) && (d < f) && (e > f))
            {
                Console.WriteLine("the sorting order of three number is 1st num, 3rd num, 2nd num ");
            }
            else if ((e < f) && (e < d) && (d > f))
            {
                Console.WriteLine("the sorting order of three number is 2nd num, 3rd num, 1st num ");
            }
            else if ((f < d) && (f < e) && (d > e))
            {
                Console.WriteLine("the sorting order of three number is 3rd num, 2nd num, 1st num ");
            }

            
            #endregion
            #region q14

            int angleone = GetInteger("Enter the first angle: ");
            PrintMessage(angleone.ToString());
            int angletwo = GetInteger("Enter the second angle: ");
            PrintMessage(angletwo.ToString());
            int anglethree = GetInteger("Enter the third angle: ");
            PrintMessage(anglethree.ToString());

            if (angleone + angletwo + anglethree == 180)
            {
                Console.WriteLine("It can form a triangle");
            }
            else
            {
                Console.WriteLine("It can't form a triangle");
            }


            
            #endregion
            #region q15

            int x = GetInteger("Enter the first point x: ");
            PrintMessage(x.ToString());
            int y = GetInteger("Enter the second point y: ");
            PrintMessage(y.ToString());

            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("The x and y lies on the 1st quadrant");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("The x and y lies on the 2nd quadrant");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("The x and y lies on the 3rd quadrant");
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine("The x and y lies on the 4th quadrant");
            }

            
            #endregion
            #region q16

            char letter = GetChar("enter the alphabate");
            PrintMessage(letter.ToString());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine("It is vowel");
            }
            else
            {
                Console.WriteLine("It is a constant");
            }


            
            #endregion
            #region q17

            int num = GetInteger("enter the sides of shape: ");
            PrintMessage(num.ToString());

            if (num == 3)
            {
                Console.WriteLine("It is a triangle");
            }
            else if (num == 4)
            {
                Console.WriteLine("It is quadrilateral");
            }
            else if (num == 5)
            {
                Console.WriteLine("It is pentagon");
            }
            else if (num == 6)
            {
                Console.WriteLine("It is hexagon");
            }
            else if (num == 7)
            {
                Console.WriteLine("It is heptagon");
            }
            else if (num == 8)
            {
                Console.WriteLine("It is octagon");
            }
            else if (num == 9)
            {
                Console.WriteLine("It is nanogon");
            }
            else if (num == 10)
            {
                Console.WriteLine("It is decogon");
            }


            #endregion
            #region q18

            string month = GetString("enter the month: ");
            PrintMessage(month.ToString());

            if (month == "januvary" || month == "march" || month == "may" || month == "july" || month == "augest" || month == "october" || month == "december")
            {
                Console.WriteLine("The number of days in the month is 31");
            }
            else if (month == "april" || month == "june" || month == "september" || month == "november")
            {
                Console.WriteLine("The number of days in the month is 30 ");
            }
            else if (month == "february")
            {
                Console.WriteLine("The number of days in the month is 28 or 29");
            }

            
            #endregion
            #region q19

            int day = GetInteger("Enter the days: ");
            PrintMessage(day.ToString());

            if (day == 1 || day == 8 || day == 15 || day == 22 || day == 29)
            {
                Console.WriteLine("It is monday");
            }
            else if (day == 2 || day == 9 || day == 16 || day == 23 || day == 30)
            {
                Console.WriteLine("It is tuesday");
            }
            else if (day == 3 || day == 10 || day == 17 || day == 24 || day == 31)
            {
                Console.WriteLine("It is wednesday");
            }
            else if (day == 4 || day == 11 || day == 18 || day == 25)
            {
                Console.WriteLine("It is thursday");
            }
            else if (day == 5 || day == 12 || day == 19 || day == 26)
            {
                Console.WriteLine("It is friday");
            }
            else if (day == 6 || day == 13 || day == 20 || day == 27)
            {
                Console.WriteLine("It is saturday");
            }
            else if (day == 7 || day == 14 || day == 21 || day == 28)
            {
                Console.WriteLine("It is sunday");
            }



            
            #endregion
            #region q20

            int la = GetInteger("Enter the length of A: ");
            PrintMessage(la.ToString());
            int lb = GetInteger("Enter the length of B: ");
            PrintMessage(lb.ToString());
            int lc = GetInteger("Enter the length of C: ");
            PrintMessage(lc.ToString());

            if (la == lb && lb == lc)
            {
                Console.WriteLine("It is equilateral triangle");
            }
            else if (la == lb || lb == lc || lc == la)
            {
                Console.WriteLine("It is a isosceles triangle");
            }
            else
            {
                Console.WriteLine("It is a scalene triangle");
            

            
            #endregion
            #region q21

            int mark = GetInteger("Enter the mark: ");
            PrintMessage(mark.ToString());

            if (mark >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (mark >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (mark >= 60)
            {
                Console.WriteLine("Grade: C");
            }
            else if (mark >= 50)
            {
                Console.WriteLine("Grade: D");
            }
            else if (mark < 50)
            {
                Console.WriteLine("Grade: F");
            }


            
            #endregion
            #region q22

            char row = GetChar("Enter the row from a to h: ");
            PrintMessage(row.ToString());
            int column = GetInteger("Enter the column from 1 to 8: ");
            PrintMessage(column.ToString());


            if ((row + column) % 2 == 0)
            {
                Console.WriteLine("The colour of the chess box is black");
            }
            else
            {
                Console.WriteLine("The colour of the chess box is white");
            }

            
            #endregion
            #region q23

            double D, x1, x2;
            double val1 = GetDouble("Enter the value of a (val1): ");
            PrintMessage(val1.ToString());
            double val2 = GetDouble("Enter the value of b (val2): ");
            PrintMessage(val2.ToString());
            double val3 = GetDouble("Enter the value of c (val3): ");
            PrintMessage(val3.ToString());

            if (val1 != 0)
            {
                D = (val2 * val2) - 4 * val1 * val3;
            }
            else
            {
                Console.WriteLine("The Quadratic equation not formed");
            }

            D = (val2 * val2) - 4 * val1 * val3;
            if (D >= 0)
            {
                D = Math.Sqrt(D);
                x1 = (-val2 + D) / 2 * val1;
                x2 = (-val2 - D) / 2 * val1;
                Console.WriteLine("X1 is: " + x1);
                Console.WriteLine("X2 is: " + x2);
            }
            else
            {
                Console.WriteLine("Roots are not possible");
            }





	        #endregion
            #region q24
             
            int sp = GetInteger("Enter the selling price: ");
            PrintMessage(sp.ToString());
            int cp = GetInteger("Enter the cost price: ");
            PrintMessage(cp.ToString());

            if ((sp - cp) > 0)
            {
                Console.WriteLine("It is a profit");
            }
            else
            {
                Console.WriteLine("It is a loss");
            }


	        #endregion
        }
         public static int GetInteger(string message)
        {
            PrintMessage(message);
            int temp = Convert.ToInt32(Console.ReadLine());
            return temp;
        }
        public static double GetDouble(string message)
        {
            PrintMessage(message);
            double temp = Convert.ToDouble(Console.ReadLine());
            return temp;
        }

        public static float GetFloat(string message)
        {
            PrintMessage(message);
            float temp = Convert.ToSingle(Console.ReadLine());
            return temp;
        }
        


        public static char GetChar(string message)
        {
            PrintMessage(message);
            char temp = Convert.ToChar(Console.ReadLine());
            return temp;
        }
        public static string GetString(string message)
        {
            PrintMessage(message);
            string temp = Convert.ToString(Console.ReadLine());
            return temp;

        }

                


        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        
            

}




