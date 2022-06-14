using Eterna_Template.DAL;
using Eterna_Template.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna_Template.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext context;

        public ServiceController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Card> cards = context.Cards.ToList();
            return View(cards);
        }
    }
}
