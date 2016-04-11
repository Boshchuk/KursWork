using System.ComponentModel.DataAnnotations;

namespace ToyFactory.Dal
{
    public class Toy
    {
        [Key]
        public int ToyId { get; set; }

        public string Article { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        // todo: add relations with materials
    }
}