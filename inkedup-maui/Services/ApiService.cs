using inkedup_maui.Models;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inkedup_maui.Services
{
    public class ApiService
    {
        public async Task<List<Pen>> GetPens(string categoryName)
        {
            List<Pen> pens = new List<Pen>()
            {
                new Pen(){ BrandName = "Montblanc", Model = "149", Image = "https://d15bv9e9f3al6i.cloudfront.net/imgs/products/cp/950_constW/MB75945-M~Montblanc-Meisterstuck-149-Fountain-Pen-Gold-Trim-Medium_P1.jpg", Uri = "https://www.cultpens.com/i/q/MB75945/montblanc-meisterstuck-149-fountain-pen-gold-trim"},
            };

            return pens;

            /*
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=71fcafbb8e80aa02b576b9e88acbfceb&lang=en&topic=" + categoryName.ToLower());
            return JsonConvert.DeserializeObject<Root>(response);
            */
        }
    }
}
