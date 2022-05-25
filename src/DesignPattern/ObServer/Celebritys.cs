using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObServer
{
    class Celebritys : Isubject
    {
        public string Name { get; set; }
        private List<ObServer.Iobserver> ObserverList;

        public Celebritys(string name)
        {
            Name = name;
            ObserverList = new List<Iobserver>();
        }
        public void tweet(string tweet)
        {
            Console.WriteLine($"{ Name} said {tweet}");
            Console.WriteLine("---------------------");
            Notify(tweet);
        }

        public void Register(Iobserver iobserver)
        {
            ObserverList.Add(iobserver);
        }

        public void UnRegister(Iobserver iobserver)
        {
            ObserverList.Remove(iobserver);
        }

        public void Notify(string tweet)
        {
            foreach (var iobserver in ObserverList)
            {
                iobserver.update(Name, tweet);
            }
        }
    }
}
