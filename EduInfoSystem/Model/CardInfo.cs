using System;
using System.Collections.Generic;
using System.Text;

namespace EduInfoSystem.Model
{
    public class CardInfo
    {
         [RealName(RealName = "卡号")]
        public string CardId { get; set; }
         [RealName(RealName = "学号")]
        public string StudentId { get; set; }
         [RealName(RealName = "状态")]
        public string State { get; set; }
    }
}
