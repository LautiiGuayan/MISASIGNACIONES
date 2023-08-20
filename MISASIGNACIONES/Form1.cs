using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MISASIGNACIONES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             cerrar.Visible = true;    
            P1.Visible=false;
            L1.Visible=false;
            L2.Visible=false;
            L3.Visible=false;
            T1.Visible = false;
            B1.Visible = false;
            B2.Visible = true;
            legajo1.Visible = true;
            consulta.Visible = true;
            dia.Visible = true;
            L5.Visible = true;
            legajo.Text =T1.Text;
            DIA1.Visible = true;
            dia2.Visible = true;


        }

        private void B2_Click(object sender, EventArgs e)
        {

            P1.Visible = true;
            L1.Visible = true;
            L2.Visible = true;
            L3.Visible = true;
            T1.Visible = true;
            B1.Visible = true;
            B2.Visible=false;
            legajo1.Visible=false;
            dia.Visible=false;
            consulta.Visible=false;
            legajo.Text = "";
            L5.Visible=false;
            DIA1.Visible=false;
            dia2.Visible = false;
            cerrar.Visible=false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {


            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
