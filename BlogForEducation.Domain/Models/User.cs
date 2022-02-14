using System.Collections.Generic;

namespace BlogForEducation.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string  Address { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Profession { get; set; }

        public IList<Blog> Blogs { get; set; }
    }
}
