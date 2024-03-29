﻿using LS.Application.Common.Interfaces.Repositories;
using LS.Domain.Entities;
using LS.Infrastracture.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Infrastracture.Persistence.Repositories
{
    public class ReceiptRepository : 
        BaseRepository<Receipt>,
        IReceiptRepository
    {
         
        public List<Receipt> GetList(string name)
        { 
            if (string.IsNullOrEmpty(name))
            {
                return new List<Receipt>();
            }
            //LINQ
            return _objectList.
                Where(entity => entity.
            Title.ToLower().StartsWith(name.ToLower())).ToList();
        }
    }
}
