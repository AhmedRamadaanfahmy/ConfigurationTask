namespace taskApis.Models
{
    public class MapType
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public List<MapSubType> MapSubTypes { get; set; }
    }
}