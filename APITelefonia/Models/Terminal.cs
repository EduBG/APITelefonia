namespace APITelefonia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using APITelefonia.Models;

    [Table("Terminal")]
    public class Terminal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_terminal { get; set; }

        public int Id_fab { get; set; }

        public int Id_estado { get; set; }

        public DateTime Fecha_fabricacion { get; set; }

        public DateTime Fecha_estado { get; set; }

        public string Terminal_desc { get; set; }

        public string Terminal_name { get; set; }


        public ResultDTO GetTerminal(int idTerminal) { 
        
            var result = new ResultDTO();

            using (var ctx = new TelefoniaContext())
            {
                result = (from t in ctx.Terminales
                          join e in ctx.Estados on t.Id_estado equals e.Id_estado
                          join f in ctx.Fabricantes on t.Id_fab equals f.Id_fab
                          where t.Id_terminal.Equals(idTerminal)
                          select new ResultDTO()
                          {
                              Nombre = t.Terminal_name,
                              Descripcion = t.Terminal_desc,
                              Fecha_estado = t.Fecha_estado,
                              Fecha_fabricacion = t.Fecha_fabricacion,
                              Nombre_estado = e.Estado_name,
                              Nombre_fabricante = f.Fab_name

                          }).Single();
            }

            return result;

        }

        public List<ResultDTO> GetTerminal()
        {

            var result = new List<ResultDTO>();

            using (var ctx = new TelefoniaContext())
            {
                result = (from t in ctx.Terminales
                          join e in ctx.Estados on t.Id_estado equals e.Id_estado
                          join f in ctx.Fabricantes on t.Id_fab equals f.Id_fab
                          select new ResultDTO()
                          {
                              Nombre = t.Terminal_name,
                              Descripcion = t.Terminal_desc,
                              Fecha_estado = t.Fecha_estado,
                              Fecha_fabricacion = t.Fecha_fabricacion,
                              Nombre_estado = e.Estado_name,
                              Nombre_fabricante = f.Fab_name

                          }).ToList();
            }

            return result;

        }
    }
}