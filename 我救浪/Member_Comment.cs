//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 我救浪
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member_Comment
    {
        public int CommentID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> Grade { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Product Product { get; set; }
    }
}
