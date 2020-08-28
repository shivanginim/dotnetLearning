using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcorewithoutMVC.Core;
using dotnetcorewithoutMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace dotnetcorewithoutMVC.Pages.Accommodations
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IAccommodationData accommodationData;

        public string Message { get; set; }
        public IEnumerable<Accommodation> Accommodations { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config,
                            IAccommodationData accommodationData)
        {
            this.config = config;
            this.accommodationData = accommodationData;
        }
        public void OnGet()
        {
            Accommodations = accommodationData.GetAccommodationByName(SearchTerm);
        }
    }
}