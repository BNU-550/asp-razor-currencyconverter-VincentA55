using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        public int Amount { get; set; }

        public int Result;

        public String Currency { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
           // Amount = Request.Form["Amount"];

            Currency = Request.Form["Currency"];

            if(Currency == "Euros")
            {

            }


        }
    }
}
