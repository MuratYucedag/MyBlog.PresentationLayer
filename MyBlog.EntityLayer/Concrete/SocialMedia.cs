﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.EntityLayer.Concrete
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string IconUrl { get; set; }
        public string LinkUrl { get; set; }
    }
}
