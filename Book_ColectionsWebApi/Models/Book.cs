namespace Book_ColectionsWebApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string tittle { get; set; }
        public string author { get; set; }
        public int publication_year { get; set; }
        public string img_portada { get; set; }
        public int UserId { get; set; }

    }
}
