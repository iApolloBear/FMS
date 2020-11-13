using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Nexus8
{
    public partial class Form1 : Form
    {
        RAGE NXT = new RAGE();
        ArrayList Contenido = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NXT.Imprimir_Car(label3);
            NXT.Imprimir_Estados(label5);
        }

        private void radioArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioArchivo.Checked == true)
            {
                labelLine.Visible = false;
                textLine.Visible = false;
                buttonArch.Visible = true;
                //btnArch.Visible = true;
                //btnFind.Visible = false;
            }
        }

        private void radioLine_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLine.Checked == true)
            {
                listBox2.Items.Clear();
                listBox2.Visible = false;
                buttonArch.Visible = false;
                labelLine.Visible = true;
                textLine.Visible = true;
                //btnArch.Visible = false;
                btnFind.Visible = true;
            }
        }

        private void buttonArch_Click(object sender, EventArgs e)
        {
            String Archivo = openFileDialog1.FileName;
            Contenido = NXT.Abrir_Archivo(Archivo);
            NXT.Imprimir_Archivo(Contenido, listBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NXT.Imprimir_Matriz(listBox1);
            listBox1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            listBox3.Items.Clear();
            listBox3.Visible = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioArchivo.Checked == true)
            {
                ArrayList Final = NXT.Encontrar_patrones(Contenido);
                listBox1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                listBox3.Items.Clear();
                foreach(String Lineas in Final)
                {
                    listBox3.Items.Add(Lineas + "\n");
                }              
                listBox3.Visible = true;
            }
            else if(radioLine.Checked == true)
            {
                String Line = textLine.Text;
                String MSJ = NXT.Encontrar_patrones(Line);
                MessageBox.Show(MSJ);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
