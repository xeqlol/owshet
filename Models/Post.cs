using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Owshet.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Title required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Post text required")]
        public string MarkdownBody { get; set; }
        public string HtmlBody { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; } = DateTimeOffset.Now;
        [Required(ErrorMessage = "Slug is required")]
        public string Slug { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public string Excerpt { get; set; }
        public int ExcerptMaxLength { get; set; } = 140;

        [Required(ErrorMessage = "Category is required")]
        public Category Category { get; set; }
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
