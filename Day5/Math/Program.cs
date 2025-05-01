using Math_Class;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cls1 class1 = new Cls1(20, 10);
            Console.WriteLine($"subtract {class1.subtract()}\n" +
                $"Add {class1.add()}\nMultiply {class1.multiply()}\ndivide {class1.divide()}");

            Console.WriteLine("---------------------");
            //static class
            Console.WriteLine($"subtract {Cls2.subtract(20,10)}\n" +
                $"Add {Cls2.add(20,10)}\nMultiply {Cls2.multiply(20,10)}\n" +
                $"divide {Cls2.divide(20,10)}");
        }
    }
}
