namespace Book_ColectionsWebApi.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
    
    }
}
