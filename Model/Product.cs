using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 30)]
        public string Naam { get; set; }

        [StringLength(maximumLength: 50)]
        public string Omschrijving { get; set; }

        //public int categorieId { get; set; }
        //[ForeignKey(nameof(categorieId))]
        [ForeignKey("ProductCategorieId")]
        public ProductCategorie ProductCategorie { get; set; }

        //CONSTRUCTOR
        public Product() { }
        public Product(int id, string naam, string omschrijving)
        {
            Id = id;
            Naam = naam;
            Omschrijving = omschrijving;
        }
    }
}
