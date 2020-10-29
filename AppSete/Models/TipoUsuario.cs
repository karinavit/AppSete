﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppSete.Models
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Tipo Usuário")]
        [Column("NomeTipoUsuario")]
        public int NomeTipoUsuario { get; set; }
    }
}
