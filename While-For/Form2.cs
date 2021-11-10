using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            //Apresenta o formulário e chama em seguida
            novo.Show();
            //Fecha o formulário atual
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2021;

            while (contador >= 1950)
            {
                cboAno.Items.Add(contador);
                contador--;
            }
            /*Declaração da variável contador do tipo inteiro, onde foi atribuído o valor de 2021 (ano)
             *Enquanto o contador for maior ou igual a 1950, o contador faz o decremento.
             *Ou seja começa em 2021 e vai até 1950.
             *Itens são adicionados no Contador.*/
        }
    }
}
