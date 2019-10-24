using System;
using System.Collections.Generic;
using System.Text;

namespace VisualStudio2019_Whats_New
{
    public abstract class Person
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract string Email { get;  set; }

        public abstract string SendMessage(string message);



    }
}

