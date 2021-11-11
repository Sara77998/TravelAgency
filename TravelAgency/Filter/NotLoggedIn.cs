using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgency.Filter
{
    public class NotLoggedIn : ActionFilterAttribute
    {
    }
}
