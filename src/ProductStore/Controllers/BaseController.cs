using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProductStore.Controllers
{
    public class BaseController : Controller
    {

        //todo: improve it
        protected internal string SourceName
        {
            get
            {

                if (Session["source"] == null)
                {
                    Session["source"] = "memory";
                }

                return Session["source"].ToString();
            }
            set { Session["source"] = value; }
        }
    }
}
