namespace OnlineStore.Models.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 13)]
        public string Card { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }

        public DateTimeOffset Time { get; set; } = DateTimeOffset.UtcNow;
    }
}