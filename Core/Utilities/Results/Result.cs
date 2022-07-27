using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }//getter'lar read only dir. sadece okunabilir, set edilemez. fakat constructor içinde set edilebilir

        public string Message { get; }
    }
}
