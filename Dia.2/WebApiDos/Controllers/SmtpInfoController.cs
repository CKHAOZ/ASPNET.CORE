using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDos.Infrastructure;

namespace WebApiDos.Controllers
{
    public class SmtpInfoController : Controller
    {
        private readonly SmtpConfiguration smtpConfiguration;

        private readonly ILogger<SmtpInfoController> logger;

        public SmtpInfoController(IOptionsSnapshot<SmtpConfiguration> smtpConfiguration, ILogger<SmtpInfoController> logger)
        {
            this.logger = logger;
            this.smtpConfiguration = smtpConfiguration.Value;
        }

        public IActionResult Get()
        {
            var smtpInfo = HttpContext.Session.GetString(Constants.Sessions.SmtpInfo);
            if (string.IsNullOrWhiteSpace(smtpInfo))
            {
                smtpInfo = smtpConfiguration.ToString();
                HttpContext.Session.SetString(Constants.Sessions.SmtpInfo, smtpInfo);
            }

            logger.LogInformation("Smtp Information {@Info}", smtpConfiguration);
            return Content(smtpInfo);
            
            //logger.LogInformation("SMTP Info {@smtp}", smtpConfiguration);
            //return Content(smtpConfiguration.ToString());
        }
    }
}
