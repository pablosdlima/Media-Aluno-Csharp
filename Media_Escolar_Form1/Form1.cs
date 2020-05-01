using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Escolar_Form1
{
    public partial class form_Calculo : Form
    {
        //string nome; //variaveis nome
        private double portn1, portn2, m_port;  //Var Notas Materias Português
        private double matn1, matn2, m_mat; //Var Notas Materias Matematica
        private double hisn1, hisn2, m_his; //Var Notas Materias Historia
        private double geon1, geon2, m_geo; //Var Notas Materias Geografia
        private double cien1, cien2, m_cie; //Var Notas Materias Ciencias
        private string Nome_aluno;

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        //
        public form_Calculo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPortn1.Clear();  //ZERANDO OS CAMPOS DE TEXTOS.
            txtPortn2.Clear();
            txtMatn1.Clear();
            txtMatn2.Clear();
            txtHisn1.Clear();
            txtHisn2.Clear();
            txtGeon1.Clear();
            txtGeon2.Clear();
            txtCien1.Clear();
            txtCien2.Clear();  
            txtNome.Clear();     //ZERANDO OS CAMPOS DE TEXTOS.

            lblPort.Text = "________";
            lblMat.Text = "________";
            lblHis.Text = "________";
            lblGeo.Text = "________";
            lblCie.Text = "________";

            lblnome.Text = "Aluno ";
            lblFichap.Text = "Português: ";
            lblFicham.Text = "Matemática: ";
            lblFichah.Text = "História: ";
            lblFichag.Text = "Geografia: ";
            lblFichac.Text = "Ciências: ";



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            portn1 = double.Parse(txtPortn1.Text); //Variavel Recebe o valor que está em 'txtvar.text' convertido ao tipo double
            portn2 = double.Parse(txtPortn2.Text);
            m_port = (portn1 + portn2) / 2; //variavel é == a Var1 + Var2 / 2
            lblPort.Text = "\t\t" + m_port; //Exibindo em label 'lblvar.text' + Variavel
            //
            matn1 = double.Parse(txtMatn1.Text); //Variavel Recebe o valor que está em 'txtvar.text' convertido ao tipo double
            matn2 = double.Parse(txtMatn2.Text);
            m_mat = (matn1 + matn2) / 2; //variavel é == a Var1 + Var2 / 2
            lblMat.Text = "\t\t" + m_mat; //Exibindo em label 'lblvar.text' + Variavel
            //
            hisn1 = double.Parse(txtHisn1.Text); //Variavel Recebe o valor que está em 'txtvar.text' convertido ao tipo double
            hisn2 = double.Parse(txtHisn2.Text);
            m_his = (hisn1 + hisn2) / 2; //variavel é == a Var1 + Var2 / 2
            lblHis.Text = "\t\t" + m_his; //Exibindo em label 'lblvar.text' + Variavel
            //
            geon1 = double.Parse(txtGeon1.Text); //Variavel Recebe o valor que está em 'txtvar.text' convertido ao tipo double
            geon2 = double.Parse(txtGeon2.Text);
            m_geo = (geon1 + geon2) / 2; //variavel é == a Var1 + Var2 / 2
            lblGeo.Text = "\t\t" + m_geo; //Exibindo em label 'lblvar.text' + Variavel
            //
            cien1 = double.Parse(txtCien1.Text); //Variavel Recebe o valor que está em 'txtvar.text' convertido ao tipo double
            cien2 = double.Parse(txtCien2.Text);
            m_cie = (cien1 + cien2) / 2; //variavel é == a Var1 + Var2 / 2
            lblCie.Text = "\t\t" + m_cie; //Exibindo em label 'lblvar.text' + Variavel
                                          //
            string Nome_aluno = txtNome.Text; //Variavel recebe o valor de TXT
            lblnome.Text = "Aluno: " + Nome_aluno;

            if(m_port >= 7)
            {
                lblFichap.Text = "Português: Aluno Aprovado";
            }
            else if (m_port == 6)
            {
                lblFichap.Text = "Português: Aluno em Exame";
            }
            else
            {
                lblFichap.Text = "Português: Aluno Reprovado!!";
            }
            //PULA LINHA

            if (m_mat >= 7)
            {
                lblFicham.Text = "Matemática: Aluno Aprovado";
            }
            else if (m_mat == 6)
            {
                lblFicham.Text = "Matemática: Aluno em Exame";
            }
            else
            {
                lblFicham.Text = "Matemática: Aluno Reprovado!!";
            }
            //PULA LINHA

            if (m_his >= 7)
            {
                lblFichah.Text = "Historia: Aluno Aprovado";
            }
            else if (m_his == 6)
            {
                lblFichah.Text = "Historia: Aluno em Exame";
            }
            else
            {
                lblFichah.Text = "Historia: Aluno Reprovado!!";
            }
            //PULA LINHA

            if (m_geo >= 7)
            {
                lblFichag.Text = "Geografia: Aluno Aprovado";
            }
            else if (m_geo == 6)
            {
                lblFichag.Text = "Geografia: Aluno em Exame";
            }
            else
            {
                lblFichag.Text = "Geografia: Aluno Reprovado!!";
            }
            //PULA LINHA

            if (m_cie >= 7)
            {
                lblFichac.Text = "Ciências: Aluno Aprovado";
            }
            else if (m_cie == 6)
            {
                lblFichac.Text = "Ciências: Aluno em Exame";
            }
            else
            {
                lblFichac.Text = "Ciências: Aluno Reprovado!!";
            }
            //PULA LINHA






        }
    }
}
/*  
    Classe_Ficha ficha1 = new Classe_Ficha(); //CHAMANDO A CLASSE FICHA // REPRESENTADA POR "ficha1"
            ficha1.setNome_aluno(txtNome.Text); //buscando valor inserido no campo 'txtnome' e encaminhando para 'Nome_aluno'
*/
