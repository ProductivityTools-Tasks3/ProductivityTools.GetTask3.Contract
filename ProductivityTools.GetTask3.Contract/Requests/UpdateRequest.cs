using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.GetTask3.Contract.Requests
{
    public class UpdateRequest
    {

        public int ParentId { get; set; }
        public int ElementId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string DetailsType { get; set; }
    }
}
