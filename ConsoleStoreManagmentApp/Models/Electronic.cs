namespace Models.Entities
{
    public class Electronic : Product
    {
        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        [Range(0, 60)] 
        public int WarrantyPeriod { get; set; } 

        [MaxLength(30)]
        public string Color { get; set; }

    }
}
