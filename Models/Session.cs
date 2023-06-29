using System;
namespace DMApp.Models
{
	public class Session
	{
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? SessionNumber { get; set; }

        public Campaign campaign { get; set; }
    }
}

