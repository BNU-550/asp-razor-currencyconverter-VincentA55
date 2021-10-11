using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace RazorCurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        [BindProperty]
        public double Amount { get; set; }

        public String Currency { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Currency = Request.Form["Currency"];

            if (Currency == "Euros")
            {
                Amount = Amount * 0.8;
                ViewData["Result"] = "£" + Amount.ToString("0.00");
            }
            else if (Currency == "Pounds")
            {
                Amount = Amount * 1.18;
                ViewData["Result"] = "€" + Amount.ToString("0.00");
            }
        }
    }
}