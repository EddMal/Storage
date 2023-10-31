using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Pkcs;

namespace Storage.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        public int InventoryValue { get; set; }

        //Add, and use in viewmodel when Searching
        //[RegularExpression("Möbler|Prydnadsföremål", ErrorMessage = " Väj en av följande två kategorier:  Möbler, Prydnadsföremål. Första boksataven ska vara en versal.")]
        //public string Category { get; set; }
    }
}
