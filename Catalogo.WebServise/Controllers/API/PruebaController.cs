﻿using Catalogo.WebServise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Catalogo.WebServise.Controllers.API
{
    public class PruebaController : ApiController
    {
        // GET: api/Prueba
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Prueba/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Prueba
        //public IHttpActionResult Post([FromBody]Dato dato)
        //{
        //}

        // PUT: api/Prueba/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Prueba/5
        public void Delete(int id)
        {
        }
    }
}
