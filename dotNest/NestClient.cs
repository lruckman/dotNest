using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace dotNest
{
    public class NestClient
    {
        internal RequestContext Context = null;

        public NestClient(string username, string password)
        {
            Authenticate(username, password);
        }

        public IDictionary<string, Structure> Status()
        {
            var structures = new Dictionary<string, Structure>();

            var requestUriString = string.Format(Constants.RequestUriFormat,
                                                 Context.TransportUrl,
                                                 Context.User);

            Get(requestUriString).Run((response) =>
                {
                    foreach (var s in response.structure)
                    {
                        var structureData = s.Value;
                        var structure = new Structure(structureData);

                        foreach (var deviceId in structure.Devices.Keys.ToArray())
                        {
                            var deviceData = response.device[deviceId];
                            structure.Devices[deviceId] = new Device(deviceData);
                        }

                        structures.Add(s.Key, structure);
                    }
                });

            return structures;
        }

        #region internals

        internal void Authenticate(string username, string password)
        {
            Login(username, password).Run((response) => { Context = new RequestContext(response); });
        }

        internal HttpWebRequest Login(string username, string password)
        {
            var request = WebRequest.Create(Constants.AuthenticationUrl) as HttpWebRequest;

            request.Method = "POST";
            request.UserAgent = Constants.UserAgent;
            request.ContentType = Constants.ContentType;

            request.WriteJsonData(new
                {
                    username,
                    password
                });

            return request;
        }

        internal HttpWebRequest CreateBaseRequest(string requestUriString)
        {
            var request = WebRequest.Create(requestUriString) as HttpWebRequest;

            request.UserAgent = Constants.UserAgent;
            request.Host = new Uri(Context.TransportUrl).Host;
            request.Headers.Set("X-nl-protocol-version", Constants.ProtocolVersion);
            request.Headers.Set("Authorization", string.Format("Basic {0}", Context.AccessToken));

            return request;
        }

        internal HttpWebRequest Get(string requestUriString)
        {
            var request = CreateBaseRequest(requestUriString);

            request.Method = "GET";
            request.Headers.Set("Accept-Language", Constants.AcceptLanguage);
            request.Headers.Set("X-nl-user-id", Context.UserId);

            return request;
        }

        internal HttpWebRequest Post(string requestUriString, object data)
        {
            var request = CreateBaseRequest(requestUriString);

            request.Method = "POST";
            request.WriteJsonData(data);

            return request;
        }

        #endregion
    }
}