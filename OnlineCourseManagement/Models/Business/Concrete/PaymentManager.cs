using OnlineCourseManagement.Models.Business.Abstract;
using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.DataAccess.Abstract;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;
        private ICourseDal _courseDal;

        public PaymentManager(IPaymentDal paymentDal, ICourseDal courseDal)
        {
            _paymentDal = paymentDal;
            _courseDal = courseDal;
        }
        public IResult AddPayment(Payment payment)
        {
            payment.ProcessDate = DateTime.Now;
            _paymentDal.Add(payment);
            return new SuccessResult("payment tablosuna eklendi");
        }

        public IDataResult<List<Payment>> GetPaymentsByUserId(int id)
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetAll(p => p.UserId == id));
        }
    }
}
