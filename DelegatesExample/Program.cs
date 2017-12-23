using System;

namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDelegate = new MyDelegateExample();
            myDelegate.Show();

            var actionDelegate = new ActionExample();
            actionDelegate.Show();

            var func = new DelegateAsTransformerExample();
            func.Show();

            Console.ReadKey();
        }
    }
}
