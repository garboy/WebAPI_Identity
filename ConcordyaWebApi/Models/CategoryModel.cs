﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConcordyaPayee.Web.Api.Models
{
    public class CategoryModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
    }
}
