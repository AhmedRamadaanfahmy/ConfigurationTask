namespace taskApis.DTOs
{
    public class ConfigurationDTO
    {
        public Nullable<int> ClusterRadius { get; set; }
        public bool GeoFencing { get; set; }
        public Nullable<int> TimeBuffer { get; set; }
        public Nullable<int> LocationBuffer { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> MapTypeId { get; set; }
        public Nullable<int> MapSubTypeId { get; set; }
    }
}