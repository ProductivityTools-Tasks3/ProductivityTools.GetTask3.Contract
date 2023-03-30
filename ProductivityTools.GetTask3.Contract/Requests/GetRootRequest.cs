using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.GetTask3.Contract.Requests
{
    public class GetRootRequest
    {
        //i think it should be changed to not nullable
        public int? ElementId { get; set; }
        public string Path { get; set; }
    }
}
