using System.Collections.Generic;

namespace BlogForEducation.Domain.Models
{
    public class Blog : AuditableBaseEntity
    {
        public string Title { get; set; }

        public Subject Topic { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public User Owner { get; }

        public IList<BlogAsset> Assets { get; set; }
    }

    public enum Subject
    { 
        Technology = 1,
        Scientefic,
        Education
    }

}
