using Autofac;
using Autofac.Extras.DynamicProxy;
using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Business.Concrete;
using Castle.DynamicProxy;
using OnlineCourseManagement.Models.Core.Utilities.Interceptors;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //For Users Controller
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            //For Payments Controller
            builder.RegisterType<PaymentManager>().As<IPaymentService>().SingleInstance();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>().SingleInstance();

            //For Categories Controller
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

            //For Courses Controller
            builder.RegisterType<CourseManager>().As<ICourseService>().SingleInstance();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>().SingleInstance();

            //For CourseInstructors Controller
            builder.RegisterType<CourseInstructorManager>().As<ICourseInstructorService>().SingleInstance();
            builder.RegisterType<EfCourseInstructorDal>().As<ICourseInstructorDal>().SingleInstance();

            //For Lessons Controller
            builder.RegisterType<LessonManager>().As<ILessonService>().SingleInstance();
            builder.RegisterType<EfLessonDal>().As<ILessonDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
