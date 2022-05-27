using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaja.App_Code.Model
{
    public class generator
    {

        //private FbConnection _objcon;
        //private ConnectionConfiguration _objConfig = new ConnectionConfiguration();

        public string GetGenerator()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            FbConnection objcon = new FbConnection("Data Source=localhost;Initial Catalog=C:\\gdb\\laserken\\GESTOR.GDB; User Id=SYSDBA;password=masterkey;Charset=ISO8859_1; ");
            string idCage = "";
            try
            {
                
                objcon.Open();
                string query = "select GEN_ID( CODIGOCAGE, 1 ) AS IDCAGE FROM RDB$DATABASE";
                //ds = SqlFbHelper.ExecuteDataset(_objcon, CommandType.Text, query);
                var command=objcon.CreateCommand();
                command.CommandText = query;

                var reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    idCage = reader["IDCAGE"].ToString();

                }

               
            }
            catch (Exception ex)
            {
                dt = null;
            }
            finally
            {
                if (objcon.State == ConnectionState.Open)
                {
                    objcon.Close();
                }
            }
            return idCage;
        }


    }
}
