using Microsoft.Extensions.Configuration;
using OrderManagement.DAL.DataContext;
using OrderManagement.IDAL;
using OrderManagement.Model;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public bool PostNotice(Notice notice)
        {
            throw new NotImplementedException();
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
