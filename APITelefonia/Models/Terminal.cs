namespace APITelefonia.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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
    }
}