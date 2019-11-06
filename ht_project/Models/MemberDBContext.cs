using Microsoft.EntityFrameworkCore;
namespace ht_project.Models
{
    public class MemberDBContext: DbContext
    {
        //DbSet<bk_admin> 映射到数据库表的实体,即 指定到了bk_admin这个表， Dbset是对实例类的操作
        public virtual DbSet<bk_admin> bk_admin {get; set;} 
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseMySQL(@"server=localhost;uid=root;pwd=root;
        //             port=3306;database=bike;");
        //     }
        // }
        public MemberDBContext(DbContextOptions<MemberDBContext> options) : base(options){} //这是干啥的
    }
}