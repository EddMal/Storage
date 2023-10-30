using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [Range(100, 15000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [RegularExpression("Möbler|Prydnadsföremål", ErrorMessage = " Väj en av följande två kategorier:  Möbler, Prydnadsföremål. Första boksataven ska vara en versal.")]
        public string Category { get; set; }

        [RegularExpression("A-1|A-2|B-1|B-2|C-1|C-2", ErrorMessage = "Välj mellan följande hyllor: A-1, A-2, B-1, B-2, C-1, C-2. Boksataven ska vara en versal.")]
        public string Shelf { get; set; }
        [Range(0, 6)]
        public int Count { get; set; }

        public string Description { get; set; }

    }

}
