﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkEmailing
{
    class dbConnection
    {

        public static SqlConnection getCon()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["dbEmailConnectionString"].ConnectionString);
        }
    }
}
