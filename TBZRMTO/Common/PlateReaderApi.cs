using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPS.Common
{
   delegate Task<string> Api(byte[] image);
    class PlateReaderApi
    {
        private const string url = "http://172.24.129.5:801/default/index";
        private Api Get()
        {
            return new Api(GetNumber);
        }
        public async Task<string> GetNumberPlate(byte[] image)
        {
            Api api = Get();
            return await api(image);
            //  return "";
        }
        private async Task<string> GetNumber(byte[] image)
        {
            try
            {
                System.Net.WebClient wc = new System.Net.WebClient();

                using (var webClient = new HttpClient())
                {
                    webClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
                    using (var form = new MultipartFormDataContent())
                    {
                        form.Add(new ByteArrayContent(image), "image", "image");
                        HttpResponseMessage responseMessage = await webClient.PostAsync(url, form);
                        responseMessage.EnsureSuccessStatusCode();
                        string responseString = responseMessage.Content.ReadAsStringAsync().Result;
                        return responseString;
                    }
                }
            }
            catch (Exception)
            {
                return "0";
            }

        }
    }
}
