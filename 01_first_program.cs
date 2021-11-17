using System;


namespace CSharp
{
    public class FirstProgram
    {
        public int x = 5;
        public string someString = "Hello";
        public char someChar = 'Z';

        public void whoAmI(String name)
        {
            Console.WriteLine("Hello " + name + " , how are you doing");
        }

        public int addTwo(int a,int b)
        {
            return a + b;
        }

    }
}