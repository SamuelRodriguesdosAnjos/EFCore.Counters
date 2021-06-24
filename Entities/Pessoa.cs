using System.ComponentModel.DataAnnotations;

namespace EFCore.Counters
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}