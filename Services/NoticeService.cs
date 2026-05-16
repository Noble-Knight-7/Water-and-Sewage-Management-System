using System.Collections.Generic;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class NoticeService
    {
        private readonly NoticeRepository _repo;
        public NoticeService() { _repo = new NoticeRepository(); }

        public List<Notice> GetAll() => _repo.GetAll();
        public bool Publish(Notice notice) => _repo.Insert(notice);
        public bool Delete(int noticeID) => _repo.Delete(noticeID);
    }
}
