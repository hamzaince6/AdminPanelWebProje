using System.ComponentModel.DataAnnotations;

namespace AdminPanelWebProje.Models.Class
{
    public class socialicon
    {
        [Key]
        public int id { get; set; }
        public string icon { get; set; }
        public string link { get; set; }
    }
}