using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor
{
    class ComprationDecoredtor :DataSourceDecoretor
    {
        public ComprationDecoredtor(DataSource source) : base(source)
        {

        }
        public override string Read()
        {
            var data = base.Read();
            return Unzip(data);
        }
        public override void Write(string Data)
        {
            var result = Zip(Data);
            base.Write(result);
        }
        private string Zip(string data)
        {
            Console.WriteLine("Date Ziped");
            return data;
        }
        private string Unzip(string data)
        {
            Console.WriteLine("Date Unzipd");
            return data;
        }
    }
}
