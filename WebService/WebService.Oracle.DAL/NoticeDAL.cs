using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using WebService.IDAL;
using WebService.Model;
using WebService.Oracle.DAL.DBContext;

namespace WebService.Oracle.DAL
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
            using (var db = new WebServiceDBContext(_configuration))
            {
                return db.Notices
                    .OrderByDescending(n => n.NoticeNo)
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
