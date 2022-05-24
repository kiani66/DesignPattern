using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoretor
{
    class DataSourceDecoretor : DataSource
    {
        protected DataSource dataSource;
        public DataSourceDecoretor(DataSource source)
        {
            this.dataSource = source;
        }
        public override string Read()
        {
            return dataSource.Read();
        }
    
        public override void Write(string Data)
        {
            dataSource.Write(Data);
        }
    }
}
