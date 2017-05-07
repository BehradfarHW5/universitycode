using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BL;
using DA;


namespace BL
{
    public class lesson : dataaccesslayer
    {
        public int lessonid;
        public string fieldid;
        public int lessonname;
        public string teachername;
        public string classhour;
        public DataTable selectlesson()
        {
            base.connect();
            string sql = "select * from lesson";
            sql = string.Format(sql);
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;
        }
    }
   public  class student:dataaccesslayer 
    {
       public string name;
       public string family;
       public int shid;
       public string address;
       public string tell;
       public string gender;
       public int fieldcode;
       public void add()
       {
           base.connect();
           string sql = "insert into student (name,family,shid,address,tell,gender,fieldcode) values ( '{0}' , '{1}' , {2} , '{3}' , '{4}' , '{5}' , {6} )";
           sql = string.Format(sql, name, family, shid, address, tell, gender, fieldcode);
           base.docommand(sql);
           base.disconnect();
       }
   

    
       public DataTable select()
       {
           base.connect();
           string sql = "select * from student";
           DataTable dt = base.select(sql);
           base.disconnect();
           return dt;
       }
       public DataTable selectone()
       {
           base.connect();
           string sql = "select * from student where shid={0}";
           sql = string.Format(sql, shid);
           DataTable dt = base.select(sql);
           base.disconnect();
           return dt;
       }
      

    }
}
