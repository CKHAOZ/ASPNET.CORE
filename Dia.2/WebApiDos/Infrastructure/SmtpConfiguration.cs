using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDos.Infrastructure
{
    public class SmtpConfiguration
    {
        public string Name { get; set; }

        public int Port { get; set; }

        public string From { get; set; }

        public string FromPassword { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
