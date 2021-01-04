﻿using NewsSite.BL.Abstractions;
using NewsSite.BL.DbModels;
using System.Collections.Generic;

namespace NewsSite.BL.DTOModels
{
    public class DTOUser : IDTOModel
    {
        readonly internal DbUser DbObject;

        IDbObject IDTOModel.DbObjectOfDTOModel => DbObject;


        internal DTOUser(DbUser dbUser)
        {
            DbObject = dbUser;
        }

        public DTOUser(string name, string email)
        {
            DbObject = new DbUser(name, email);
        }

        public List<string> GetInfo()
        {
            var info = new List<string>
            {
                DbObject.Name,
                DbObject.Email
            };

            return info;
        }
    }
}
