using CadastroUsuarios.DAL;
using CadastroUsuarios.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuarios
{
    public partial class Form1 : Form
    {
        CartaoDao dados;
        String RxString;
        public Form1()
        {
            InitializeComponent();
            dados = new CartaoDao();
            timerCom.Enabled = true;
            AtualizarDisplay();
        }
        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente; //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (cb_port.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (cb_port.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }
            //limpa comboBox
            cb_port.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                cb_port.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            cb_port.SelectedIndex = 0;
        }
        private void AtualizarDisplay()
        {
            this.dgv_dados.DataSource = dados.GetAll();
        }
        private void bt_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                dados.Insert(new Cartao()
                {
                    Cpf = this.tb_cpf.Text,
                    Nascimento = Convert.ToDateTime(this.tb_nasc.Text),
                    Validade = Convert.ToDateTime(this.tb_validade.Text),
                    ID = this.tb_id.Text,
                    Motivo = this.tb_categoria.Text,
                    Nome = this.tb_nome.Text

                });
                AtualizarDisplay();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dados.Update(new Cartao()
                {
                    Cpf = this.tb_cpf.Text,
                    Nascimento = Convert.ToDateTime(this.tb_nasc.Text),
                    Validade = Convert.ToDateTime(this.tb_validade.Text),
                    ID = this.tb_id.Text,
                    Motivo = this.tb_categoria.Text,
                    Nome = this.tb_nome.Text

                });
                AtualizarDisplay();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                Cartao car = dados.GetById(this.tb_id.Text);
                dados.Delete(car);
                AtualizarDisplay();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_dados.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_dados.SelectedRows)
                {
                    tb_id.Text = row.Cells[0].Value.ToString();
                    tb_validade.Text = row.Cells[1].Value.ToString();
                    tb_nome.Text = row.Cells[5].Value.ToString();
                    tb_cpf.Text = row.Cells[4].Value.ToString();
                    tb_nasc.Text = row.Cells[3].Value.ToString();
                    tb_categoria.Text = row.Cells[2].Value.ToString();

                }
            }
        }

        private void timerCom_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = cb_port.Items[cb_port.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btn_con.Text = "Desconectar";
                    cb_port.Enabled = false;

                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    cb_port.Enabled = true;
                    btn_con.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(serialResponse));
        }
        private void serialResponse(object sender, EventArgs e)
        {
            txt_serial.AppendText("Recebido <- " + RxString);
            Cartao cartaoEscolhido = dados.GetById(RxString);
            if (cartaoEscolhido != null)
            {
                if (cartaoEscolhido.Validade >= DateTime.Today)
                {
                    serialPort1.Write("200"); //status code OK
                    txt_serial.AppendText("Enviado -> " + "200" + " ( enviado com sucesso)");
                }
                else
                {
                    serialPort1.Write("404");//status not found
                    txt_serial.AppendText("Enviado -> " + "404" + " ( Fora da data de validade)");
                }
            }
            else
            {
                serialPort1.Write("404");//status not found
                txt_serial.AppendText("Enviado -> " + "404" + " ( Registro incorreto)");
            }
        }
    }
}
