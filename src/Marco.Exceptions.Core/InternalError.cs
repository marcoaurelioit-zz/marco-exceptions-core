using System;

namespace Marco.Exceptions.Core
{
    public class InternalError
    {
        public Guid LogEntryId { get; set; }
        public Exception Exception { get; set; }
    }
}