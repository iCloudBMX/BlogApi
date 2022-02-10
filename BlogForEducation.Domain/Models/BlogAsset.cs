using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForEducation.Domain.Models
{
    public class BlogAsset : BaseEntity
    {
        public string FileName { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; }
    }
}
