using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan ash = new Fan("Ash");
            Fan jay = new Fan("Jay");
            Celebrity selenaGomez = new Celebrity("Selena Gomez");
            ash.FollowCelebrity(selenaGomez);
            jay.FollowCelebrity(selenaGomez);
            selenaGomez.Tweet = "Hey meet me in LA";
            Console.ReadLine();
        }
    }
}
