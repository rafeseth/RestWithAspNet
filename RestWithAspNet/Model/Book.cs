using RestWithAspNet.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;

namespace RestWithAspNet.Model
{
    [Table("book")]
    public class Book:BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("author")]
        public string Author { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launchdate")]
        public DateTime? LaunchDate { get; set; }
    }
}
