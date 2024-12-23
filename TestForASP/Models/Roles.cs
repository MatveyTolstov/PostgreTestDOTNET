using System.ComponentModel.DataAnnotations;

namespace TestForASP.Models
{
    public class roles
    {
        [Key]
        public int id_roles { get; set; }

        public string role {  get; set; }
    }
}
