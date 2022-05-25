using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObServer
{
    class follower : Iobserver
    {
        public string Name { get; set; }
        public follower(string name)
        {
            this.Name = name;
        }
        public void update(string celebrity, string tweet)
        {
            Console.WriteLine($"{Name} received {tweet} from {celebrity}");
        }
    }
}
