using System.Runtime.Serialization;

namespace FFTicker
{
    [DataContract]
    public class Settings
    {
        [DataMember]
        public string SnapshotsDir { get; set; }
        [DataMember]
        public int SnapshotsInterval { get; set; }
        [DataMember]
        public bool SnapshotsEnabled { get; set; }
    }
}