using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Decoretor DesignPattern
            Decoretor.FileDataSource source = new Decoretor.FileDataSource("Test.txt");
            var compration = new Decoretor.ComprationDecoredtor(source);
            var DataEncription = new Decoretor.EncriptionDecretor(compration);
            DataEncription.Write("Data1");
            Console.WriteLine("===============");
            Console.WriteLine(DataEncription.Read());
            Console.ReadKey();
            #endregion
        }
    }
}
