using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Reporting.Processing;
using Telerik.Reporting.Services;
using Telerik.Reporting.Services.AspNetCore;

namespace RPS.Web.Server.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ReportsControllerBase
    {
        public ReportsController(IReportServiceConfiguration reportServiceConfiguration)
            : base(reportServiceConfiguration)
        { }

        protected override UserIdentity GetUserIdentity()
        {
            var identity = base.GetUserIdentity();
            identity.Context = new System.Collections.Concurrent.ConcurrentDictionary<string, object>();
            // identity.Context["UrlReferrer"] = System.Web.HttpContext.Current.Request.UrlReferrer;

            // Any other available information can be stored in the identity.Context in the same way

            return identity;
        }
    }
}
