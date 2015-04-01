using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcSample.BussinessData
{
    public class Data
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Address");
            dt.Rows.Add("01", "Krishna", "jadskhfd");
            dt.Rows.Add("02", "Mouli", "sdfdd");
            dt.Rows.Add("03", "Medida", "sdsfdsds");
         
            return dt;
        }
    }
}