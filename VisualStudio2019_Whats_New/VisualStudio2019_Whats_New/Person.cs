using System;
using System.Collections.Generic;
using System.Text;

namespace VisualStudio2019_Whats_New
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get;  set; }

        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format($"Sent on {DateTime.Now} ");
            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine($"Dear {FirstName}  {LastName}");
            sb.AppendLine($"Message: {Email} {message}");
            return sb.ToString();
        }

    }
}

