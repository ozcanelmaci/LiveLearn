using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineCourseManagement.Models.Core.Utilities.Results
{
    public class Result : IResult
    {
        //overload denir
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
