using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Celebrity
    {
        private string Name;
        private List<Fan> FanFollowing;
        private string _tweet;
        public string Tweet
        {
            get
            {
                return _tweet;
            }
            set
            {
                _tweet = value;
                NotifyFans();
            }

        }

        private void NotifyFans()
        {
            
            foreach (var fan in FanFollowing)
            {
                Console.WriteLine("Hey "+fan.Name+", Celebrity "+this.Name+" tweeted "+this.Tweet);
            }
        }

        public Celebrity(String name)
        {
            this.Name = name;
            FanFollowing = new List<Fan>();
        }
        public void AcceptRequest(Fan fan)
        {
            FanFollowing.Add(fan);
        }
    }
}
