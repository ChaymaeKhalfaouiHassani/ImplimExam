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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImpliExam
{
    public partial class Form1 : Form
    {
        SqlConnection SQLserverConnection = new SqlConnection();
        SqlDataAdapter SQLserverAdapter = new SqlDataAdapter();
        String SQLserverChaineConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jaguar\\Documents\\Exam.mdf;Integrated Security=True;Connect Timeout=30";
        static string chaine = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jaguar\Documents\Exam.mdf;Integrated Security=True;Connect Timeout=30";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cnx.Open();
            cmd.CommandText = "select * from Exam";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into Exam(NomEx,NomProf,Datedb,DateFin,TypeEx) values('" + NomEx.Text + "','" + NomProf.Text + "','"+ Datedb.Text + "','" + DateFin.Text + "','" + TypeEx.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update Dossier set NomEx='" + NomEx.Text + "' where NomEx='" + NomEx.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from Exam where NomEx='" + NomEx.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
