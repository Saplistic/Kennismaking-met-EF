using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Model
{
    public class ProductCategorie
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 30)]
        public string Naam { get; set; }

        public ICollection<Product> Producten { get; } = new List<Product>();

        //Constructor
        public ProductCategorie() { }
        public ProductCategorie(int id, string naam)
        {
            Id = id;
            Naam = naam;
        }
    }
}
