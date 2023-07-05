using System;
namespace DMApp.Models
{
	public class CharacterOrganization
	{
		public int? CharacterId { get; set; }
		public Character? Character { get; set; }

		public int? OrganizationId { get; set; }
		public Organization Org { get; set; }
	}
}

