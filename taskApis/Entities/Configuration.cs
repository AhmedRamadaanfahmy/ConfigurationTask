namespace taskApis.Models
{
    using System;
    public class Configuration
    {
        public int Id { get; set; }
        public Nullable<int> ClusterRadius { get; set; }
        public bool GeoFencing { get; set; }
        public Nullable<int> TimeBuffer { get; set; }
        public Nullable<int> LocationBuffer { get; set; }
        public Nullable<int> Duration { get; set; }

        public Nullable<int> MapTypeId { get; set; }
        public virtual MapType? MapType { get; set; }

        public Nullable<int> MapSubTypeId { get; set; }
        public virtual MapSubType? MapSubType { get; set; }
    }
}