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
            List<Pen> pens = new List<Pen>();

			if (categoryName == "Visconti")
			{
                pens.Add(new Pen(){ BrandName = "Visconti", Model = "Homosapien - Dark Crystal", Image = "https://d15bv9e9f3al6i.cloudfront.net/imgs/products/cp/950_constW/VS88189-ZZZ~Visconti-Homo-Sapiens-Dark-Crystal-Fountain-Pen_P1.jpg", Uri = "https://www.cultpens.com/i/q/VS88189/visconti-homo-sapiens-dark-crystal-fountain-pen"});
			}
			else
			{
				pens.Add(new Pen(){ BrandName = "Montblanc", Model = "149", Image = "https://d15bv9e9f3al6i.cloudfront.net/imgs/products/cp/950_constW/MB75945-M~Montblanc-Meisterstuck-149-Fountain-Pen-Gold-Trim-Medium_P1.jpg", Uri = "https://www.cultpens.com/i/q/MB75945/montblanc-meisterstuck-149-fountain-pen-gold-trim"});
				pens.Add(new Pen(){ BrandName = "Montblanc", Model = "Starwalker - Urban Spirit", Image = "https://cdn.shopify.com/s/files/1/0570/8313/4123/products/115344_95ecd3f6-a271-472c-ad04-95db4ea4fe09_1024x600@2x.jpg?v=1629028140", Uri = "https://www.michaeljonesjeweller.co.uk/products/montblanc-starwalker-urban-spirit-fountain-pen"});
			}

            return pens;

            /*
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=71fcafbb8e80aa02b576b9e88acbfceb&lang=en&topic=" + categoryName.ToLower());
            return JsonConvert.DeserializeObject<Root>(response);
            */
        }
    }
}
