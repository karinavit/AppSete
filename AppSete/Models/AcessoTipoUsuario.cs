using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSete.Models
{
    [Table("AcessoTipoUsuario")]
    public class AcessoTipoUsuario
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name="Descrição")]
        [Column("NomeFuncao")]
        public int NomeFuncao { get; set; }


        [Display(Name = "TipoUsuario")]
        [ForeignKey("TipoUsuario")]
        [Column(Order = 1)]
        public int IdTipoUsuario { get; set; }


        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
