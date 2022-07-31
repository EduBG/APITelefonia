namespace APITelefonia.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Fabricante")]
    public class Fabricante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_fab { get; set; }

        public string Fab_name { get; set; }

        public string Fab_desc { get; set; }
    }
}