using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlOrganizationRepo : IOrganizationRepo
    {
        private readonly DMAppContext _context;

        public SqlOrganizationRepo(DMAppContext context)
        {
            _context = context;
        }

        public Organization CreateOrganization(Organization organization)
        {
            if (organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }

            _context.Organizations.Add(organization);
            _context.SaveChanges();

            return organization;
        }

        public void DeleteOrganization(int organizationId)
        {
            Organization Organization = _context.Organizations.FirstOrDefault(c => c.OrganizationId == organizationId);

            if (Organization == null)
            {
                throw new ArgumentNullException(nameof(Organization));
            }

            _context.Organizations.Remove(Organization);
        }

        public Organization GetOrganizationById(int organizationId)
        {
            return _context.Organizations.FirstOrDefault(c => c.OrganizationId == organizationId);
        }


        public IList<Organization> GetOrganizationsByGuildId(long guildId)
        {
            return _context.Organizations.Where(c => c.Guilds.Any(g => g.GuildId == guildId)).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}