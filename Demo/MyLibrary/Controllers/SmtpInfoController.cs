using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MyLibrary.Insfrastructure;
using MyLibrary.Insfrastructure.Settings;

namespace MyLibrary.Controllers
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
        }

        public IActionResult Error()
        {
            var nonValue = HttpContext.Session.GetString(Constants.Sessions.NonExisting);
            if (string.IsNullOrWhiteSpace(nonValue))
            {
                throw new ArgumentNullException(nameof(nonValue));
            }

            return Content(nonValue);
        }
    }
}