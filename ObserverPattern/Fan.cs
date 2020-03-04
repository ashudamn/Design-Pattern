using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Fan
    {
        public string Name { get; set; }
        public Fan(String name)
        {
            this.Name = name;
        }
        public void FollowCelebrity(Celebrity celebrity)
        {
            celebrity.AcceptRequest(this);
        }
    }
}
