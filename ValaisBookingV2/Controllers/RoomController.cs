using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ValaisBookingV2.Controllers
{
    [RoutePrefix("rooms")]
    public class RoomController : ApiController
    {
        string a = "salut";
        private static readonly HttpClient Httpclient;
        public String testRita;

        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAllRooms()
        {
            // à faire huhu
        }

    }
}
