using Dapper;
using DapperMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DapperMVC.Controllers
{
    public class ValuesController : ApiController
    {
        private SqlConnection conc = new SqlConnection(
       @"Data Source=STJCZC2403LJ2\SQLEXPRESS;Initial Catalog=TestDB;integrated security=True;MultipleActiveResultSets=True;");

        // GET api/values
        public List<Kategori> Get()
        {
            conc.Open();
            conc.Execute("insert into Kategori(k_ad) values(@k_ad)", new[] {
                        new { k_ad = "sinema" } }
            );

            conc.Execute("insert into Yorum(y_name,y_detail,y_date,y_newsID) values(@y_name,@y_detail,@y_date,@y_newsID)",
                new Yorum()
                {
                    y_name = "edebi yorum",
                    y_detail = "asddwererge",
                    y_date = DateTime.Parse("02.02.2019")
                }
                );
            conc.Close();


            conc.Open();
            var gelenData = conc.Query("select * from Yorum").ToList();

            List<Kategori> kategoridata = conc.Query<Kategori>("select * from Kategori").ToList();
            conc.Close();
            return kategoridata;
            
        }

    // GET api/values/5
    public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
