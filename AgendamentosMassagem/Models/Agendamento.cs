using System.ComponentModel.DataAnnotations;

namespace AgendamentosMassagem.Models
{
    public class Agendamento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o cliente.")]
        [Display(Name = "Cliente")]
        public string Cliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o procedimento.")]
        [Display(Name = "Procedimento")]
        public string TipoMassagem { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a data.")]
        [Display(Name = "Data do agendamento")]
        [DataType(DataType.Date)]
        public DateTime DataAgendamento { get; set; }

        [Required(ErrorMessage = "Informe o horário.")]
        [Display(Name = "Horário do agendamento")]
        [DataType(DataType.Time)]
        public TimeSpan HorarioAgendamento { get; set; }

        [Required(ErrorMessage = "Informe o preço.")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Informe o endereço.")]
        [Display(Name = "Endereço")]
        [StringLength(250)]
        public string Endereco { get; set; } = string.Empty;
    }
}
