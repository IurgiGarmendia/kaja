namespace kaja.App_Code.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class Model2 : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Model2' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'kaja.App_Code.Model.Model2' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Model2'  en el archivo de configuración de la aplicación.
        public Model2()
            : base("name=Model2")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Client_Master> DbCllientMaster { get; set; }
    }

    public class Client_Master
    {
        [Key]
        public int Id { get; set; }
        public string Cl_Name { get; set; }
    }
}