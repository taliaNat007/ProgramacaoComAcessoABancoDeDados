using System.Globalization;
using System.Security.Cryptography;

namespace API_Gestao_Facil.Models
{
    public class Servidor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Siape { get; set; }

    }
}
