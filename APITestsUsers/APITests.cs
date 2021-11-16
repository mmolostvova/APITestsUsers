using System;
using System.Collections.Generic;
using System.Net;
using APITestsUsers.Helpers;
using APITestsUsers.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;

namespace APITestsUsers
{
    public class Tests
    {        
        [Test]
        public void DoRegisterValidTest()
        {
            // Arrange
            RequestHelper request = new RequestHelper("http://users.bugred.ru/tasks/rest/doregister");
            DoRegisterRequestModel body = DataHelper.FillDoRegisterRequestModel();            

            // Act
            IRestResponse response = request.SendPostRequest(body);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void CreateUserValidTest()
        {
            // Arrange
            RequestHelper request = new RequestHelper("http://users.bugred.ru/tasks/rest/createuser");
            CreateUserRequestModel body = DataHelper.FillCreateUserRequestModel();            

            // Act
            IRestResponse response = request.SendPostRequest(body);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void CreateUserWithTasksValidTest()
        {
            // Arrange
            RequestHelper request = new RequestHelper("http://users.bugred.ru/tasks/rest/createuserwithtasks");
            CreateUserRequestModel body = DataHelper.FillCreateUserRequestModelWithTasks();

            // Act
            IRestResponse response = request.SendPostRequest(body);

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
