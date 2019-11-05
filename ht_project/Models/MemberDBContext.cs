using Microsoft.EntityFrameworkCore;
namespace ht_project.Models
{
    public class MemberDBContext: DbContext
    {
        public virtual DbSet<bk_admin> bk_admin {get; set;} //这里的模型其实就是表
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseMySQL(@"server=localhost;uid=root;pwd=root;
        //             port=3306;database=bike;");
        //     }
        // }
        public MemberDBContext(DbContextOptions<MemberDBContext> options) : base(options){}
    }
}