using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.GetTask3.Contract.Requests
{
    public class DelayItemRequest
    {
        public int ElementId { get; set; }
        public DateTime InitializationDate { get; set; }
    }
}
