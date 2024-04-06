using CoreArchitecture.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CoreArchitecture.ViewComponents
{
    public class TemplateRequestViewComponent : ViewComponent
    {
        private readonly TemplateDomain _Domain;

        public TemplateRequestViewComponent(TemplateDomain Domain)
        {
            _Domain = Domain;
        }
        public async Task<IViewComponentResult> InvokeAsync(Guid id)
        {
            return View(await _Domain.GetAllTemplate());
        }
    }
}
