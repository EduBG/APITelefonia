namespace APITelefonia.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Estado")]
    public class Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_estado { get; set; }

        public string Estado_name { get; set; }

        public string Estado_desc { get; set; }
    }
}