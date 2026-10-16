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

            void Swap<T>(T a, T b)
            {
                T temp = a;

                a = b;

                b = temp;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            
            
            #endregion

      
        }
    }
}
