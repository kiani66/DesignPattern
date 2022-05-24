using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor
{
    class EncriptionDecretor : DataSourceDecoretor
    {
        public EncriptionDecretor(DataSource source):base(source)
        {

        }
        public override string Read()
        {
            var data = base.Read();
            return Decription(data);
        }
        public override void Write(string Data)
        {
            var result = encription(Data);
            base.Write(result);
        }
        private string encription(string data)
        {
            Console.WriteLine("Date Encripted");
            return data;
        }
        private string Decription(string data)
        {
            Console.WriteLine("Date Decripted");
            return data;
        }
    }
}
