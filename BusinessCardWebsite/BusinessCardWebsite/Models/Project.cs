using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessCardWebsite.Models
{
    public class Project
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        [UIHint("MultilineText")]
        public string Description { get; set; }

        public string Url { get; set; }

        public byte[] Image { get; set; }
    }
}