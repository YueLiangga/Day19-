using System;
using System.Collections.Generic;
using Model;
namespace DAL
{
    public class ProductDAL
    {
        Dapper<Product> db = new Dapper<Product>();

        public List<Product> Show() 
        {
            string sql = "select * from Product";

            List<Product> list = db.Query(sql);

            return list;
        }
        public int Add(Product s)
        {
            string sql = $"insert into Product values('{s.Name}','{s.Time}','{s.Titel}')";

            int i = db.RUD(sql);

            return i;
        }
    }
}
