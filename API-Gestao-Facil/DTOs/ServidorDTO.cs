using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace API_Gestao_Facil.DTOs
{
    public class ServidorDTO
    {
        [Required]
        [MinLength(5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres")]
        public string Nome { get; set; }
        
        [Required]
        [Length(14, 14, ErrorMessage = "O CPF deve ter no mínimo 14 caracteres")]
        public string Cpf { get; set; }

        [Required]
        public int Siape { get; set; }

    }
}
