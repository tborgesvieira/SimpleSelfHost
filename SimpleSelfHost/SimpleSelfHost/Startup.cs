﻿using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
            app.UseErrorPage();
            
            app.UseWelcomePage("/");
        }
    }
}
