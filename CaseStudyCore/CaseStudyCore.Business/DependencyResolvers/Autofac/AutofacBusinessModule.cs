using Autofac;
using CaseStudyCore.Business.Abstract;
using CaseStudyCore.Business.Concrete;
using CaseStudyCore.DataAccess.Abstract;
using CaseStudyCore.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyManager>().As<ICompanyService>();
            builder.RegisterType<CompanyDal>().As<ICompanyDal>();

            builder.RegisterType<ServiceManager>().As<IServiceService>();
            builder.RegisterType<ServiceDal>().As<IServiceDal>();

            //builder.RegisterType<UserManager>().As<IUserService>();
            //builder.RegisterType<UserDal>().As<IUserDal>();
        }
    }
}
