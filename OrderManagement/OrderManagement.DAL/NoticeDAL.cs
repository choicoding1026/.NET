using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using OrderManagement.DAL.DataContext;
using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrderManagement.DAL
{
    public class NoticeDAL : INoticeDAL
    {
        private readonly IConfiguration _configuration;

        public NoticeDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<Notice> GetNoticeList()
        {
            using (var db = new OrderManagementDbContext(_configuration))
            { 
                return db.Notices
                    .OrderByDescending(n=>n.NoticeNo)
                    .ToList();
            }
        }

        public Notice GetNotice(int noticeNo)
        {
            using (var db = new OrderManagementDbContext(_configuration))
            {
                return db.Notices
                    .FirstOrDefault(n => n.NoticeNo.Equals(noticeNo));
            }
        }

        public bool PostNotice(Notice notice)
        {
            try
            {
                using (var db = new OrderManagementDbContext(_configuration))
                {
                    notice.UserNo = db.Users.Single(u => u.UserID == notice.UserID).UserNo;

                    db.Notices.Add(notice);
                    db.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNotice(Notice notice)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNotice(int noticeNo)
        {
            throw new NotImplementedException();
        }
    }
}
