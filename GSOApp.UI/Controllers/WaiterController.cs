using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ClientApp.Controllers
{
    public class WaiterController : ApiController
    {
        // GET: api/Waiter
        public IEnumerable<string> Get()
        {
                private const string URL = "https://sub.domain.com/objects.json";
                private string urlParameters = "?api_key=123";
        
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
                foreach (var d in dataObjects)
                {
                    Console.WriteLine("{0}", d.Name);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }




            return new string[] { "value1", "value2" };
        }

        // GET: api/Waiter/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Waiter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Waiter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Waiter/5
        public void Delete(int id)
        {
        }
    }
}
