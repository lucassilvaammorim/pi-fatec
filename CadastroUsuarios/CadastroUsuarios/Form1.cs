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
using System.Threading;
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
            //inicializacao de componentes
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
            //salvar dados
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
            //atualizar dados
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
            //deletar dados
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
            //carrega dados selcionados da grid view
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
            //abertura de porta serial
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = cb_port.Items[cb_port.SelectedIndex].ToString();
                    serialPort1.Open();
                    btn_con.Text = "Desconectar";
                    cb_port.Enabled = false;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;

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
            //fechando a porta serial
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //le a entrada da serial e dispara evento para escrever na serial
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(serialResponse));
        }
        private void serialResponse(object sender, EventArgs e)
        {
            try
            {
                //recebe numero da serial
                txt_serial.AppendText("Recebido <- " + RxString);

                //filtra sujeira (como barra n)
                RxString = RxString.Substring(0, RxString.Length - 2);

                //busca no banco de dados
                Cartao cartaoEscolhido = dados.GetById(RxString);

                //delay 1 segundo
                Thread.Sleep(1000);

                //respostas para a serial
                //serial.write escreve na serial / append text adiciona texto no textbox
                if (cartaoEscolhido != null)
                {
                    if (cartaoEscolhido.Validade >= DateTime.Today)
                    {
                        serialPort1.Write("1"); //status code OK
                        txt_serial.AppendText("Enviado ->( enviado com sucesso)");
                    }
                    else
                    {
                        serialPort1.Write("0");//status not found
                        txt_serial.AppendText("Enviado ->( Fora da data de validade)");
                    }
                }
                else
                {
                    serialPort1.Write("0");//status not found
                    txt_serial.AppendText("Enviado ->( Registro incorreto)");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
