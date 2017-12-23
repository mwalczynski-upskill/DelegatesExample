using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesExample
{
    public class DelegateAsTransformerExample
    {
        public void Show()
        {
            Console.WriteLine("Func");

            Func<int, int> squarer = Square;
            Func<int, int> increaser = Increase;

            var values = new[] { 1, 2, 3 };
            Console.Write("Values:");
            ShowValues(values);

            Transform(values, increaser);
            Console.Write("Increased values:");
            ShowValues(values);

            Transform(values, squarer);
            Console.Write("Squared values:");
            ShowValues(values);
        }

        private int Square(int x) => x * x;
        private int Increase(int x) => x + 1;

        private void Transform(int[] values, Func<int, int> transformer)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = transformer(values[i]);
            }
        }

        private void ShowValues(int[] values)
        {
            foreach (var value in values)
            {
                Console.Write($" {value}");
            }
            Console.Write("\n");
        }
    }
}
