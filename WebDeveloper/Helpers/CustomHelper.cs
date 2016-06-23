using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper //no se puede crear instancias ni construir un objeto desde razor
    {
        public static IHtmlString DisplayPriceStatic(double price) { //Metodo estatico
            var result = string.Empty;
            if (price == 0.0)
                result = "<span>Free!!!</span>";
            else
                result = $"<span>{price} </span>";
            return new HtmlString(result);

        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price) { //Extension
            var result = string.Empty;
            if (price == 0.0)
                result = "<span>Free!!!</span>";
            else
                result = $"<span>{price} </span>";
            return new HtmlString(result);
        }

        public static IHtmlString DisplayDateOrNull(this HtmlHelper helper, DateTime? date) {
            //var result = string.Empty;
            //result = date == null ? "<span>None</span>" : $"<span>{date.Value.ToString("dd/MM/yyyy")}</span>";           
            //return new HtmlString(result);
            return new HtmlString(date == null ? DisplayStringHtml("None") : DisplayStringHtml(date.Value.ToString("dd/MM/yyyy")));
        }

        private static string DisplayStringHtml(string variable) {
            return $"<span>{variable}</span>";
        }
    }
}
