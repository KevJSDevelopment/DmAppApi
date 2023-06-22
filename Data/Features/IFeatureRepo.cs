using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IFeatureRepo
    {
        bool SaveChanges();
        Feature CreateFeature(Feature feature);
        void DeleteFeature(int featureId);
    }
}