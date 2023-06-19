using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IOrganizationRepo
    {
        bool SaveChanges();
        IList<Organization> GetOrganizationsByGuildId(long guildId);
        Organization CreateOrganization(int organizationId);
        void DeleteOrganization(int organizationId);
    }
}