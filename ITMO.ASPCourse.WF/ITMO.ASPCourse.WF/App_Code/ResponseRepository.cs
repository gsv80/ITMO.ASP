﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.WF.App_Code
{
    
    public class ResponseRepository
    {
        private static ResponseRepository repository = new ResponseRepository();

        private List<GuestResponse> responses = new List<GuestResponse>();
        public static ResponseRepository GetRepository()
        {
            return repository;
        }
        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }
        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}