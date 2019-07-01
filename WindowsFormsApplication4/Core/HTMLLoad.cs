﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4.Core
{
    class HTMLLoad
    {
        readonly HttpClient client;
        readonly string url;

        public HTMLLoad()
        {
        }

        public HTMLLoad(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;

            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }

        internal Task ParseAsync(string source)
        {
            throw new NotImplementedException();
        }
    }
}
