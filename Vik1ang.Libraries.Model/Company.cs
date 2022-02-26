using System;

namespace Vik1ang.Libraries.Model
{
    public class Company : BaseModel
    {
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        public int LastModifiedId { get; set; }
        public DateTime LastModifiedTime { get; set; }
    }
}