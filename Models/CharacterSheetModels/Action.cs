using System;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DMApp.Models
{

    public abstract class Action
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int? ActionTypeId { get; set; }
        public ActionType Type { get; set; }

        public bool IsBonusAction { get; set; }
        public bool IsReaction { get; set; }
        // Other common fields and methods
    }

}
