
using System;
using System.ComponentModel.DataAnnotations;
using CMS.Core.enums;

namespace CMS.Data.Models
{
    public class ContentChangeLog
    {
        public int Id { get; set; }

        [Required]
        public int ContentId { get; set; }

        public ContentType Type { get; set; }

        public DateTime ChangeAt { get; set; }

        public ContentStatus Old { get; set; }

        public ContentStatus New { get; set; }
    }
}
