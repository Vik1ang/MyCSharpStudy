using System;
using Vik1ang.Framework.AttributeExtend;
using Vik1ang.Framework.AttributeExtend.Validate;
using Vik1ang.Framework.Model;

namespace Vik1ang.Libraries.Model
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

        [Email]
        public string Email { get; set; }

        [Phone]
        public string Mobile { get; set; }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        [Column("State")]
        public int Status { get; set; }

        public int UserType { get; set; }
        public DateTime LastLoginTime { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        public int LastModifiedId { get; set; }
        public DateTime LastModifiedTime { get; set; }
    }
}