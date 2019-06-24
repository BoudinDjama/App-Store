using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appstore.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Downloads { get; set; }

        public string ImagePath { get; set; }

        public DateTime PublishDate { get; set; }

        public Category Category { get; set; }
        public Dev Dev { get; set; }
        public HashSet<Review> Reviews { get; set; } = new HashSet<Review>();

    }
}