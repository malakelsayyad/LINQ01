using System.Runtime.CompilerServices;
using static Demo.ListGenerator;

namespace Demo
{
    internal class Program
    {
        #region Implicitly-Type Local Variables  [var - dynamic ]
        //public static var Print(var X)
        //{
        //    return X;
        //}

        //public static dynamic Print(dynamic X)
        //{
        //    return X;
        //} 
        #endregion


        static void Main(string[] args)
        {
            #region Implicitly-Type Local Variables  [var - dynamic ]

            //Implicitly-Type Local Variables [var - dynamic ]

            //var

            //var Data01 = "Ahmed";

            //Compiler can detect the datatype of the local variable based on its initial value [at compilation time]
            //Local variable must be initialized
            //Can't be initialized with null 
            //Can't change its datatype after being initialized 
            //Can't be used as a return type or as a parameter

            //Data01 = 12; // invalid

            //dynamic : like var in JS

            //dynamic Data02 = null ;
            //Console.WriteLine(Data02.GetType().Name);// Exception


            //CLR detects datatype based on last value [at runtime ]
            //It doesn't need to be initialized
            //It can be initialized with null
            //Can change its datatype after being initialized 
            //Can be used as a return type or as a parameter
            //Be Careful when using dynamic 
            //Like var in Js or object in C#

            //Data02 = 12;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4f;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.4m;
            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = true;
            //Console.WriteLine(Data02.GetType().Name);

            //var X = 12;

            //var X = () => Console.WriteLine("Hello World");
            //dynamic X = delegate () { Console.WriteLine("Hello World"); }; // invalid
            //We can't use dynamic with delegates

            #endregion

            #region Anonymous Type

            //Employee E01 = new Employee() { Id=1 Name = "Ahmed", Salary=12000};

            //var E01 = new { Name="Ahmed", Id=1, Salary=12000.0m};
            //var E02 = new { Name="Ali", Id=2, Salary=15000.0m};

            //var E02 = E01 with { Id=2}; // New Feature in C# 10.0

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);

            //E01.Id = 12; // Invalid : Immutable Can't change its value after creation

            //Console.WriteLine(E01.GetType().Name); //<>f__AnonymousType0`3
            //Console.WriteLine(E02.GetType().Name); //<>f__AnonymousType0`3

            //The same anonymous type as long as :
            //1.Same property name [Case sensitive]
            //2.Same property order

            //Console.WriteLine(E01); // { Id=1 Name="Ahmed", Salary=12000}
            //Compiler will override ToString 

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());

            //Console.WriteLine(E01);
            //Console.WriteLine(E02);

            //if(E01.Equals(E02)) // Compiler will override Equals()
            //    Console.WriteLine("E01 == E02");
            //else
            //    Console.WriteLine("E01 != E02");


            #endregion

            #region Extension Methods

            //long Number = 12345;

            //var result = IntExtension.Reverse(Number); // As class member method

            //var result = Number.Reverse();//Extension method

            //Console.WriteLine(result);//54321


            #endregion

            #region What is LINQ

            // LINQ : Language Integrated Query
            //      : 40+ Extension Methods (LINQ Operators) Against any data in sequence
            //      : Regardless Data store
            //      : 13 Category    
            //      : LINQ operators exist in built-in class "Enumerable"  

            // Sequence : Object implements interface IEnumerable
            // Local Sequence  : L2O , L2XML
            // Remote Sequence : L2EF

            // Input Sequence --> LINQ Operator --> Output Sequence
            // Input Sequence --> LINQ Operator --> 1 Value
            //                --> LINQ Operator --> Output Sequence

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //var Result = Enumerable.Any(Numbers, N => N % 2 == 0);      
            //var Result = Enumerable.Range(1,100);

            //Console.WriteLine(Result);

            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} ");
            //}

            #endregion

            #region LINQ Syntax

            //1.Fluent Syntax
            // We use LINQ methods
            //1.1 LINQ operator as => Class member method through Enumerable

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Enumerable.Where(Numbers,X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item}  ");
            //}

            //1.2 LINQ operator as => Extension Method through sequence

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item}  ");
            //}


            //2.Query Syntax [Query expression] like SQL Syntax
            //Start from
            //End select , group by 
            //Query syntax easier than fluent (Join, Group By , Let , Into) 

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = from N in Numbers
            //              where N % 2 == 0
            //              select N;


            //foreach (var item in Numbers)
            //{
            //    Console.Write($"{item}  ");
            //}
            /*
             Select N
               From Numbers
             Where N % 2 = 0
             */


            #endregion

            #region LINQ Execution ways

            //1.Differed Execution Way  : 10 Categories

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0); //Differed

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result) //Here
            //{
            //    Console.Write($"{item}  "); //2,4,6,8,10,12,14
            //}

            //2.Immediate Execution Way : 3 Categories [Elements , Casting , Aggregate]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0).ToList(); //Immediate

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });

            //foreach (var item in result)
            //{ 
            //    Console.Write($"{item}  ");  //2,4,6,8,10
            //}

            #endregion

            #region Setup Data

            //ProductList.Any();

            //Console.WriteLine(ProductList[0]);
            //Console.WriteLine(CustomerList[0]);

            //var result= ProductList.Where(P=>P.UnitsInStock==0);
            var result= CustomerList.Where(C=>C.City=="Berlin");

            foreach (var item in result) 
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
