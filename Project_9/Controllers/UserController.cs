﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project_9.Models.DAL;
using Project_9.Models;

namespace Project_9.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/User/5
        //[HttpPut]
        //[Route("api/User?userEmail")]

        public User Get(string userEmail)
        {
            User U = new User();
            return U.ReadUser(userEmail);
        }


        //public User Get()
        //{
        //    User U = new User();
        //    return U.ReadUser();
        //}



        //POST: api/User
        public HttpResponseMessage Post([FromBody] User user)
        {
            user.InsertUser();
            return Request.CreateResponse(HttpStatusCode.Created, "GOOD");
        }

        //public void Post([FromBody] User user)
        //{
        //     user.InsertUser();
        //}

        //// PUT: api/User/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/User/5
        //public void Delete(int id)
        //{
        //}
    }
}
