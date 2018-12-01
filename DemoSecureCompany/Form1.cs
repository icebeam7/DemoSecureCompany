using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DemoSecureCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Configuración:
         * Recuerda abrir App.config y agregar la cadena de conexión
         * la cual obtienes desde el portal de Azure
         * además, hay que agregar  Column Encryption Setting=Enabled 
         * para que autorice las operaciones de encriptación
         * 
         * También se agregó una referencia a la librería System.Configuration
         */

        private void Add_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DemoConnectionString"].ToString();
                connection.Open();

                using (var command = new SqlCommand("AddEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    var lastName = new SqlParameter("@LastName", SqlDbType.VarChar, 32);
                    lastName.Value = LastNameText.Text;

                    var salary = new SqlParameter("@Salary", SqlDbType.Decimal);
                    salary.Value = decimal.Parse(SalaryText.Text);

                    command.Parameters.Add(lastName);
                    command.Parameters.Add(salary);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Employee added!");

                    SalaryText.Clear();
                    LastNameText.Clear();
                }
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DemoConnectionString"].ToString();
                connection.Open();

                using (var command = new SqlCommand("GetEmployeeByLastName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    var lastName = new SqlParameter("@LastName", SqlDbType.VarChar, 32);
                    lastName.Value = LastNameText.Text;

                    command.Parameters.Add(lastName);

                    var dataReader = command.ExecuteReader();
                    while(dataReader.Read())
                    {
                        SalaryText.Text = dataReader["Salary"].ToString();
                    }
                }
            }
        }
    }
}