using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlFeatureRepo : IFeatureRepo
    {
        private readonly DMAppContext _context;

        public SqlFeatureRepo(DMAppContext context)
        {
            _context = context;
        }

        public Feature CreateFeature(Feature feature)
        {
            if (feature == null)
            {
                throw new ArgumentNullException(nameof(feature));
            }

            _context.Features.Add(feature);
            _context.SaveChanges();

            return feature;
        }

        public void DeleteFeature(int featureId)
        {
            Feature feature = _context.Features.FirstOrDefault(c => c.Id == featureId);

            if (feature == null)
            {
                throw new ArgumentNullException(nameof(feature));
            }

            _context.Features.Remove(feature);
        }

        public Feature GetFeatureById(long featureId)
        {
            return _context.Features.FirstOrDefault(c => c.Id == featureId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}