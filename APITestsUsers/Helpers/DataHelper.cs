using System;
using APITestsUsers.Models;

namespace APITestsUsers.Helpers
{
    public static class DataHelper
    {
        public static DoRegisterRequestModel FillDoRegisterRequestModel()
        {
            DoRegisterRequestModel user = new DoRegisterRequestModel
            {
                Email = Helper.MakeEmail(),
                Name = Helper.MakeName(),
                Password = Helper.MakePass()
            };
            return user;
        }

        public static CreateUserRequestModel FillCreateUserRequestModel()
        {
            CreateUserRequestModel user = new CreateUserRequestModel
            {
                Email = Helper.MakeEmail(),
                Name = Helper.MakeName()
            };
            return user;
        }

        public static CreateUserRequestModel FillCreateUserRequestModelWithTasks()
        {
            CreateUserRequestModel user = new CreateUserRequestModel
            {
                Email = Helper.MakeEmail(),
                Name = Helper.MakeName(),
                Tasks = Helper.MakeTasks()
            };
            return user;
        }
    }
}
