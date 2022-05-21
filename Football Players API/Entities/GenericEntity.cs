using System;
using System.ComponentModel.DataAnnotations;

namespace Football_Players_API.Entities
{
    public class GenericEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTimeOffset DateOfAdd { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset? DateOfUpdate { get; set; }

        public DateTimeOffset? IsDeleted { get; set; }
    }
}