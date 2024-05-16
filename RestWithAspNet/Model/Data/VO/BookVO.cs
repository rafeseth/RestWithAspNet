using RestWithAspNet.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;

namespace RestWithAspNet.Data.VO
{
       public class BookVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime? LaunchDate { get; set; }
    }
}
