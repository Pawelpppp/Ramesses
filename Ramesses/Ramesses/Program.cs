using Ramzes.Reader;
using System;

namespace Ramesses
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new LoadData().ReadData("InData.txt");
            Console.WriteLine("Data Loded");
        }
    }
}
