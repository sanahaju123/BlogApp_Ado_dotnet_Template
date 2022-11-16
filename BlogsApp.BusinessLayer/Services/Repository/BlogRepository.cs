
using BlogSApp.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsApp.BusinessLayer.Services.Repository
{
    public class BlogRepository:IBlogRepository
    {
        static private string GetConnectionString()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source=DESKTOP-7LIHPHH\SQLEXPRESS01;Initial Catalog=BlogApp_Db;Integrated Security=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return myConnection.ConnectionString;
        }
        public Blog AddBlog(Blog blog)
        {
            //Write Your Logic Here
            throw new NotImplementedException();
        }

        public Status DeleteBlog(int blogId)
        {
            //Write Your Logic Here
            throw new NotImplementedException();
        }

        public Blog GetBlogById(int blogId)
        {
            //Write Your Logic Here
            throw new NotImplementedException();
        }
    }
}
