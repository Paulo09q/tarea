using Microsoft.EntityFrameworkCore;
using Bodegas.Models;


namespace Bodegas.Config
{
    public class ejemplodbContext:DbContext
    {
       
        
        
        public ejemplodbContext(DbContextOptions contexto):base(contexto) {}


       //Aqui crea las tablas
        public DbSet<ClienteModel> Clientes { get; set; }
    }
}
    
