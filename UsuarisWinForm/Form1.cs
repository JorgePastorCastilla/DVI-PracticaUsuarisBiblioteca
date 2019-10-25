using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;

namespace UsuarisWinForm
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Town_Click(object sender, EventArgs e)
        {

        }

        private void Surname_Click(object sender, EventArgs e)
        {

        }

        private string connectionString = "Server=localhost;Port=3306;Database=biblioteca;Uid=root;Pwd=seCret_19";
        private void Registerbutton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                MySqlConnection cnn = new MySqlConnection(connectionString);
                string sql = "SELECT MAX(ID_USR) FROM USUARIS";
                int newID;

                    try
                {
                    newID = ( cnn.Query<int>(sql).FirstOrDefault() ) + 1; //FirstOrDefault is provided by 
                }
                catch(Exception ex)
                {
                    newID = 1;
                    Console.WriteLine( "Warning Exception Thrown: " + ex.Message );
                }

               string sqlInsert = $"INSERT INTO USUARIS (ID_USR, DNI_USR, NOM_USR, LLINATGE1, POB_USR, EMAIL_USR, PASSWORD) VALUES({newID},'{DniTextBox.Text}','{NameTextBox.Text}','{SurnameTextBox.Text}','{TownComboBox.Text}','{EmailTextBox.Text}','{PasswordTextBox.Text}')";
                var rowsAffected = cnn.Execute(sqlInsert);
                if (rowsAffected == 1)
                {
                    MessageBox.Show("User register succesfully","User Manager", MessageBoxButtons.OK);
                    ClearFindFields();
                }
                cnn.Close();
            }
        }
        private void ClearFindFields()
        {
            DniTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            SurnameTextBox.Text = String.Empty;
            TownComboBox.Text = String.Empty;
            EmailTextBox.Text = String.Empty;
            PasswordTextBox.Text = String.Empty;
            ConfirmPasswordTextBox.Text = String.Empty;
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void FindSurnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                MySqlConnection cnn = new MySqlConnection(connectionString);
                string sql = "SELECT DNI_USR, NOM_USR, LLINATGE1, POB_USR, EMAIL_USR FROM usuaris";
            if (
                !string.IsNullOrEmpty(FindDNITextBox.Text) ||
                !string.IsNullOrEmpty(FindNameTextBox.Text) ||
                !string.IsNullOrEmpty(FindSurnameTextBox.Text) ||
                !string.IsNullOrEmpty(FindTownComboBox.Text) ||
                !string.IsNullOrEmpty(FindEmailTextBox.Text)
                )
            {
                sql += " WHERE ";
            }
            if ( !string.IsNullOrEmpty(FindDNITextBox.Text) ) sql += $"DNI_USR = '{FindDNITextBox.Text}' AND ";
            if ( !string.IsNullOrEmpty(FindNameTextBox.Text) ) sql += $"NOM_USR = '{FindNameTextBox.Text}' AND ";
            if ( !string.IsNullOrEmpty(FindSurnameTextBox.Text) ) sql += $"LLINATGE1 = '{FindSurnameTextBox.Text}' AND ";
            if ( !string.IsNullOrEmpty(FindTownComboBox.Text) ) sql += $"POB_USR = '{FindTownComboBox.Text}' AND ";
            if ( !string.IsNullOrEmpty(FindEmailTextBox.Text) ) sql += $"EMAIL_USR = '{FindEmailTextBox.Text}' AND ";
            // sql = sql.Substring( sql.Length-2, 3 );
            if (
              !string.IsNullOrEmpty(FindDNITextBox.Text) ||
              !string.IsNullOrEmpty(FindNameTextBox.Text) ||
              !string.IsNullOrEmpty(FindSurnameTextBox.Text) ||
              !string.IsNullOrEmpty(FindTownComboBox.Text) ||
              !string.IsNullOrEmpty(FindEmailTextBox.Text)
              )
            {
                sql = sql.Remove(sql.Length - 4);
            }
            sql += ";";
            Console.WriteLine(sql);
            List<User> users = new List<User>();
            users = cnn.Query<User>(sql).ToList();
            UserListBox.DataSource = users;
            UserListBox.DisplayMember = "FullInfo";
            cnn.Close();
        }

        private void FindSurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
