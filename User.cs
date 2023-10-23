using System;
using System.Collections.Generic;

using AccountN;
using IConnectionN;

namespace UserN 
{
    public class User : IConnection
    {
        private String username;
        private String password;
        private String name;

        public User (String username, String password, String name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
        }

        // IConnection
        public void Connection()
        {
            Console.WriteLine(this.name + "(" + this.username + ") has connected.\n");
        }

        public void Disconnection()
        {
            Console.WriteLine(this.name + "(" + this.username + ") has disconnected.\n");
        }   

        public String GetUsername()
        {
            return this.username;
        }

        public String GetName()
        {
            return this.name;
        }
    } 
}
