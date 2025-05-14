using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonParsing
{
    internal class User
    {
        public string Name { get; }
        public int Age { get; }
        public string Email { get; }

        [JsonConstructor]
        public User(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public string WriteInfo()
        {
            return $"Jméno: {Name}, Věk: {Age}, Email: {Email}";
        }
    }
}
