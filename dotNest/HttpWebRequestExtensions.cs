using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Web.Helpers;

namespace dotNest
{
    public static class HttpWebRequestExtensions
    {
        public static void WriteJsonData(this HttpWebRequest request, object data)
        {
            var json = Json.Encode(data);
            request.WriteJsonData(json);
        }

        public static void WriteJsonData(this HttpWebRequest request, string json)
        {
            using (var stream = request.GetRequestStream())
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(json);
                }
            }
        }

        public static void Run(this HttpWebRequest request)
        {
            request.Run(null);
        }

        public static void Run(this HttpWebRequest request, Action<dynamic> responsePacket)
        {
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var json = reader.ReadToEnd();
                        try
                        {
                            var body = Json.Decode(json);
                            if (body != null && responsePacket != null)
                            {
                                responsePacket(body);
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex);
                            throw;
                        }
                    }
                }
            }
        }
    }
}