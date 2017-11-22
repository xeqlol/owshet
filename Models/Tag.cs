using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Owshet.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "TagName is required")]
        public string Name { get; set; }

        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
