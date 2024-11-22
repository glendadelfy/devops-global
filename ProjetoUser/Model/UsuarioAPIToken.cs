using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoUser.Model
{
    [Table("USUARIO_API")]
    public class UsuarioAPIToken
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Column("USERNAME")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Column("TOKEN")]
        [StringLength(50)]
        public string Token { get; set; }
    }
}
