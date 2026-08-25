using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.GetTask3.Contract.Requests
{
    public class SetInboxNameRequest
    {
        public int ElementId { get; set; }
        public string InboxName { get; set; }
    }
}
