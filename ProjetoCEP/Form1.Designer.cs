namespace ProjetoCEP
{
    partial class frmCEP
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
            this.labelCEP = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.labelComplemento2 = new System.Windows.Forms.Label();
            this.txtComp2 = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.labelBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.Location = new System.Drawing.Point(15, 56);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(42, 18);
            this.labelCEP.TabIndex = 0;
            this.labelCEP.Text = "CEP";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Location = new System.Drawing.Point(114, 56);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(228, 20);
            this.mtbCEP.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(377, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(15, 91);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(80, 18);
            this.labelEndereco.TabIndex = 3;
            this.labelEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(114, 91);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(228, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplemento.Location = new System.Drawing.Point(15, 166);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(113, 18);
            this.labelComplemento.TabIndex = 5;
            this.labelComplemento.Text = "Complemento";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(134, 167);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(208, 20);
            this.txtComp.TabIndex = 6;
            // 
            // labelComplemento2
            // 
            this.labelComplemento2.AutoSize = true;
            this.labelComplemento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplemento2.Location = new System.Drawing.Point(15, 205);
            this.labelComplemento2.Name = "labelComplemento2";
            this.labelComplemento2.Size = new System.Drawing.Size(127, 18);
            this.labelComplemento2.TabIndex = 7;
            this.labelComplemento2.Text = "Complemento 2";
            // 
            // txtComp2
            // 
            this.txtComp2.Location = new System.Drawing.Point(157, 203);
            this.txtComp2.Name = "txtComp2";
            this.txtComp2.Size = new System.Drawing.Size(185, 20);
            this.txtComp2.TabIndex = 8;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.Location = new System.Drawing.Point(15, 240);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(60, 18);
            this.labelCidade.TabIndex = 9;
            this.labelCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(114, 240);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(228, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(15, 279);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(61, 18);
            this.labelEstado.TabIndex = 11;
            this.labelEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(114, 271);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(228, 20);
            this.txtEstado.TabIndex = 12;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(377, 97);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.Location = new System.Drawing.Point(18, 131);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(54, 18);
            this.labelBairro.TabIndex = 14;
            this.labelBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(114, 128);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(228, 20);
            this.txtBairro.TabIndex = 15;
            // 
            // frmCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 310);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.txtComp2);
            this.Controls.Add(this.labelComplemento2);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.labelCEP);
            this.Name = "frmCEP";
            this.Text = "Busca CEP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label labelComplemento2;
        private System.Windows.Forms.TextBox txtComp2;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox txtBairro;
    }
}

