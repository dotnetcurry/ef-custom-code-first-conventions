using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6WhatsNew.Models
{
    public class Post
    {
        public int PkPostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}