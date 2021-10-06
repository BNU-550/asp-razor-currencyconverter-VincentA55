using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    public class ConverterModel : PageModel
    {
        public String FromValue;
        public String ToValue;

        public String FromUnit;
        public String ToUnit;

        public String FromDistance;
        public String ToDistance;

        public void OnGet()
        {
        }
    }
}
