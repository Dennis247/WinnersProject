//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web;
//using WinnersProject.Models;

//namespace WinnersProject.Services
//{
//    public interface MemberInterface
//    {
//        List<Member>  Members();
//        Task<bool> Update(Member member);
//        Task<Member> MemberDetails(int id);
//        Task<bool> DeleteMember(int id);

//    }
//    public class MemberServices : MemberInterface
//    {
//        private ApplicationDbContext db = new ApplicationDbContext();
//        public Task<bool> DeleteMember(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Member MemberDetails(int id)
//        {
//            if (id == 0)
//            {
//                return null;
//            }
//            Member member =  db.Members.Find(id);
//            if (member == null)
//            {
//                return null;
//            }
//            return member;
//        }

//        public  List<Member> Members()
//        {
//            var members =  db.Members.ToList();
//            return members;
//        }
//    }

//        public Task<bool> Update(Member member)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}