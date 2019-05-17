namespace CadastroUsuarios
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tc_cadastro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_nasc = new System.Windows.Forms.TextBox();
            this.tb_validade = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_atualizar = new System.Windows.Forms.Button();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.btn_con = new System.Windows.Forms.Button();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.timerCom = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tc_cadastro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_cadastro
            // 
            this.tc_cadastro.Controls.Add(this.tabPage1);
            this.tc_cadastro.Controls.Add(this.tabPage2);
            this.tc_cadastro.Location = new System.Drawing.Point(12, 3);
            this.tc_cadastro.Name = "tc_cadastro";
            this.tc_cadastro.SelectedIndex = 0;
            this.tc_cadastro.Size = new System.Drawing.Size(652, 513);
            this.tc_cadastro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_cpf);
            this.tabPage1.Controls.Add(this.tb_categoria);
            this.tabPage1.Controls.Add(this.tb_nome);
            this.tabPage1.Controls.Add(this.tb_nasc);
            this.tabPage1.Controls.Add(this.tb_validade);
            this.tabPage1.Controls.Add(this.tb_id);
            this.tabPage1.Controls.Add(this.bt_atualizar);
            this.tabPage1.Controls.Add(this.bt_deletar);
            this.tabPage1.Controls.Add(this.bt_salvar);
            this.tabPage1.Controls.Add(this.dgv_dados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Motivo cartão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data Validade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID cartão";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(17, 74);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(179, 20);
            this.tb_cpf.TabIndex = 14;
            // 
            // tb_categoria
            // 
            this.tb_categoria.Location = new System.Drawing.Point(17, 116);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(179, 20);
            this.tb_categoria.TabIndex = 13;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(249, 31);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(179, 20);
            this.tb_nome.TabIndex = 12;
            // 
            // tb_nasc
            // 
            this.tb_nasc.Location = new System.Drawing.Point(249, 74);
            this.tb_nasc.Name = "tb_nasc";
            this.tb_nasc.Size = new System.Drawing.Size(179, 20);
            this.tb_nasc.TabIndex = 11;
            // 
            // tb_validade
            // 
            this.tb_validade.Location = new System.Drawing.Point(249, 116);
            this.tb_validade.Name = "tb_validade";
            this.tb_validade.Size = new System.Drawing.Size(179, 20);
            this.tb_validade.TabIndex = 10;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(17, 31);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(179, 20);
            this.tb_id.TabIndex = 4;
            // 
            // bt_atualizar
            // 
            this.bt_atualizar.Location = new System.Drawing.Point(473, 68);
            this.bt_atualizar.Name = "bt_atualizar";
            this.bt_atualizar.Size = new System.Drawing.Size(145, 31);
            this.bt_atualizar.TabIndex = 3;
            this.bt_atualizar.Text = "Atualizar";
            this.bt_atualizar.UseVisualStyleBackColor = true;
            this.bt_atualizar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_deletar
            // 
            this.bt_deletar.Location = new System.Drawing.Point(473, 110);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(145, 31);
            this.bt_deletar.TabIndex = 2;
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.UseVisualStyleBackColor = true;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.Color.Transparent;
            this.bt_salvar.Location = new System.Drawing.Point(473, 25);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(145, 31);
            this.bt_salvar.TabIndex = 1;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // dgv_dados
            // 
            this.dgv_dados.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(17, 171);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.Size = new System.Drawing.Size(601, 310);
            this.dgv_dados.TabIndex = 0;
            this.dgv_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_serial);
            this.tabPage2.Controls.Add(this.btn_con);
            this.tabPage2.Controls.Add(this.cb_port);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serial";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(6, 71);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(188, 21);
            this.cb_port.TabIndex = 0;
            // 
            // btn_con
            // 
            this.btn_con.Location = new System.Drawing.Point(6, 98);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(129, 23);
            this.btn_con.TabIndex = 1;
            this.btn_con.Text = "Conectar";
            this.btn_con.UseVisualStyleBackColor = true;
            this.btn_con.Click += new System.EventHandler(this.btn_con_Click);
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(6, 127);
            this.txt_serial.Multiline = true;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(632, 354);
            this.txt_serial.TabIndex = 2;
            // 
            // timerCom
            // 
            this.timerCom.Interval = 1000;
            this.timerCom.Tick += new System.EventHandler(this.timerCom_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 528);
            this.Controls.Add(this.tc_cadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tc_cadastro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_cadastro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_nasc;
        private System.Windows.Forms.TextBox tb_validade;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_atualizar;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.Button btn_con;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Timer timerCom;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

