using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AGENDAHUB.Models
{
    [Table("Servicos")]
    public class Servicos
    {
        [Key]
        public int ID_Servico { get; set; }

        [Required(ErrorMessage = "Obrigat�rio informar o nome!")]
        public string Nome { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O pre�o deve ser maior ou igual a 0.")]
        public decimal Preco { get; set; }

        [Display(Name = "Tempo de Execu��o")]
        [DataType(DataType.Time)]
        public TimeSpan TempoDeExecucao { get; set; }

        public byte[] Imagem { get; set; }

        public int ProfissionaisID { get; set; }

        [ForeignKey("ProfissionaisID")]
        public Profissionais Profissional { get; set; }
    }
}
