
using System.ComponentModel.DataAnnotations;
using CMS.Core.enums;

namespace CMS.Data.Models
{
    public class Track : BaseEntity
    {
        [Required]
        public string Title { get; set; } 

        public int TimeInMinute { get; set; }

        public string TrackUrl { get; set; }

        [Required]
        public string OwnerName { get; set; } 

        public int CategoryId { get; set; }

        public Category Category { get; set; } 

        public string PublishedBy { get; set; } 

        public Users PublishedUser { get; set; } 

        public ContentStatus Status { get; set; }
    }
}
