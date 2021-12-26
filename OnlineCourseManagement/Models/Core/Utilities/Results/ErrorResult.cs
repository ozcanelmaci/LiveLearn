using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Core.Utilities.Results
{
    public class ErrorResult : Result // inheritance
    {
        public ErrorResult(string message) : base(false, message)
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}
