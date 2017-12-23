using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesExample
{
    delegate void Count(int x, int y);

    public class MyDelegateExample
    {
        public void Show()
        {
            Console.WriteLine("My delegate");

            Count count = Add;
            count += Substract;
            count += Multiply;
            count += Divide;

            count(10, 5);
        }

        private void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        private void Substract(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        private void Multiply(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        private void Divide(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}
