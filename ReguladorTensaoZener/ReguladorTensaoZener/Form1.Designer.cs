namespace ReguladorTensaoZener
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btcalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtrl = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txti = new System.Windows.Forms.TextBox();
            this.txtvz = new System.Windows.Forms.TextBox();
            this.txtvi = new System.Windows.Forms.TextBox();
            this.lbli = new System.Windows.Forms.Label();
            this.lblvz = new System.Windows.Forms.Label();
            this.lblvi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblpotrl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbliz = new System.Windows.Forms.Label();
            this.lblpot = new System.Windows.Forms.Label();
            this.lblrs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btlimpar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblvo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btcalcular
            // 
            this.btcalcular.Location = new System.Drawing.Point(233, 61);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(82, 42);
            this.btcalcular.TabIndex = 0;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.btcalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtrl);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txti);
            this.groupBox1.Controls.Add(this.txtvz);
            this.groupBox1.Controls.Add(this.txtvi);
            this.groupBox1.Controls.Add(this.lbli);
            this.groupBox1.Controls.Add(this.lblvz);
            this.groupBox1.Controls.Add(this.lblvi);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "kOhms";
            // 
            // txtrl
            // 
            this.txtrl.Location = new System.Drawing.Point(47, 134);
            this.txtrl.Name = "txtrl";
            this.txtrl.Size = new System.Drawing.Size(100, 20);
            this.txtrl.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "RL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "mA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "V";
            // 
            // txti
            // 
            this.txti.Location = new System.Drawing.Point(47, 99);
            this.txti.Name = "txti";
            this.txti.Size = new System.Drawing.Size(100, 20);
            this.txti.TabIndex = 5;
            // 
            // txtvz
            // 
            this.txtvz.Location = new System.Drawing.Point(47, 62);
            this.txtvz.Name = "txtvz";
            this.txtvz.Size = new System.Drawing.Size(100, 20);
            this.txtvz.TabIndex = 4;
            // 
            // txtvi
            // 
            this.txtvi.Location = new System.Drawing.Point(47, 26);
            this.txtvi.Name = "txtvi";
            this.txtvi.Size = new System.Drawing.Size(100, 20);
            this.txtvi.TabIndex = 3;
            // 
            // lbli
            // 
            this.lbli.AutoSize = true;
            this.lbli.Location = new System.Drawing.Point(21, 102);
            this.lbli.Name = "lbli";
            this.lbli.Size = new System.Drawing.Size(10, 13);
            this.lbli.TabIndex = 2;
            this.lbli.Text = "I";
            // 
            // lblvz
            // 
            this.lblvz.AutoSize = true;
            this.lblvz.Location = new System.Drawing.Point(15, 65);
            this.lblvz.Name = "lblvz";
            this.lblvz.Size = new System.Drawing.Size(19, 13);
            this.lblvz.TabIndex = 1;
            this.lblvz.Text = "Vz";
            // 
            // lblvi
            // 
            this.lblvi.AutoSize = true;
            this.lblvi.Location = new System.Drawing.Point(15, 29);
            this.lblvi.Name = "lblvi";
            this.lblvi.Size = new System.Drawing.Size(25, 13);
            this.lblvi.TabIndex = 0;
            this.lblvi.Text = "V in";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblvo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblpotrl);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbliz);
            this.groupBox2.Controls.Add(this.lblpot);
            this.groupBox2.Controls.Add(this.lblrs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(331, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 205);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saída";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "mW";
            // 
            // lblpotrl
            // 
            this.lblpotrl.AutoSize = true;
            this.lblpotrl.Location = new System.Drawing.Point(77, 138);
            this.lblpotrl.Name = "lblpotrl";
            this.lblpotrl.Size = new System.Drawing.Size(0, 13);
            this.lblpotrl.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Pot RL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "mA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "mW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "kOhms";
            // 
            // lbliz
            // 
            this.lbliz.AutoSize = true;
            this.lbliz.Location = new System.Drawing.Point(77, 103);
            this.lbliz.Name = "lbliz";
            this.lbliz.Size = new System.Drawing.Size(0, 13);
            this.lbliz.TabIndex = 5;
            // 
            // lblpot
            // 
            this.lblpot.AutoSize = true;
            this.lblpot.Location = new System.Drawing.Point(77, 66);
            this.lblpot.Name = "lblpot";
            this.lblpot.Size = new System.Drawing.Size(0, 13);
            this.lblpot.TabIndex = 4;
            // 
            // lblrs
            // 
            this.lblrs.AutoSize = true;
            this.lblrs.Location = new System.Drawing.Point(77, 27);
            this.lblrs.Name = "lblrs";
            this.lblrs.Size = new System.Drawing.Size(0, 13);
            this.lblrs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pot Rs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(233, 144);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(82, 38);
            this.btlimpar.TabIndex = 4;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "V out";
            // 
            // lblvo
            // 
            this.lblvo.AutoSize = true;
            this.lblvo.Location = new System.Drawing.Point(77, 173);
            this.lblvo.Name = "lblvo";
            this.lblvo.Size = new System.Drawing.Size(0, 13);
            this.lblvo.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "V";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 443);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btcalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regulador Zener";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbli;
        private System.Windows.Forms.Label lblvz;
        private System.Windows.Forms.Label lblvi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txti;
        private System.Windows.Forms.TextBox txtvz;
        private System.Windows.Forms.TextBox txtvi;
        private System.Windows.Forms.Label lbliz;
        private System.Windows.Forms.Label lblpot;
        private System.Windows.Forms.Label lblrs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.TextBox txtrl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblpotrl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblvo;
        private System.Windows.Forms.Label label14;
    }
}

