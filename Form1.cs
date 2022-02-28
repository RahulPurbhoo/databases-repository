using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp_CourseAssessment0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MyConnection = "server=localhost;user id=root;persistsecurityinfo=True;database=college;username=root;password=Dars15hna!";

            string Query = "select * from college.student;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MyConnection = "server=localhost;user id=root;persistsecurityinfo=True;database=college;username=root;password=Dars15hna!";

            string Query = "SELECT Student.Student_FName, ROUND((Student.Alegbra + Student.Calculus + Student.Programming + Student.S_Databases) / 4, 1) AS Average FROM Student;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }
    }
}

