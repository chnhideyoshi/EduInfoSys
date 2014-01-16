using System;
using System.Collections.Generic;
using System.Text;

namespace EduInfoSystem.Model
{
    public class AuthInfo
    {
        [RealName(RealName = "用户名")]
        public string UserName { get; set; }
        [RealName(RealName = "密码")]
        public string Password { get; set; }
        [RealName(RealName = "权限种类")]
        public string AuthType { get; set; }
    }
}
