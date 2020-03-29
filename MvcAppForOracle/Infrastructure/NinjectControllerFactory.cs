using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using System.Web.Routing;
using MvcAppForOracle.Abstract;
using MvcAppForOracle.Repository;

namespace MvcAppForOracle.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;
        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance
            (RequestContext requestContext, Type controllerType)
        {
            // if statement.
            return controllerType == null ? null :
                (IController)_ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            _ninjectKernel.Bind<IEmployee>().To<EmployeeRepository>();
        }
    }
}