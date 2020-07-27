using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Libros.Data
{
    public class LibroManager
    {
        const string url = "http://192.168.43.75:3000/libros/";
        public async Task<IEnumerable<Libro>> GetAll()
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(url);
            return JsonConvert.DeserializeObject<IEnumerable<Libro>>(result);
        }

    }
}
