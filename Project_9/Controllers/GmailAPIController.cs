﻿using Project_9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project_9.Controllers
{
    public class GmailAPIController : ApiController
    {
        // GET: api/GmailAPI
        public IEnumerable<string> Get(string id)
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GmailAPI/5
        public string Get()
        {
            RequestParameters NewLogin = new RequestParameters();
            return NewLogin.CreateHref();


        }

        // POST: api/GmailAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GmailAPI/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/GmailAPI/5
        public void Delete(int id)
        {
        }
    }
}
