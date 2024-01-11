using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DMApp.Models
{
    public class Organization
    {
        public Organization()
        {
            Name = string.Empty;
            Description = string.Empty;
            Characters = new List<Character>();
            
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public IList<Character> Characters { get; set; }
        

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}


