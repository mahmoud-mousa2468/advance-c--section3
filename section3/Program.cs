namespace section3
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            #region Delegate
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
        }
    }
}
