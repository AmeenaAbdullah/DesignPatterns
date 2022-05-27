using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IUser
    {
        string Name { get; }
        string Address { get; }
        int Age { get; }
    }

    public class User 
    {
        private string name;
        private int age;
        private string address;

        private User() { }

        public string Name => name;

        public string Address => address;

        public int Age => age;

        public class UserBuilder
        {
            private readonly User user;

            public UserBuilder()
            {
                user = new User();
            }

            public UserBuilder WithName(string name)
            {
                user.name = name;
                return this;
            }

            public UserBuilder WithAge(int age)
            {
                user.age = age;
                return this;
            }

            public UserBuilder WithAddress(string address)
            {
                user.address = address;
                return this;
            }

            public User Build() => user;
        }
    }
}
