﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAgencyAPI.Utils
{
    public class ResponseModel
    {
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }
    }
}
