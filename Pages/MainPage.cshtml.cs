using BlazorDB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace BlazorDB.Pages
{
    public class MainPageModel : PageModel
    {
        public List<DataDB> mo = new List<DataDB>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Server=10.0.1.124;Initial Catalog=info;User ID=sa;Password=Passw0rd;Database=DataDB;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM DataDB";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DataDB employeesInfo = new DataDB();


                                employeesInfo.Id = reader.GetInt32(0);
                                employeesInfo.Name = reader.GetString(1);
                                employeesInfo.Email = reader.GetString(2);
                                employeesInfo.PhoneNum = reader.GetString(3);
                                employeesInfo.Birthday = reader.GetDateTime(4);

                                mo.Add(employeesInfo);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
        public void ListCheck()
        {
            foreach (var Employees in mo)
            {
                
            }
        }
    }
}
