using RestWithAspNet.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;

namespace RestWithAspNet.Model
{
    [Table("movie")]
    public class Movie:BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("director")]
        public string Director { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("duration_time")]
        public int DurationTime { get; set; }

        [Column("launchdate")]
        public DateTime? LaunchDate { get; set; }
    }
}
