using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IFeatureRepo
    {
        bool SaveChanges();
        IList<Feature> GetFeaturesByGuildId(long guildId);
        Feature CreateFeature(Feature feature);
        void DeleteFeature(int featureId);
    }
}