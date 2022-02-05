using System.Collections.Generic;
using NzbDrone.Core.IndexerVersions;

namespace NzbDrone.Core.Indexers.Cardigann
{
    public class CardigannMetaDefinition : IndexerMetaDefinition
    {
        public List<SettingsField> Settings { get; set; }
        public LoginBlock Login { get; set; }
    }
}
