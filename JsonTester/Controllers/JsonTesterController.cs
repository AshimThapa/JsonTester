using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JsonTester.Models;


namespace JsonTester.Controllers
{
    public class JsonTesterController : ApiController
    {
        //post  methd to parse JSon raw data from body 
        [HttpPost]
        public HttpResponseMessage Post([FromBody] JsonInputDTO inputJson)
        {
            if (inputJson != null)   //if null means service couldn't convet it to json
            {
                //assign to thr reult
                List<JsonResultDTO> resultList = new List<JsonResultDTO>();

                //iterate thorugh each payload object to filter by condition
                foreach (var item in inputJson.payload)
                {
                    //check condition
                    if (item.drm == true & item.episodeCount > 0)
                    {
                        // hold the filtered values in an instance of a class JsonReultDTO
                        JsonResultDTO resultObject = new JsonResultDTO
                        {
                            //check condition with condtional operator
                            image = item.image != null ? item.image.showImage : null,
                            slug = item.slug != null ? item.slug : null,
                            title = item.title != null ? item.title : null
                        };
                        //add each filered object to list of type object
                        resultList.Add(resultObject);
                    }
                }

                //assign to another list name reponse
                ResponseDTO lastResult = new ResponseDTO();
                lastResult.response = resultList;

                //return Httpmessage
                HttpResponseMessage message = Request.CreateResponse(HttpStatusCode.OK, lastResult);
                return message;
            }
            else
            {
                //intialize error message in readable format
                Error errMessage = new Error();
                errMessage.error="Could not decode request: JSON parsing failed";
                return Request.CreateResponse(HttpStatusCode.BadRequest, errMessage);//return httpmessage
            }
        }
    }
}
