using System.Collections.Generic;

namespace ComplaintMngSys.Models.ComplaintViewModel
{
    public class StatusManageViewModel
    {
        public StatusUpdateViewModel StatusUpdateViewModel { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}
