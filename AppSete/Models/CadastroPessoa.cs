using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSete.Models
{
    public class CadastroPessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
       //Verificar para Validar o CPF{ //var CPF = public string Cpf { get; set; } //new CPFValidator().AssertValid(); //}
        public bool RegAtivo { get; set; }
        public DateTime DataRegistro { get; set; }
        //Verificar para formatar a Data (DateTime data = new DateTime(Now { get; });
    }
}
