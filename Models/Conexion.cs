using Microsoft.EntityFrameworkCore;
namespace web_api_db.Models{
    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base (options){}
        public DbSet<Clientes> Clientes {get;set;}
        public DbSet<Puestos> Puestos {get;set;}
        public DbSet<Empleados> Empleados {get;set;}

        public DbSet<Mapa> Mapa { get; set; }


    }
    class Conectar{
        private const string cadenaConexion = "Server=tcp:pruebasmanfred.database.windows.net,1433;Initial Catalog=mapas;Persist Security Info=False;User ID=Manfred;Password=admin.515919;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseSqlServer(cadenaConexion);
            var cn = new Conexion (constructor.Options);
            return cn;
        }

    }
}