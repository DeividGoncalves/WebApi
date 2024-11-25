using Microsoft.EntityFrameworkCore;
using WenAPI_video.Models;

namespace WenAPI_video.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
