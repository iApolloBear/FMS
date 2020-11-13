using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Nexus8
{
    class RAGE
    {
        private char[] char_map = new char[15] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', 'e', 'E', '-', '+' };
        private int[] final = new int[9] { 0, 0, 1, 1, 0, 1, 0, 0, 1 };
        /*private int N_Estados = 8;
        private int N_Caracteres = 14;*/

        private int[,] States = new int[15, 9] {{ 1,  1,  3,  3,  5,  5,  8,  8,  8 },  
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 1,  1,  3,  3,  5,  5,  8,  8,  8 },   
                         { 4,  2, -1, -1, -1, -1, -1, -1, -1 },   
                         {-1, 6, 6,  6, -1,  6, -1, -1, -1 },   
                         {-1, 6, 6,  6, -1,  6, -1, -1, -1 },   
                         {-1, -1, -1, -1, -1, -1,  7, -1, -1 },   
                         {-1, -1, -1, -1, -1, -1,  7, -1, -1 }
                      };

        public void Imprimir_Matriz(ListBox listBox1)
        {
            listBox1.Items.Clear();
            String Chain = "";

            for (int y = 0; y < States.GetLength(0); y++)
            {
                Chain = "";
                for (int x = 0; x < States.GetLength(1); x++)
                {
                    Chain += States[y, x].ToString() + "\t";
                }
                listBox1.Items.Add(Chain + "\n");
            }
        }

        public void Imprimir_Car(Label label3)
        {
            String Gillo = " ";

            for (int x = 0; x < char_map.Length; x++)
            {
                Gillo += Convert.ToString(char_map[x] + " ");
            }
            label3.Text = Gillo;
        }

        public void Imprimir_Estados(Label label3)
        {
            String Gillo = " ";

            for (int x = 0; x < final.Length; x++)
            {
                Gillo += Convert.ToString(final[x] + " ");
            }
            label3.Text = Gillo;
        }

        public void Imprimir_Archivo(ArrayList Contenido,ListBox listBox2)
        {
            listBox2.Items.Clear();
            foreach(String Line in Contenido)
            {
                listBox2.Items.Add(Line + "\n");
            }
            listBox2.Visible = true;
        }

        public ArrayList Abrir_Archivo(String Arch)
        {
            ArrayList Lines = new ArrayList();
            Lines.Clear();
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Title = "Open Text File";
            Dialog.Filter = "TXT files|*.txt";
            Dialog.InitialDirectory = @"Bibliotecas";           
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                Arch = Dialog.FileName;
                FileStream Archivo = new FileStream(Arch, FileMode.Open);
                StreamReader LECTOR = new StreamReader(Archivo);

                while (LECTOR.Peek() != -1)
                {
                    Lines.Add(LECTOR.ReadLine() + "\n");
                }
                LECTOR.Close();
            }
            return Lines;
            
        }

        public int char_index(char c)
        {
            for(int x = 0; x < char_map.Length; x++)
            {
                if(char_map[x] == c)
                {
                    return x;
                }
            }
            return -1;
        }

        public bool aplicar_fsm(String prim_caract, int pos, out int len)
        {
            int Stat = 0;            
            int i = pos;
            int j = 0;
            char p = prim_caract[pos];
            int Last_State = -1;
            char Last_Char;

            while(p != ' ' && Stat != -1)
            {
                int CIndex = char_index(p);
                if(CIndex < 0)
                {
                    break;
                }

                Stat = States[CIndex, Stat];
                if (Stat != -1)
                {
                    if(final[Stat] == 1)
                    {
                        Last_State = Stat;
                        j = i;
                        Last_Char = p;
                    }
                }
                i++;

                if(i < prim_caract.Length)
                {
                    p = prim_caract[i];
                }
                else
                {
                    p = ' ';
                }
            }

            if(Last_State == -1)
            {
                len = -1;
                return false;
            }

            len = j - pos + 1;
            return true;
        }

        public bool find_token(String Line, out int loc, out int len)
        {
            String p = Line;
            bool found_token = false;
            int CIndex = -1;
            int i = 0;
            int j = 0;
            int Longitud = 0;

            while(p.Length != i && found_token == false)
            {
                while(p.Length != i)
                {
                    CIndex = char_index(p[i]);
                    if(CIndex >= 0)
                    {
                        break;
                    }
                    i++;
                }

                if(CIndex < 0)
                {
                    loc = -1;
                    len = -1;
                    return false;
                }

                char First_char = p[i];
                j = i;
                found_token = aplicar_fsm(p, i, out len);
                Longitud = len;

                if(!found_token)
                {
                    i++;
                }
            }

            if(!found_token)
            {
                loc = -1;
                len = -1;
                return false;
            }
            loc = j;
            len = Longitud;
            return true;
        }

        public String Encontrar_patrones(String Line)
        {
            //String Letra = " ";
            int loc, len;
            if (!find_token(Line, out loc, out len))
            {
                return Line + "----- No contiene una cadena valida";
            }
            else
            {
                String Letra = "";
                for (int x = loc; x < loc + len; x++)
                {
                    Letra += Line[x];
                }
                return Letra+ " ----- Encontrado en la posicion: " + loc;
            }
        }

        public ArrayList Encontrar_patrones(ArrayList contenido)
        {
            int loc, len;
            ArrayList Bitch = new ArrayList();
            foreach(String Line in contenido)
            {
                if(!find_token(Line, out loc, out len))
                {
                    Bitch.Add(Line);
                }
                else
                {
                    String Letra = " ";
                    for(int x = loc; x < loc + len; x++)
                    {
                        Letra += Line[x];
                    }
                    Bitch.Add(Letra + " ----- Encontrado en la posicion: " + loc);
                }
            }
            return Bitch;
        }

          
    }
}
