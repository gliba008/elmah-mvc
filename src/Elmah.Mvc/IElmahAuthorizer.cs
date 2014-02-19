// Extensions made by gliba008. Use this file in any way you want :D
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Elmah.Mvc
{
    // Authorizer for elmah
    public interface IElmahAuthorizer
    {
        /// <summary>
        ///  Method that does custom authorization.
        ///  Throw an exception if user is not authorized.
        /// </summary>
        void DoAuthorization(AuthorizationContext filterContext);
    }
}
