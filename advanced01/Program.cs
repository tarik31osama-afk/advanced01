namespace advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  q1
            //A generic class is a class that uses a type parameter (T) instead of data type
            //using generic for Code Reusability ,Type Safety and Reduce Code Duplication

            #endregion

            #region q3
            //allow a generic class to work with more than one data type


            #endregion

            #region q4
            //A generic method is a method that uses type parameters to work with different data types

            void Swap<T>(ref T a, ref T b)
            {
                T temp = a;

                a = b;

                b = temp;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }


            #endregion

            #region q5
            T FindMax<T>(T a, T b)where T : IComparable<T> 
            {

                if (a.CompareTo(b)>0)
                {
                    return a;
                    
                }
                return b;

            }

            #endregion

            #region q6
            //A generic interface defines a contract using a type parameter

            #endregion

            #region q7

            //The struct constraint restricts the type parameter to value type

            
            #endregion

        }
    }
}
