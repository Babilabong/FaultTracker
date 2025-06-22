using System;

namespace FaultTracker.Models
{
    public class Fault
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReportedAt { get; set; }
        public string Status { get; set; }
    }
}