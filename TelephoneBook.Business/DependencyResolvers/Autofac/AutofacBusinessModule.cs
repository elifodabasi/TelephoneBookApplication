using Autofac;
using TelephoneBook.Business.ContactInfoOps;
using TelephoneBook.Business.PersonOps;
using TelephoneBook.DataAccess.EntityFramework.ContactInfoDal;
using TelephoneBook.DataAccess.EntityFramework.PersonDal;

namespace TelephoneBook.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            #region DataAccessLayers
            builder.RegisterType<EfPersonDal>().As<IPersonDal>().SingleInstance();
            builder.RegisterType<EfContactInfoDal>().As<IContactInfoDal>().SingleInstance();
            #endregion

            #region BusinessLayer
            builder.RegisterType<PersonService>().As<IPersonService>().SingleInstance();
            builder.RegisterType<ContactInfoService>().As<IContactInfoService>().SingleInstance();

            #endregion
        }
    }
}
