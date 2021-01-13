using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;

namespace OrderManagement.BLL
{
    public class NoticeBLL
    {
        private readonly INoticeDAL _noticeDal;

        public NoticeBLL(INoticeDAL noticeDal)
        {
            _noticeDal = noticeDal;
        }

        public List<Notice> GetNoticeList()
        {
            return _noticeDal.GetNoticeList();
        }

        public Notice GetNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();
            return _noticeDal.GetNotice(noticeNo);
        }

        public bool PostNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentNullException();
            return _noticeDal.PostNotice(notice);
        }

        public bool UpdateNotice(Notice notice)
        {
            if (notice == null) throw new ArgumentNullException();
            return _noticeDal.UpdateNotice(notice);
        }

        public bool DeleteNotice(int noticeNo)
        {
            if (noticeNo <= 0) throw new ArgumentException();
            return _noticeDal.DeleteNotice(noticeNo);
        }
    }
}
