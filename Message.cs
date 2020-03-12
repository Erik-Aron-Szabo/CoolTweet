using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolTweet
{
    [Serializable]
    public class Message
    {
        public string Username { get; set; } // Name
        public string Text { get; set; } // Content

        //public DateTime Timestamp { get; set; }

        public Message(string user, string text)
        {
            Username = user;
            Text = text;
            //Timestamp = DateTime.Now;
        }

        public Message()
        {

        }

        public override string ToString()
        {
            return $"{Username}: {Text}";
        }

        //public override string ToString()
        //{
        //    return $"{Timestamp}: {Text}@{Username}";
        //}


    }
}