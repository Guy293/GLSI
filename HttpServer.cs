using System;
using System.IO;
using System.Net;

namespace GLSI
{
    class HttpServer
    {
        public void Start()
        {
            try
            {
                HttpListener httpListener = new HttpListener();
                // https://stackoverflow.com/questions/36846535/c-sharp-http-listener-not-listening-on-localhost-only-works-with-fqdn
                //TODO This Fixed the problem
                httpListener.Prefixes.Add("http://10.0.0.32:6666/httpTest/");
                httpListener.Start();
                while (true)
                {
                    Console.WriteLine("Waiting...");
                    HttpListenerContext context = httpListener.GetContext();
                    using (Stream stream = context.Response.OutputStream)
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(
                                         "<HTML><BODY>The time is currently</BODY></HTML>");
                        }
                    }
                    Console.WriteLine("Sent");

                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Status);
            }

        }

    }
}
