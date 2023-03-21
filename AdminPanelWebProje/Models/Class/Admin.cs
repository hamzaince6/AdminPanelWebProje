using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace AdminPanelWebProje.Models.Class
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
    }
}