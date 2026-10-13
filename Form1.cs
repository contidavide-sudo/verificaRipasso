using System.Runtime.InteropServices.Marshalling;

namespace verificaRipasso
{
    public partial class Form1 : Form
    {
        string[] parole = new string[14];
        string[] alfabeto = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] parDef = new string[14];
        string par, parNuova = "";
        string lettera;
        int indice;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDecifra_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("parole.txt"))
            {
                string riga = sr.ReadLine();
                for (int i = 0; i < parole.Length; i++)
                {
                    riga = sr.ReadLine();
                    parole[i] = riga;
                }
            }

            for (int i = 0; i < parole.Length; i=i+2)
            {
                par = parole[i].ToLower();
                parNuova = "";

                for (int j = 0; j < par.Length; j++)
                {
                    lettera = Convert.ToString(par[j]);

                    for (int k = 0; k < alfabeto.Length; k++)
                    {
                        if (alfabeto[k] == lettera)
                        {
                            indice = k;
                        }
                    }

                    if (indice - 3 >= 0)
                    {
                        parNuova = parNuova + alfabeto[indice - 3];
                    }
                    else
                    {
                        parNuova = parNuova + alfabeto[indice - 3 + alfabeto.Length];
                    }

                }

                listDec.Items.Add(parNuova);
                parDef[i] = parNuova;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter("parole decifrate.txt"))
            {
                for(int i = 0; i < parDef.Length; i++)
                {
                    sw.WriteLine(parDef[i]);
                }
            }
        }
    }
}
