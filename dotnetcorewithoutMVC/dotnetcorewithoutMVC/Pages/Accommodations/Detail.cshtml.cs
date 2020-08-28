using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcorewithoutMVC.Core;
using dotnetcorewithoutMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetcorewithoutMVC.Pages.Accommodations
{
    public class DetailModel : PageModel
    {
        private readonly IAccommodationData accommodationData;
        public Accommodation Accommodation { get; set; }

        public DetailModel(IAccommodationData accommodationData)
        {
            this.accommodationData = accommodationData;
        }
        public IActionResult OnGet(int accommodationId)
        {
            Accommodation = accommodationData.GetById(accommodationId);
            if(Accommodation == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}