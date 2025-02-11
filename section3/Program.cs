namespace section3
{
    #region Delegation EX01
    // class
    // interface
    // enum
    // struct
    // delegate

    // Step 01: Create New DataType (Delegate)
    public delegate int StringFuncDelegate(string s);
    // New Delegate(Class): Reference (Pointer) Can Refer to Function Or More (pointer Of Function)
    // These Function Must Be Have The Same Signature Of The Delegate: int(sting)
    // Regardless Function Name, Parameters Names Or Access Modifiers

    #endregion

    #region Delegation EX02
    #endregion
    internal class Program
    {
        public static void PrintArr<T>(T[] Arr)
        {
            Console.WriteLine();
            foreach (var item in Arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static List<int> FindElements(List<int> list, Predicate<int> Referance)
        {
            List<int> Result = new List<int>();
            if (list?.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (Referance.Invoke(list[i]))
                        Result.Add(list[i]);
                }
            }
            return Result;
        }
        static void Main(string[] args)
        {
            #region Delegate EX01
            // Delegate : C# Feature

            // C# Pure OOP

            // Functional Programming
            // Event-Driven Programming

            // Java : Pure OOP
            // DP:

            // Step 02: Use Delegate
            //StringFuncDelegate X;
            //X = StringFunctions.GetCountOfUperCaseChars;

            //StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUperCaseChars);
            //StringFuncDelegate X = StringFunctions.GetCountOfUperCaseChars; // Syntax Suger
            //X += StringFunctions.GetCountOfLowerCaseChars;

            //int Count = X.Invoke("Hello World");
            //int Count = X("Hello World"); // Syntax Sugar
            //Console.WriteLine(Count);
            #endregion

            #region Delegate Ex02
            //int[] Numbers = [1, 5, 4, 2, 6, 4, 7, 9, 8];
            //PrintArr(Numbers);
            //SortConditionDelegate Assending = SortingCondition.CompareIfGreater;
            //SortConditionDelegate Desending = SortingCondition.CompareIfLess;
            //SortingAlgorithms.BubbleSort(Numbers, Assending);
            //PrintArr(Numbers);

            #endregion

            #region Delegate Ex02 With Generic
            //string[] Names = ["Ahmed", "Ali", "osman", "Medo", "Manar"];
            //PrintArr(Names);
            //SortConditionDelegate<string> Assending = SortingCondition.CompareIfGreater;
            //SortConditionDelegate<string> Desending = SortingCondition.CompareIfLess;
            //SortingAlgorithms.BubbleSort(Names, Assending);
            //PrintArr(Names);
            #endregion

            #region 05 Delegate Ex03
            //// generate numbers from 1 to 100
            ////List<int> Numbers =(List<int>) Enumerable.Range(1, 100);
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();
            //List<int> OddList = FindElements(Numbers, ConditionFunctions.CheckOdd);
            //List<int> EvenList = FindElements(Numbers, ConditionFunctions.CheckEven);
            //List<int> DivisableBy4 = FindElements(Numbers, ConditionFunctions.CheckDivisableBy4);
            //PrintList<int>(Numbers);
            //PrintList<int>(OddList);
            //PrintList<int>(EvenList);
            //PrintList<int>(DivisableBy4);
            #endregion

            #region 07 Built-in Delegate
            // Built-in Delegate
            // Predicate, Fun, Action


            //ConditionFuncDelegate X = ConditionFunctions.CheckOdd;

            // Predicate
            // take any type but just one parameter and return boolen 
            //Predicate<int> predicate = ConditionFunctions.CheckOdd;
            //predicate.Invoke(1);
            //predicate(1);

            //// Func
            //// work with not void fun take parameters from 0->16
            //// fun take zero parameters and return int
            //Func<int> func = Fun1;
            //// fun take one parameters(string) and return int
            //Func<string,int> func1 = Fun2;

            //Func<int, bool> predicate1 = ConditionFunctions.CheckOdd;
            //// Action
            //// Void Fun and one Parameter
            //Action<int> action = print;
            #endregion

            #region 08 Anonymous Method & Lambda Expression
            List<int> Numbers = Enumerable.Range(1, 10).ToList();

            // Anonymous Method
            // C# 2.0 2005

            //Func<int, bool> func = delegate (int X) { return X % 2 == 0; }; // Anonymous Method

            //FindElements(Numbers, delegate (int X) { return X % 2 == 0; });

            // Lambda Expression [Recommended]
            // C# 3.0 2007

            Func<int, bool> func = X => X % 2 == 0; // Lambda Expression

            //FindElements(Numbers, delegate (int X) { return X % 2 == 0; });
            FindElements(Numbers, N => N % 2 == 0);
            FindElements(Numbers, N => N % 2 != 0);
            #endregion
        }
        public static void print(int x)
        {
            Console.WriteLine("Hello World");
        }
        public static int Fun1()
        {
            return 1;
        }
        public static int Fun2(string X)
        {
            return 1;
        }
    }
}
