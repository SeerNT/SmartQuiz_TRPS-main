using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQuiz  
{
    internal class User : IEquatable<User>
    {
        public string login;
        public string password;

        public bool Equals(User other)
        {
            // Would still want to check for null etc. first.
            return this.login == other.login &&
                   this.password == other.password;
        }
    }
}
