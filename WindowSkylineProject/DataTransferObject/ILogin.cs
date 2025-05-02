using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public interface ILogin
    {
        string UserName { get; }
        string Password { get; }
        string TableInDB { get; }
    }
}
