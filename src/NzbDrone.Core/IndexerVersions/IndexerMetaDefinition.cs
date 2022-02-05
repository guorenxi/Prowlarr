using System.Collections.Generic;

namespace NzbDrone.Core.IndexerVersions
{
    public class IndexerMetaDefinition
    {
        public string Id { get; set; }
        public string File { get; set; }
        public string Implementation { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Encoding { get; set; }
        public List<string> Links { get; set; }
        public List<string> Legacylinks { get; set; }
        public string Sha { get; set; }
    }
}
