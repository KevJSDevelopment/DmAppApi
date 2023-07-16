using System;
namespace DMApp.Models
{
	public class GuildOrganization
	{
        public long? GuildId { get; set; }
        public DiscordGuild? Guild { get; set; }

        public int? OrganizationId { get; set; }
        public Organization? Org { get; set; }
    }
}

