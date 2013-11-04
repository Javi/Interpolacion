namespace Interpolacion
{
    partial class FormIngresar
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPares = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProgresivo = new System.Windows.Forms.Label();
            this.lblRegresivo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPares)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPares
            // 
            this.dgvPares.AllowUserToAddRows = false;
            this.dgvPares.AllowUserToDeleteRows = false;
            this.dgvPares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPares.Location = new System.Drawing.Point(12, 67);
            this.dgvPares.Name = "dgvPares";
            this.dgvPares.ReadOnly = true;
            this.dgvPares.Size = new System.Drawing.Size(218, 270);
            this.dgvPares.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(30, 13);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(119, 20);
            this.txtX.TabIndex = 6;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(30, 36);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(119, 20);
            this.txtY.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(127, 343);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular Polinomio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(3, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(108, 13);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Polinomio Progresivo:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(3, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(106, 13);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "Polinomio Regresivo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProgresivo);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Location = new System.Drawing.Point(242, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 178);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRegresivo);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Location = new System.Drawing.Point(242, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 164);
            this.panel2.TabIndex = 12;
            // 
            // lblProgresivo
            // 
            this.lblProgresivo.AutoSize = true;
            this.lblProgresivo.Location = new System.Drawing.Point(6, 22);
            this.lblProgresivo.Name = "lblProgresivo";
            this.lblProgresivo.Size = new System.Drawing.Size(22, 13);
            this.lblProgresivo.TabIndex = 10;
            this.lblProgresivo.Text = "-----";
            // 
            // lblRegresivo
            // 
            this.lblRegresivo.AutoSize = true;
            this.lblRegresivo.Location = new System.Drawing.Point(6, 24);
            this.lblRegresivo.Name = "lblRegresivo";
            this.lblRegresivo.Size = new System.Drawing.Size(22, 13);
            this.lblRegresivo.TabIndex = 11;
            this.lblRegresivo.Text = "-----";
            // 
            // FormIngresar
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPares);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormIngresar";
            this.Text = "Interpolación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPares)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProgresivo;
        private System.Windows.Forms.Label lblRegresivo;
    }
}

