using SomethingBlue.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingBlue.Models
{
    public interface IUserProperties
    {
        public User CurrentUser { get; set; }
    }
}
