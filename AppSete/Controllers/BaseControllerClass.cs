using AppSete.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace AppSete.Controllers
{
    public class BaseControllerClass : Controller
    {
        public async Task<bool> Usuario_Tem_Acesso(int codigoPagina, ApplicationDbContext _context)
        {
            var usuario = User.Identity.Name;

            var temAcesso = await (from TP in _context.TipoUsuario
                                   join AT in _context.AcessoTipoUsuario on TP.Id equals AT.IdTipoUsuario
                                   join PF in _context.PerfilUsuario on TP.Id equals PF.IdTipoUsuario
                                   join US in _context.Usuario on PF.UserId equals US.Id
                                   where AT.Id == codigoPagina && US.Email == usuario
                                   select new
                                   {
                                       TP.Id
                                   }).AnyAsync();


            return temAcesso;


        }
    }
}
