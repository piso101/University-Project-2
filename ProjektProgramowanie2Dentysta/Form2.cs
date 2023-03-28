
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjektProgramowanie2Dentysta
{
    public partial class Form2 : Form
    {
		public static string user_name;
		public static string user_password;
		public static int id;
		SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StoMaToLogiczne;Integrated Security=True");
		SqlCommand cmd;
		SqlDataReader rd;
		public Form2()
        {
            InitializeComponent();
		}
		public void Userd_id(string c, string d)
		{
			try
			{
				user_name = c.ToString();
				user_password = d.ToString();
				string command = "SELECT id FROM Users WHERE login = '" + user_name + "' AND password = '" + user_password + "'";
				cn.Open();
				SqlCommand cmd = new SqlCommand(command, cn);
				SqlDataReader reader;
				reader = cmd.ExecuteReader();
				string userid = "";

				while (reader.Read())
				{
					userid = reader["id"].ToString();
				}

				id = int.Parse(userid);
				reader.Close();
				
			}
			catch 
			{ 
				Console.WriteLine("Błąd_book");
			}

		}
		private void main_btn_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void book_btn_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand cmdinsert = new SqlCommand();
				cmdinsert.Connection = cn;
				cmdinsert.CommandText = "INSERT INTO Orders (user_id,doctor_id,meeting_date) Values (@pam1,@pam2,@pam3)";
				//dodajemy wartości do komendy sql
				cmdinsert.Parameters.AddWithValue("@pam1", id);
				cmdinsert.Parameters.AddWithValue("@pam2", doctor_id);
				cmdinsert.Parameters.AddWithValue("@pam3", date_box.Text.ToString());
				cmdinsert.CommandType = CommandType.Text;
				cmdinsert.ExecuteNonQuery();//wykonujemy komende dodania rekordu w tablicy zabukowane
			} 
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message + "LOL");
			}

		}
	}
}
