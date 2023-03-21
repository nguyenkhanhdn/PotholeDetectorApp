using System.ComponentModel.DataAnnotations;

namespace PotholeDetectorApp.Models
{
    public class Pothole
    {
        public int Id { get; set; }
        [Display(Name ="Lat")]
        public string Latitude { get; set; }
        [Display(Name = "Long")]
        public string Longitude { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "Image")]
        public byte[] Img { get; set; }
        [Display(Name = "Note")]
        public string Note { get; set; }
    }
}