namespace Models.Entities
{
    public class Book : Product
    {
        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [MaxLength(100)]
        public string Publisher { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Page count must be at least 1.")]
        public int PageCount { get; set; }

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [Range(1000, 2100)]
        public int PublishedYear { get; set; }

        [MaxLength(50)]
        public string Language { get; set; }
    }
}
