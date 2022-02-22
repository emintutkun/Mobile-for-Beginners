using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonelDBFirst.Models.Data;

namespace PersonelDBFirst.Connection
{
    public static class DbSingleTone
    {
        static perdb2Entities db;
        public static perdb2Entities GetConnection()
        {
            if (db == null)
            {
                db = new perdb2Entities();
            }
            return db;
        }
    }
}