using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SunProcessor
    {
        public static async Task<SunModel> LoadSunInformation()
        {
            string url = "https://api.sunrise-sunset.org/json?lat=36.7201600&lng=-4.4203400&date=today";


            using (HttpResponseMessage resonse = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (resonse.IsSuccessStatusCode)
                {
                    SunResultModel result = await resonse.Content.ReadAsAsync<SunResultModel>();

                    return result.Results;
                }
                else
                {
                    throw new Exception(resonse.ReasonPhrase);
                }
            }
        }
    }
}
