﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Repository;

namespace DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal:GenericRepository<SocialMedia>, ISocialMediaDal
    {
    }
}
