using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.Core.Models
{
    public class CarTimelineItem
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public bool IsCompleted { get; set; }

        public int CarId { get; set; }
    }
}
