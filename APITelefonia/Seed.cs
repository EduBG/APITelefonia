namespace APITelefonia
{
    using System.Linq;
    using APITelefonia.Models;

    public static class InitialData
    {
        public static void Seed(this TelefoniaContext dbContext)
        {
            if (!dbContext.Fabricantes.Any())
            {
                //Fabricantes
                dbContext.Fabricantes.Add(new Fabricante
                {
                    Fab_name = "Samsung",
                    Fab_desc = "Compañía asiática de origen coreano."
                });
                dbContext.Fabricantes.Add(new Fabricante
                {
                    Fab_name = "Sony",
                    Fab_desc = "Compañía asiática de origen japones fundada en 1946."
                });
                dbContext.Fabricantes.Add(new Fabricante
                {
                    Fab_name = "Apple",
                    Fab_desc = "Compañía de origen americano fundada en 1976."
                });
                dbContext.SaveChanges();

                //Estados
                dbContext.Estados.Add(new Estado
                {
                    Estado_name = "Preventa",
                    Estado_desc = "Disponible para reservar."
                });
                dbContext.Estados.Add(new Estado
                {
                    Estado_name = "Venta",
                    Estado_desc = "Disponible para vender."
                });
                dbContext.Estados.Add(new Estado
                {
                    Estado_name = "Agotado",
                    Estado_desc = "No disponible temporalmente."
                });
                dbContext.Estados.Add(new Estado
                {
                    Estado_name = "Descatalogado",
                    Estado_desc = "No disponible de forma definitiva."
                });
                dbContext.SaveChanges();

                //Terminales
                dbContext.Terminales.Add(new Terminal
                {
                    Id_fab = 1,
                    Id_estado = 2,
                    Fecha_fabricacion = new System.DateTime(2020,06,15),
                    Fecha_estado = new System.DateTime(2020, 06, 15),
                    Terminal_desc = "Terminal gama alta con la última tecnología movil.",
                    Terminal_name = "Samsung Galaxy Note 20"
                });
                dbContext.Terminales.Add(new Terminal
                {
                    Id_fab = 2,
                    Id_estado = 4,
                    Fecha_fabricacion = new System.DateTime(2010, 01, 10),
                    Fecha_estado = new System.DateTime(2012, 05, 15),
                    Terminal_desc = "Terminal de Sony gama media con buenos acabados.",
                    Terminal_name = "Sony ericsson xperia 10"
                });
                dbContext.Terminales.Add(new Terminal
                {
                    Id_fab = 3,
                    Id_estado = 1,
                    Fecha_fabricacion = new System.DateTime(2022, 10, 01),
                    Fecha_estado = System.DateTime.Now,
                    Terminal_desc = "Sin descriipción.",
                    Terminal_name = "Iphone 14"
                });
                dbContext.SaveChanges();
            }
        }
    }
}