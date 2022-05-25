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
            Decoretor();
            #endregion
            #region Decoretor Observer
            Observer();
            #endregion

            void Decoretor()
            {
                Console.WriteLine("--------Decoretor Pattern----------");
                Decoretor.FileDataSource source = new Decoretor.FileDataSource("Test.txt");
                var compration = new Decoretor.ComprationDecoredtor(source);
                var DataEncription = new Decoretor.EncriptionDecretor(compration);
                DataEncription.Write("Data1");
                Console.WriteLine("===============");
                Console.WriteLine(DataEncription.Read());
                Console.ReadKey();
                Console.ReadKey();
            }
            void Observer()
            {
                Console.WriteLine("------------ObserverPattern--------");
                ObServer.Celebritys Kylie = new ObServer.Celebritys("Kylie Jenner");
                ObServer.Celebritys Kanye = new ObServer.Celebritys("Kanye Wes");

                ObServer.follower followerAli = new ObServer.follower("Ali");
                ObServer.follower followerHamid = new ObServer.follower("Hamid");
                ObServer.follower followerMojtabad = new ObServer.follower("Mojtabad");
                ObServer.follower followerDavood = new ObServer.follower("Davood");

                Kylie.Register(followerDavood);
                Kanye.Register(followerAli);

                Kylie.tweet("Welcome here");
                Kanye.tweet("Hello followers");

                Kanye.Register(followerHamid);
                Kylie.Register(followerMojtabad);

                Kylie.tweet("Today is a good day");
                Kanye.tweet("A new song is on the way");

                Console.ReadKey();

            }
        }
        
    }
}
