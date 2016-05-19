using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace StreamingDemo.Controllers
{
    /*
    [RoutePrefix("api/media")]
    public class MediaController: ApiController
    {
        const string FILE = @"c:\setups\_de_windows_10_enterprise_2015_ltsb_n_x64_dvd_6848328.iso";

        [HttpGet]
        [HttpPost] // Father, forgive me for that !!!
        public HttpResponseMessage Get()
        {
            var response = new HttpResponseMessage();
            response.Headers.Add("X-Information", "You've beeeen haaaacked!!");
            var stream = new FileStream(FILE, FileMode.Open);
            response.Content = new StreamContent(stream);
            return response;
        }

        
        public Stream GetOtherStuff()
        {
            return new FileStream(FILE, FileMode.Open);
        }
        

        public async void Put() 
        {
            Stream stream = await Request.Content.ReadAsStreamAsync();

            int size = 1024 * 1024;
            byte[] buffer = new byte[size];

            while (stream.Read(buffer,0, buffer.Length) > 0)
            {
                Debug.Write(".");
            }

        }

        [Route("pushcontent")]
        public HttpResponseMessage GetWithPushContent()
        {

            var response = new HttpResponseMessage();

            response.Content = new PushStreamContent((stream, httpContent, transportCtx) => {

                using (stream)
                {
                    using (var fileStream = new FileStream(FILE, FileMode.Open))
                    {
                        fileStream.CopyTo(stream);
                    }
                }
            });

            return response;
        }




    }
    */
}