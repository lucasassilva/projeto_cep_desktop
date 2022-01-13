/*
 * Autor: Brayan Richard Ventura Alvino
 * Data: 05/03/2018
 * Descrição: Buscar o CEP
 */ 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCEP
{
    public partial class frmCEP : Form
    {
        public frmCEP()
        {
            InitializeComponent();
        }
        //Botão para limpar os campos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //comando para limpar
            mtbCEP.Clear();
            txtEndereco.Clear();
            txtComp.Clear();
            txtComp2.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtEstado.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe ws 
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    //declarar variavel
                    var resultado = ws.consultaCEP(mtbCEP.Text);

                    //componentes 
                    txtEndereco.Text = resultado.end;
                    txtComp.Text = resultado.complemento;
                    txtComp2.Text = resultado.complemento2;
                    txtCidade.Text = resultado.cidade;
                    txtBairro.Text = resultado.bairro;
                    txtEstado.Text = resultado.uf;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }
    }
}
