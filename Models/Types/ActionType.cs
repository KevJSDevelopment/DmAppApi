using System;
namespace DMApp.Models
{
    public class ActionType
    {
        public int? TypeId { get; set; }

        public string? TypeName { get; set; }

        /* Default Types
        Attack,
        CastSpell,
        Dash,
        Disengage,
        Dodge,
        Grapple,
        Help,
        Hide,
        Improvise,
        Ready,
        Search,
        Shove,
        UseObject
        */
        // Add more action types as needed
    }
}

