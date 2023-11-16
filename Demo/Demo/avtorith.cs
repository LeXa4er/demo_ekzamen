using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo
{
    public partial class avtorith : Form
    {
        public avtorith()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=LEXA;Initial Catalog=bitovaya_texnika;Integrated Security=True";
 
        private void registr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            regisrt registr = new regisrt();
            registr.Show();
        }

        private void vxod_Click(object sender, EventArgs e)
        {
            string logini = login.Text;
            string password = paswd.Text;



            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT COUNT(*) FROM [user] WHERE login = @login AND paswd = @paswd";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", logini);
                    command.Parameters.AddWithValue("@paswd", password);

                    connection.Open();
                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {

                        MessageBox.Show("Авторизация успешна!");
                        this.Hide();
                        glav_form glavForms = new glav_form();
                        glavForms.Show();
                    }
                    else
                    {

                        MessageBox.Show("Неверный логин или пароль. Пожалуйста, попробуйте снова.");
                    }
                }

            }
        }
    }
}
