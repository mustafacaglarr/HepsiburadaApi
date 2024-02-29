﻿using HepsiApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Domain.Entities
{
    public class Detail : EntityBase
    {

        public Detail()
        {
            
        }

        public Detail(string title,string description,int categoryId)
        {
            Title= title;
            Description= description;
            CategoryId= categoryId;
        }
        public  string Title { get; set; }
        public  string Description { get; set; }
        public  int CategoryId { get; set; }
        public Category category { get; set; }

    }
}