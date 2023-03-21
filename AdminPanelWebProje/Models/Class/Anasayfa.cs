using System.ComponentModel.DataAnnotations;

namespace AdminPanelWebProje.Models.Class
{
    public class Anasayfa
    {
        [Key]
        public int id { get; set; }
        public string profile { get; set; }
        public string Name { get; set; }
        public string job { get; set; }
        public string text { get; set; }
        public string socialtext { get; set; }
        public string deneme { get; set; }

    }
}