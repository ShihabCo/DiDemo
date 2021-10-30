using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIDemo.Services.IServices;

namespace DIDemo.Services
{
    public class PermissionServiceTransient : IPermissionServiceTransient
    {
        private string _permission = "Read";
        private string _secret = "admin";
        public string GetPermission()
        {
            return _permission;
        }

        public void setPermission(string secret)
        {
            if (secret == _secret)
            {
                _permission = "Modify";
            }
        }
    }

    
}
