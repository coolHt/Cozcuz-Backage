using System.ComponentModel.DataAnnotations;
namespace ht_project.Models
{
    public class bk_admin //这里的名字其实就是表名
    {
      [Key]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}