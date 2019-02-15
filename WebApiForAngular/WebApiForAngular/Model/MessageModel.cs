using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiForAngular.Model
{
    public class MessageModel
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
