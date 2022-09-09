namespace NewsWebsite.Models
{
    public class News
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string Topic { get; set; }   
    }
}
