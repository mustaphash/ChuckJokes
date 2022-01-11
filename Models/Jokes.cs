namespace Models
{
    public class Jokes
    {
        public Jokes()
        {
            Categories = new List<object>();
            Created_at = string.Empty;
            Icon_url = string.Empty;
            Id = string.Empty;
            Updated_at = string.Empty;
            Url = string.Empty;
            Value = string.Empty;
        }
        public List<object> Categories { get; set; }
        public string Created_at { get; set; }
        public string Icon_url { get; set; }
        public string Id { get; set; }
        public string Updated_at { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}
