using Newtonsoft.Json;
using Shop;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Server
{
    class Program
    {

        private static Shop.Shop _shop = new Shop.Shop();


        static void Main(string[] args)
        {
            using(var httpListener = new HttpListener())
            {
                httpListener.Prefixes.Add("http://localhost:8080/");
                httpListener.Start();


                while (true)
                {
                    var requestContext = httpListener.GetContext();
                    var request = requestContext.Request;
                    var respounce = requestContext.Response.OutputStream;

                    switch (request.HttpMethod)
                    {
                        case "GET":

                            var data = JsonConvert.SerializeObject(_shop.ProductList.GetList());

                            var bytes = Encoding.UTF8.GetBytes(data);

                            requestContext.Response.StatusCode = (int)HttpStatusCode.OK;

                            respounce.Write(bytes, 0, bytes.Length);
                            requestContext.Response.Close();

                            break;
                        case "POST":

                            string text;
                            using (var reader = new StreamReader(request.InputStream,
                                     request.ContentEncoding))
                            {
                                text = reader.ReadToEnd();
                            }

                            Console.WriteLine(text);

                            var res = JsonConvert.DeserializeObject<Product>(text);

                            _shop.ProductList.Add(res);

                            requestContext.Response.StatusCode = (int)HttpStatusCode.OK;
                            requestContext.Response.Close();

                            break;
                        case "PUT":
                            break;
                        case "DELETE":
                            break;
                        default:
                            break;
                    }
                }

                


            }
        }
    }
}
