namespace taskApis.Models
{
    public partial class MapSubType
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public MapType MapType { get; set; }
        public int MapTypeId { get; set; }
    }
}