using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Owshet.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "CategoryName is required")]
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Post> Posts { get; set; } = new List<Post>();

    }
}
