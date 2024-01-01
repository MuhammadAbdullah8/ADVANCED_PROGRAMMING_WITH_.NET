using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace BDMinimumrent.Controllers
{
    public class AdminhotelinfoController : ApiController
    {
        [HttpGet]
        [Route("api/Adminhotelinfos")]
        public HttpResponseMessage Adminhotelinfos()
        {
            try
            { 
                var data = AdminhotelinfoServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/Adminhotelinfos/{id}")]
        public HttpResponseMessage Adminhotelinfo(int id)
        {
            try
            {
                var data = AdminhotelinfoServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/Adminhotelinfos/{id}/Adminhotelreviews")]
        public HttpResponseMessage Adminhotelinforeviews(int id)
        {
            try
            {
                var data = AdminhotelinfoServices.GetwithComments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
