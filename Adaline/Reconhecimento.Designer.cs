namespace Adaline
{
    partial class Reconhecimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_ruido = new System.Windows.Forms.Label();
            this.bt_testar = new System.Windows.Forms.Button();
            this.tb_caracter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.gv_letra = new System.Windows.Forms.DataGridView();
            this.um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_letra = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_tipo_3 = new System.Windows.Forms.RadioButton();
            this.rb_tipo_2 = new System.Windows.Forms.RadioButton();
            this.rb_tipo_1 = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_letra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_ruido);
            this.groupBox3.Controls.Add(this.bt_testar);
            this.groupBox3.Controls.Add(this.tb_caracter);
            this.groupBox3.Location = new System.Drawing.Point(12, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 85);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de Saida";
            // 
            // lb_ruido
            // 
            this.lb_ruido.AutoSize = true;
            this.lb_ruido.Location = new System.Drawing.Point(9, 29);
            this.lb_ruido.Name = "lb_ruido";
            this.lb_ruido.Size = new System.Drawing.Size(195, 13);
            this.lb_ruido.TabIndex = 2;
            this.lb_ruido.Text = "Caracter Reconhecido: ( Ruido 0,00 % )";
            // 
            // bt_testar
            // 
            this.bt_testar.Location = new System.Drawing.Point(247, 38);
            this.bt_testar.Name = "bt_testar";
            this.bt_testar.Size = new System.Drawing.Size(139, 29);
            this.bt_testar.TabIndex = 4;
            this.bt_testar.Text = "Testar";
            this.bt_testar.UseVisualStyleBackColor = true;
            this.bt_testar.Click += new System.EventHandler(this.bt_testar_Click);
            // 
            // tb_caracter
            // 
            this.tb_caracter.Location = new System.Drawing.Point(12, 46);
            this.tb_caracter.Name = "tb_caracter";
            this.tb_caracter.Size = new System.Drawing.Size(192, 20);
            this.tb_caracter.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_mostrar);
            this.groupBox1.Controls.Add(this.gv_letra);
            this.groupBox1.Controls.Add(this.lb_letra);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Entrada";
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.Location = new System.Drawing.Point(6, 127);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(137, 29);
            this.bt_mostrar.TabIndex = 3;
            this.bt_mostrar.Text = "Mostrar";
            this.bt_mostrar.UseVisualStyleBackColor = true;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
            // 
            // gv_letra
            // 
            this.gv_letra.AllowUserToAddRows = false;
            this.gv_letra.AllowUserToDeleteRows = false;
            this.gv_letra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_letra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.um,
            this.dois,
            this.tres,
            this.quatro,
            this.cinco,
            this.seis,
            this.sete});
            this.gv_letra.Location = new System.Drawing.Point(151, 19);
            this.gv_letra.Name = "gv_letra";
            this.gv_letra.Size = new System.Drawing.Size(222, 226);
            this.gv_letra.TabIndex = 1;
            // 
            // um
            // 
            this.um.HeaderText = "1";
            this.um.Name = "um";
            this.um.Width = 25;
            // 
            // dois
            // 
            this.dois.HeaderText = "2";
            this.dois.Name = "dois";
            this.dois.Width = 25;
            // 
            // tres
            // 
            this.tres.HeaderText = "3";
            this.tres.Name = "tres";
            this.tres.Width = 25;
            // 
            // quatro
            // 
            this.quatro.HeaderText = "4";
            this.quatro.Name = "quatro";
            this.quatro.Width = 25;
            // 
            // cinco
            // 
            this.cinco.HeaderText = "5";
            this.cinco.Name = "cinco";
            this.cinco.Width = 25;
            // 
            // seis
            // 
            this.seis.HeaderText = "6";
            this.seis.Name = "seis";
            this.seis.Width = 25;
            // 
            // sete
            // 
            this.sete.HeaderText = "7";
            this.sete.Name = "sete";
            this.sete.Width = 25;
            // 
            // lb_letra
            // 
            this.lb_letra.FormattingEnabled = true;
            this.lb_letra.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "J",
            "K"});
            this.lb_letra.Location = new System.Drawing.Point(99, 26);
            this.lb_letra.Name = "lb_letra";
            this.lb_letra.Size = new System.Drawing.Size(46, 95);
            this.lb_letra.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_tipo_3);
            this.groupBox2.Controls.Add(this.rb_tipo_2);
            this.groupBox2.Controls.Add(this.rb_tipo_1);
            this.groupBox2.Location = new System.Drawing.Point(8, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(84, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fonte";
            // 
            // rb_tipo_3
            // 
            this.rb_tipo_3.AutoSize = true;
            this.rb_tipo_3.Location = new System.Drawing.Point(7, 69);
            this.rb_tipo_3.Name = "rb_tipo_3";
            this.rb_tipo_3.Size = new System.Drawing.Size(55, 17);
            this.rb_tipo_3.TabIndex = 2;
            this.rb_tipo_3.TabStop = true;
            this.rb_tipo_3.Text = "Tipo 3";
            this.rb_tipo_3.UseVisualStyleBackColor = true;
            // 
            // rb_tipo_2
            // 
            this.rb_tipo_2.AutoSize = true;
            this.rb_tipo_2.Location = new System.Drawing.Point(7, 46);
            this.rb_tipo_2.Name = "rb_tipo_2";
            this.rb_tipo_2.Size = new System.Drawing.Size(55, 17);
            this.rb_tipo_2.TabIndex = 1;
            this.rb_tipo_2.TabStop = true;
            this.rb_tipo_2.Text = "Tipo 2";
            this.rb_tipo_2.UseVisualStyleBackColor = true;
            // 
            // rb_tipo_1
            // 
            this.rb_tipo_1.AutoSize = true;
            this.rb_tipo_1.Location = new System.Drawing.Point(7, 23);
            this.rb_tipo_1.Name = "rb_tipo_1";
            this.rb_tipo_1.Size = new System.Drawing.Size(55, 17);
            this.rb_tipo_1.TabIndex = 0;
            this.rb_tipo_1.TabStop = true;
            this.rb_tipo_1.Text = "Tipo 1";
            this.rb_tipo_1.UseVisualStyleBackColor = true;
            // 
            // Reconhecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reconhecimento";
            this.Text = "Reconhecimento";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_letra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_ruido;
        private System.Windows.Forms.Button bt_testar;
        private System.Windows.Forms.TextBox tb_caracter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_mostrar;
        private System.Windows.Forms.DataGridView gv_letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn um;
        private System.Windows.Forms.DataGridViewTextBoxColumn dois;
        private System.Windows.Forms.DataGridViewTextBoxColumn tres;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn seis;
        private System.Windows.Forms.DataGridViewTextBoxColumn sete;
        private System.Windows.Forms.ListBox lb_letra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_tipo_3;
        private System.Windows.Forms.RadioButton rb_tipo_2;
        private System.Windows.Forms.RadioButton rb_tipo_1;
    }
}