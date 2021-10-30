using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Services.IServices
{
    public interface IPermissionService
    {
        string GetPermission();

        void setPermission(string secret);
    }
}
