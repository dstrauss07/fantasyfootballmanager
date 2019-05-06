using System;
using System.Collections.Generic;
using System.Text;

namespace StraussDa.FantasyPlayerCoreLibrary
{
    public interface IUserRepository
    {
        List<TestUserProfile> ListAllUsers();
        TestUserProfile GetUserById(int id);
        void EditUser(TestUserProfile editedUser);
        void NewUser(TestUserProfile newUser);
        void DeleteUser(int id);
    }
}
