using System;

namespace OMInsurance.Services.Entities.Core.Exeptions
{
    public class DataObjectAlreadyExistsException : ApplicationException
    {
        public DataObjectAlreadyExistsException()
        {
        }

        public DataObjectAlreadyExistsException(string message)
            : base(message)
        {
        }

        public DataObjectAlreadyExistsException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
