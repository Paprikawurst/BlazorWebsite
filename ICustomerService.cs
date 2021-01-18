using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebsite
{
    public interface ICustomerService
    {
        string Uid { get; set; }
        Customer GetCustomerById(int id);
    }
}
