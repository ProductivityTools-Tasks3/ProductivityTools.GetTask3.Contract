using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductivityTools.GetTask3.Contract
{
    public class ListRequest
    {
        public int? ElementId { get; set; }
        public string Path { get; set; }

        //used in reporting when we do not have user in the bearer
        public string UserEmail { get; set; }
    }
}
