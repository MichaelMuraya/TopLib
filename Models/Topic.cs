using System;
using System.Collections.Generic;

namespace TopLib.Models
{
    public partial class Topic
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double? EstimatedTimeToMaster { get; set; }
        public double? TimeSpent { get; set; }
        public string SourceOf { get; set; }
        public DateTime? StartLearningDate { get; set; }
        public string InProgress { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}
