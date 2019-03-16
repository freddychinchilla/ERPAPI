using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.Contexts;
using ERPAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ERPAPI.Controllers
{
    [Route("api/Estados")]
    [ApiController]
    public class EstadosController : Controller
    {

        private readonly ApplicationDbContext _context;

        public EstadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estados
               
        [HttpGet]
        public async Task<ActionResult> GetEstados()
        {
            List<Estados> Items = await _context.Estados.ToListAsync();
           
            return Ok(Items);
        }
                     

        // GET: Estados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

     
    }
}