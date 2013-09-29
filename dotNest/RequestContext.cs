using System;

namespace dotNest
{
    internal class RequestContext
    {
        internal RequestContext(dynamic data)
        {
            var urls = data.urls;
            if (urls == null)
            {
                return;
            }

            AccessToken = data.access_token;
            Email = data.email;
            ExpiresIn = DateTime.Parse(data.expires_in);
            IsStaff = data.is_staff;
            IsSuperUser = data.is_superuser;
            User = data.user;
            UserId = data.userid;

            LogUploadUrl = urls.log_upload_url;
            RubyApiUrl = urls.rubyapi_url;
            SupportUrl = urls.support_url;
            TransportUrl = urls.transport_url;
            WeatherUrl = urls.weather_url;

            var limits = data.limits;

            StructuresLimit = limits.structures;
            ThermostatsLimit = limits.thermostats;
            ThermostatsPerStructureLimit = limits.thermostats_per_structure;
        }

        public string AccessToken { get; private set; }
        public string Email { get; private set; }
        public DateTime ExpiresIn { get; private set; }
        public bool IsStaff { get; private set; }
        public bool IsSuperUser { get; private set; }

        public string LogUploadUrl { get; private set; }
        public string RubyApiUrl { get; private set; }
        public string SupportUrl { get; private set; }
        public string TransportUrl { get; private set; }
        public string WeatherUrl { get; private set; }

        public int StructuresLimit { get; private set; }
        public int ThermostatsLimit { get; private set; }
        public int ThermostatsPerStructureLimit { get; private set; }

        public string User { get; private set; }
        public string UserId { get; private set; }
    }
}