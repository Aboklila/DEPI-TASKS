using System;
using static System.Formats.Asn1.AsnWriter;
using System.Drawing;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Net.NetworkInformation;
//using System.IO;
//using System.Xml.Linq;


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

namespace task2c_.DEPI_SOLUTION
{
    internal class Program

    {
        static void Main(string[] args)
        {


            #region problem1_part01 
            // single comment one line
            /*
             multi
            line
            comment

             */
            //calucalase variable 

            /* int x = 10;
             int y = 20;
             int sum = x + y;
             Console.WriteLine(sum);*/


            #endregion

            #region question
            // What is the shortcut to comment and uncomment a selected block of code in Visual
            //Studio?
            //   Comment a block of code: Ctrl + K, then Ctrl +C
            //   Uncomment a block of code: Ctrl + K, then Ctrl +U
            //   or =====>> ctrl + /

            #endregion


            #region problem
            /*//هنا الفكره انصلحنا الكود وده الطريقه الصح وبعدين مينعش نجمع int &string
            int x1 = 10; // Correctly assign an integer value
            int y1 = 5;  // Declare and initialize the variable y

            Console.WriteLine(x1 + y1);  // Use the correct method name 'Console' and print the sum of x and y

            */
            #endregion

            #region Question:
            //Explain the difference between a runtime error and a logical error with examples  ?

            /* Runtime errors ===> stop the program from running correctly, often due to issues like invalid inputs or illegal operations.
             * 
             * 
             * EX//
             * 
             * int x = 10;
               int y = 0;
               int result = x / y;  القسمه علي صفر 
               Console.WriteLine(result);



             Logical errors ===>>  don't stop the program, but they lead to incorrect results or unexpected behavior. 
              They usually require careful debugging and testing to identify.

               EX//

                 int x = 10;
                 int y = 5;
                 int result = x - y * 2; -------------->(x-y)*2    
                 Console.WriteLine(result);  



             */
            #endregion



            #region 
            //string full_name = "ibrahim abdallah ";
            //int age = 20;
            //decimal salary = 20000;
            //bool is_Student = true;
            //Console.WriteLine("ur full name is " + full_name);
            //Console.WriteLine("ur age  is " + age);
            //Console.WriteLine($"ur salary is {salary}");
            //if (is_Student)
            //{
            //    Console.WriteLine(" is student ");
            //}
            //else
            //    Console.WriteLine("is_Student not student");


            #endregion
            #region
            //Why is it important to follow naming conventions such as PascalCase in C# ?


            //Readability     :    Code is easier to understand and navigate.
            //Maintainability :    Helps with long-term code upkeep.
            //Consistency     :    Ensures your code fits within the broader C# community and ecosystem.
            //Collaboration   :    Helps multiple developers work together efficiently.

            #endregion


            #region
            /*   // Create a new Person object and assign it to reference variable 'person1'
               Person person1 = new Person { Name = "Alice", Age = 30 };

               // Create another reference variable 'person2' pointing to the same object as 'person1'
               Person person2 = person1;

               // Display the initial values
               Console.WriteLine("Before modification:");
               Console.WriteLine("person1: Name = " + person1.Name + ", Age = " + person1.Age);
               Console.WriteLine("person2: Name = " + person2.Name + ", Age = " + person2.Age);

               // Change the values through person1
               person1.Name = "Bob";
               person1.Age = 35;

               // Display the modified values
               Console.WriteLine("\nAfter modification:");
               Console.WriteLine("person1: Name = " + person1.Name + ", Age = " + person1.Age);
               Console.WriteLine("person2: Name = " + person2.Name + ", Age = " + person2.Age);   */

            #endregion


            #region
            // Explain the difference between value types and reference types in terms of memory allocation.??


            /*  Value types   ====> are stored directly in memory(typically on the stack), and changes to one variable 
             * do not affect another.They are 
             * copied by value and are suitable for small, simple data.
             * 
             * 
             Reference types   =====>  on the other hand, store a reference to an object in memory(on the heap), 
             and multiple variables can point to the same object.Changes made to the object through one reference 
             affect all references pointing to that object.
            */
            #endregion

            #region
            /*
            int x = 15;
            int  y = 4;
            decimal Sum =x+y;
            decimal Difference =x-y;
            decimal Product= x*y;
            decimal Division= x/y;
            decimal Remainder = x%y;
            Console.WriteLine($"the sum {Sum}");
            Console.WriteLine($"the Difference {Difference}");
            Console.WriteLine($"the Product {Product}"); 
            Console.WriteLine($"the Division {Division}");
            Console.WriteLine($"the Remainder {Remainder}");


            */



            #endregion
            #region
            //int a = 2, b = 7;
            //Console.WriteLine(a % b); //====>  2 moduls

            #endregion

            #region 
            //int num;
            // Console.Write("enter ur num : ");

            // num =int.Parse( Console.ReadLine());
            // if ((num >= 10) && (num%2 == 0))
            // {
            //     Console.Write(true);
            // }
            // else
            // {
            //     Console.Write(false);
            // }




            #endregion



            #region
            /*
 
            Feature                   |   Logical AND(&&)           |         Bitwise AND(&)
            ------------------------------------------------------------------------------------------------
            Type of Operation         |  Logical(boolean)           |        Bitwise or logical
            Operands                  | Booleans                    |        Booleans or integers
            Short - circuiting        |    Yes                      |             No
            Use Case                  | Logical conditions          |        Bit manipulation


            */
            #endregion



            #region


            // implicit casting
            int num1 = 42;
                double implicitResult = num1; 
                Console.WriteLine($"impilict costing: {implicitResult}");

              //expicit costing
                double num2 = 42.78;
                int explicitResult = (int)num2; 
         
                Console.WriteLine($"expicit costing : {explicitResult}");


            #endregion


            #region
            //What exception might occur if the input is invalid and how can you handle it
            //Using TryParse(Preferred for Simplicity)
            //Using try-catch
            #endregion


            #region


           // Given the code below, what is the value of x after execution? Explain why
              int x = 5;
              int y = ++x + x++;
            Console.WriteLine( y);
            #endregion 

        }
    }
}
