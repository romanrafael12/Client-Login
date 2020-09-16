using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
namespace Client_Login
{



    class UserRepository : IUserRepository
    {
        public async Task<bool> Insert (User LoginDB)
        {

            //el nombre db es el nombre de la base de datos y donde esta declarada.
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(Client_Login.Properties.Resources.InsertUser, new { UserName = LoginDB.UserName, Password = LoginDB.Password });
                       
                 return result > 0;
            }
        }

        
    }

   



}
