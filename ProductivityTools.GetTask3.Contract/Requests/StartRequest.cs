using ProductivityTools.GetTask3.CoreObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.GetTask3.Contract.Requests
{
    public class ChangeTypeRequest
    {
        public int ElementId { get; set; }
        public string Type { get; set; }
    }
}
