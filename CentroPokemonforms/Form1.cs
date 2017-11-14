using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroPokemonforms
{
    public partial class Form1 : Form
    {
        List<Pokemon> listadepokemones = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] texto1 = Enum.GetNames(typeof(tipotipo));
            for (int i = 0; i < texto1.Length; i++)
            {
                cbotipo.Items.Add(texto1[i]);
                cbotipo.SelectedIndex = -1;
            }
            string[] textoestado = Enum.GetNames(typeof(tipoesatados));
            for (int i = 0; i < textoestado.Length; i++)
            {
                cboestado.Items.Add(textoestado[i]);
                cboestado.SelectedIndex = -1;
            }
            string[] texto3 = Enum.GetNames(typeof(pokerus));
            for (int i = 0; i < texto3.Length; i++)
            {
                cbopokerus.Items.Add(texto3[i]);
                cbopokerus.SelectedIndex = -1;
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Pokemon pk1 = new Pokemon()
            {
                Nombre = txtnombre.Text,
                Numero = int.Parse(txtnumero.Text),
                Hp = int.Parse(txthp.Text),
                Pokeruss = (pokerus)Enum.Parse(typeof(pokerus), cbopokerus.SelectedItem.ToString()),
                Estado = (tipoesatados)Enum.Parse(typeof(tipoesatados), cboestado.SelectedItem.ToString()),
                Tipo = (tipotipo)Enum.Parse(typeof(tipotipo), cbotipo.SelectedItem.ToString())
            };
            listadepokemones.Add(pk1);
            MessageBox.Show("Hemos recibido tu Pokemon enfermo");
            txthp.Text = " ";
            txtnombre.Text = " ";
            txtnumero.Text = "";
            cboestado.SelectedIndex = -1;
            cbopokerus.SelectedIndex = -1;
            cbotipo.SelectedIndex = -1;
        }

        private void atendidos_Click(object sender, EventArgs e)
        {
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                txtdatos.Text = txtdatos.Text + "Nombre:\t" +
               listadepokemones[i].Nombre + "\tNumero: " +
               listadepokemones[i].Numero + "\tHP: " +
               listadepokemones[i].Hp + "\r\nTipo: " +
               listadepokemones[i].Tipo + "    En Estado: " +
               listadepokemones[i].Estado + "\r\n Estado Pokerus: " +
               listadepokemones[i].Pokeruss + "\r\n";

            }

        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            int x = 0; int z = 0; int q = 0; int w = 0; int r = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].Estado == tipoesatados.congelado)
                    x = x + 1;
                else if (listadepokemones[i].Estado == tipoesatados.envenenado)
                    z = z + 1;
                else if (listadepokemones[i].Estado == tipoesatados.paralizado)
                    q = q + 1;
                else if (listadepokemones[i].Estado == tipoesatados.quemado)
                    w = w + 1;
                else if (listadepokemones[i].Estado == tipoesatados.somnoliento)
                    r = r + 1;
            }
            txtdatos.Text = "Pokemones Congelados " + x + "\r\nPokemones Envenenados " + z + "\r\n Pokemones Paralizado  " + q + "\r\n" +
                "Pokemones Quemados " + w + "\r\nPokemones Somnolientos " + r;

        }

        private void btntipo_Click(object sender, EventArgs e)
        {
            int x = 0; int z = 0; int q = 0; int w = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].Tipo == tipotipo.fuego)
                {
                    x = x + 1;
                }
                else if (listadepokemones[i].Tipo == tipotipo.agua)
                {
                    z = z + 1;
                }
                else if (listadepokemones[i].Tipo == tipotipo.planta)
                {
                    q = q + 1;
                }
                else if (listadepokemones[i].Tipo == tipotipo.tierra)
                {
                    w = w + 1;
                }
                txtdatos.Text = "de tipo fuego " + x + " \r\n  de tipo Agua " + z + "\r\n" +
                    "\r\nde tipo planta " + q + "\r\nde tipo Tierra " + w;
            }
        }

        private void btnhp_Click(object sender, EventArgs e)
        {
            int a = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].Hp == 0)
                {
                    a = a + 1;
                }
                txtdatos.Text = "Total de Pokemon con hp=0 : " + a;
            }
        }

        private void btninfectados_Click(object sender, EventArgs e)
        {
            int a = 0; int b = 0;
            txtdatos.Text = "";
            for (int i = 0; i < listadepokemones.Count; i++)
            {
                if (listadepokemones[i].Pokeruss == pokerus.si)
                {
                    a = a + 1;
                }
                else if (listadepokemones[i].Pokeruss == pokerus.no)
                {
                    b = b + 1;
                }
                txtdatos.Text = "Infectados de Pokerus " + a + "\r\n   No Infectados de Pokerus " + b;

            }
        }

        private void btnpokerus_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
