using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO() { }


        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetAllMember()
        {
            FptEduStoreContext fptEduStoreContext = new FptEduStoreContext();
            var memberList = from member in fptEduStoreContext.Members select member;
            return memberList.ToList();
        }

        public IEnumerable<Member> GetMemberByEmail(string email)
        {
            FptEduStoreContext fptEduStoreContext = new FptEduStoreContext();
            var members = from member in fptEduStoreContext.Members where member.Email.Equals(email) select member;
            return members.ToList();
        }

        public void Insert(Member member)
        {
            try
            {
                using (var FptEduStoreContext = new FptEduStoreContext())
                {
                    FptEduStoreContext.Members.Add(member);
                    FptEduStoreContext.SaveChanges();
                };

            }
            catch (Exception ex)
            {

                throw new Exception("Error Add new Member" + ex.Message);
            }
        }

        public void Update(Member member)
        {
            try
            {
                using (var FptEduStoreContext = new FptEduStoreContext())
                {
                    FptEduStoreContext.Members.Update(member);
                    FptEduStoreContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {

                throw new Exception("Error update Member " + ex.Message);
            }
        }

        public void Delete(Member member)
        {
            try
            {
                using (var FptEduStoreContext = new FptEduStoreContext())
                {
                    var mem = FptEduStoreContext.Members.SingleOrDefault(m => m.MemberId == member.MemberId);
                    FptEduStoreContext.Members.Remove(mem);
                    FptEduStoreContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {

                throw new Exception("Error delete member " + ex.Message);
            }
        }

   
    }
}
