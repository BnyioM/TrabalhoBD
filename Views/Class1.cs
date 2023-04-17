using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetsManagement.Views
{
    internal class Persistence
    {
        private readonly static string stringConnection = "Data source=BRUNOPC\\SQLEXPRESS; initial catalog=IT_Assets_Management_Relational; user id=sa; pwd=bruno123;";

        public static Login login_account(Account account)
        {
            using (SqlConnection con = new SqlConnection(stringConnection))
            {
                string querySelectAll = "SELECT ID, Name, Email, Password FROM Users";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        if (rdr["Email"].ToString() == account.email && rdr["Password"].ToString() == account.password)
                        {
                            return new Login(DateTime.Now, rdr["Name"].ToString(), Convert.ToInt32(rdr["ID"]));
                        }
                    }
                    return null;
                }
            }
        }
    }
}
