using OnlineCourseManagement.Models.Core.Utilities.Results;
using OnlineCourseManagement.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Business.Abstract
{
    public interface IPaymentService
    {
        IResult AddPayment(Payment payment);
        IDataResult<List<Payment>> GetPaymentsByUserId(int id);
    }
}
