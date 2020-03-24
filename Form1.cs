using System;
using System.Windows.Forms;

namespace CalendarioSignos
{
    public partial class Form1 : Form
    {
        int diaInt = 0;
        int mesInt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {

            /*
             * Tratamento de exceções
             */
            try
            {
                diaInt = Convert.ToInt32(txt_Dia.Text);
                mesInt = Convert.ToInt32(txt_Mes.Text);
            }
            catch (FormatException es)
            {
                MessageBox.Show(es.Message);
                txt_Dia.Clear();
                txt_Mes.Clear();
                txt_Resultado2.Clear();
                txt_Dia.Focus();

            }

            /*
             * Instanciando o objeto 'InteroretadorSigno' chamando ele de 
             * interpretador.
             * Ele irá invocar a logica na classe interpretadorSigno
             */
            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.Interpretar(diaInt, mesInt);
            if (signo != null)
            {
                txt_Resultado2.Text = ($"SIGNO: {signo.nome}\nCARACTERISTICA: {signo.caracteristicas}");
            }

            else
            {
                MessageBox.Show("Não foi possivel interpretar seu signo!");
                txt_Dia.Clear();
                txt_Mes.Clear();
                txt_Resultado2.Clear();

            }

            /*
             * Verifica se alguns dos campos após algum resultado 
             * está em branco ou valor invalido
             *
             */
            if (String.IsNullOrEmpty(txt_Mes.Text) || txt_Mes.Text == "0")
            {
                txt_Resultado2.Clear();
            }
            else if (string.IsNullOrEmpty(txt_Dia.Text) || txt_Mes.Text == "0")
            {
                txt_Dia.Clear();
                txt_Mes.Clear();
                txt_Resultado2.Clear();
            }
            else
            {
                txt_Dia.Focus();
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Dia.Clear();
            txt_Mes.Clear();
            txt_Resultado2.Clear();
            txt_Dia.Focus();
        }
    }
}
