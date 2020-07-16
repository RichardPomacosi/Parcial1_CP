using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorNET_Pregunta2
{
    public partial class Form1 : Form
    {
        public String infija = "3+6*(7-8)";
        public static String calculo = "";
        public static String posfija = "";
		
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			infi(infija);
			infija =infija+ ((Button)sender).Text;
            res.Text = infija.ToString();
        }   
        

        private void Form1_Load(object sender, EventArgs e)
        {
            infija = "";
        }

		public static void infi(string inf)
		{

			//Expresion infija in

			//postfija
			List<string> pos = new List<string>();
			//parsear infija
			List<string> v = parsear(inf);

			Stack<String> p = new Stack<String>();
			//Mapa prioridad de expresion
			Dictionary<String, int> pe = new Dictionary<String, int>();
			pe.Add("^", 4);
			pe.Add("*", 2);
			pe.Add("/", 2);
			pe.Add("+", 1);
			pe.Add("-", 1);
			pe.Add("(", 5);
			//Mapa prioridad cuando esta en la pila
			Dictionary<String, int> pp = new Dictionary<String, int>();
			pp.Add("^", 3);
			pp.Add("*", 2);
			pp.Add("/", 2);
			pp.Add("+", 1);
			pp.Add("-", 1);
			pp.Add("(", 0);
			try
			{
				

				for (int i = 0; i < v.Count; i++)
				{
					if (v[i].Equals("*") || v[i].Equals("/") || v[i].Equals("+") || v[i].Equals("-") || v[i].Equals("(") || v[i].Equals(")") || v[i].Equals("^"))
					{
						
						if (p.Count==0)
						{
							p.Push(v[i]);
						}
						else if (v[i].CompareTo(")") != 0)
						{
							
							while (p.Count!=0 && pe[v[i]] <= pp[p.Peek()])
							{		
								pos.Add(p.Pop());
							}
							p.Push(v[i]);
						}
						else
						{
							while (p.Peek().CompareTo("(") != 0)
							{
								
								pos.Add(p.Pop());
							}
							p.Pop();
						}

					}
					else
					{
						pos.Add(v[i]);
					}
				}
				while (p.Count!=0)
				{
					pos.Add(p.Pop());
				}

				Console.WriteLine("Expresion psfija"+pos);
				
			
				posfija = pos.ToString();
				//proceso de evaluacion
				Stack<String> pev = new Stack<String>();
				double ope1, ope2;
				
				for (int i = 0; i < pos.Count; i++)
				{
					if (pos[i].Equals("*") || pos[i].Equals("/") || pos[i].Equals("+") || pos[i].Equals("-") || pos[i].Equals("^"))
					{
						ope2=

						ope2 = double.Parse(pev.Pop());
						ope1 = double.Parse(pev.Pop());
						pev.Push(calcular(ope1, ope2, pos[i]));
					}
					else
					{
						pev.Push(pos[i]);
					}
				}
				//Se muestra el resultado
				String resultado = pev.Pop();
				if (pev.Count!=0)
				{
					Console.WriteLine("Datos incorrectos!!!!");
					calculo = "Datos Incorrectos!!!";
				}
				else
				{
					Console.WriteLine(resultado);
					calculo = resultado;
				}

			}
			catch (Exception e)
			{
				Console.WriteLine("Datos Incorrectos");
				calculo = "Datos Incorrectos";
			}
		}


		public static string calcular(double a, double b, string x)
        {
            if (x.CompareTo("*") == 0)
                return (a*b).ToString();
            if (x.CompareTo("-") == 0)
                return (a-b).ToString();
            if (x.CompareTo("/") == 0)
                return (a/b).ToString();
            if (x.CompareTo("+") == 0)
                return (a+b).ToString();
            else
                return (Math.Pow(a,b)).ToString();
        }
        public static List<string> parsear(string cad)
        {
            List<string> v = new List<string>();
            
            string x = "";
            for (int i = 0; i < cad.Length; i++)
            {
                x = "";
                if (cad[i]== '*' || cad[i] =='/' || cad[i] == '+'|| cad[i] == '-' || cad[i] == '(' || cad[i]== ')' || cad[i] =='^')
                {
                    v.Add((cad[i]).ToString());
                }
                else
                {
                    int pos = i;
                    while (pos < cad.Length && (cad[pos] != '*' && cad[pos] != '/' && cad[pos] != '+' && cad[pos] != '-' && cad[pos] != '(' && cad[pos] != ')' && cad[pos] != '^'))
                    {

                        x = x + cad[pos];
                        pos++;
                    }
                    v.Add(x);
                    pos--;
                    i = pos;
                }
            }
            return v;
        }

        private void button20_Click(object sender, EventArgs e)
        {
			infi(res.Text.ToString());
			res1.Text = calculo;
			
        }

        private void button3_Click(object sender, EventArgs e)
        {
			res1.Text = "";
			
        }

      
    }
}
