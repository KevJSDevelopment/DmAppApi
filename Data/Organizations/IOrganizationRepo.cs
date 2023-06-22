using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IOrganizationRepo
    {
        bool SaveChanges();
        Organization CreateOrganization(Organization organization);
        void DeleteOrganization(int organizationId);
    }
}