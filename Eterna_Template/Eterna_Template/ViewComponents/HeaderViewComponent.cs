using Eterna_Template.DAL;
using Eterna_Template.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Eterna_Template.ViewComponents
{
    public class HeaderViewComponent
    {
        private readonly AppDbContext context;

        public HeaderViewComponent(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Setting setting = await context.Settings.FirstOrDefaultAsync();
            
        }
    }
}
