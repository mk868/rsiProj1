using AutoMapper;
using rsiProj1.Extensions;
using rsiProj1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace rsiProj1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Models.Event, EventListItemViewModel>()
                    .ForMember(m => m.WeekOfYear, o => o.MapFrom(m => m.Date.GetWeekOfYear()));
                cfg.CreateMap<Models.Event, EventViewModel>()
                    .ForMember(m => m.WeekOfYear, o => o.MapFrom(m => m.Date.GetWeekOfYear()));
                cfg.CreateMap<Models.Type, TypeViewModel>();
            });
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}