namespace _5._1T
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblQeyd = new Label();
            lblAxtaris = new Label();
            txtQeyd = new TextBox();
            txtAxtaris = new TextBox();
            btnElaveEt = new Button();
            btnAxtar = new Button();
            btnGoster = new Button();
            btnSil = new Button();
            btnCixis = new Button();
            lstQeydler = new ListBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(330, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(86, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Qeydler Defteri";
            // 
            // lblQeyd
            // 
            lblQeyd.AutoSize = true;
            lblQeyd.Location = new Point(12, 40);
            lblQeyd.Name = "lblQeyd";
            lblQeyd.Size = new Size(60, 15);
            lblQeyd.TabIndex = 1;
            lblQeyd.Text = "Yeni Qeyd";
            // 
            // lblAxtaris
            // 
            lblAxtaris.AutoSize = true;
            lblAxtaris.Location = new Point(12, 137);
            lblAxtaris.Name = "lblAxtaris";
            lblAxtaris.Size = new Size(71, 15);
            lblAxtaris.TabIndex = 2;
            lblAxtaris.Text = "Axtaris Sozu";
            // 
            // txtQeyd
            // 
            txtQeyd.Location = new Point(12, 58);
            txtQeyd.Name = "txtQeyd";
            txtQeyd.Size = new Size(776, 23);
            txtQeyd.TabIndex = 3;
            // 
            // txtAxtaris
            // 
            txtAxtaris.Location = new Point(12, 156);
            txtAxtaris.Name = "txtAxtaris";
            txtAxtaris.Size = new Size(776, 23);
            txtAxtaris.TabIndex = 4;
            // 
            // btnElaveEt
            // 
            btnElaveEt.Location = new Point(12, 87);
            btnElaveEt.Name = "btnElaveEt";
            btnElaveEt.Size = new Size(776, 32);
            btnElaveEt.TabIndex = 5;
            btnElaveEt.Text = "Qeyd Elave Et";
            btnElaveEt.UseVisualStyleBackColor = true;
            // 
            // btnAxtar
            // 
            btnAxtar.Location = new Point(12, 185);
            btnAxtar.Name = "btnAxtar";
            btnAxtar.Size = new Size(358, 32);
            btnAxtar.TabIndex = 6;
            btnAxtar.Text = "Axtar";
            btnAxtar.UseVisualStyleBackColor = true;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(376, 185);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(412, 32);
            btnGoster.TabIndex = 7;
            btnGoster.Text = "Butun Qeydler";
            btnGoster.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(12, 337);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(776, 32);
            btnSil.TabIndex = 8;
            btnSil.Text = "Butun Qeydleri Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnCixis
            // 
            btnCixis.Location = new Point(12, 375);
            btnCixis.Name = "btnCixis";
            btnCixis.Size = new Size(776, 32);
            btnCixis.TabIndex = 9;
            btnCixis.Text = "Cixis";
            btnCixis.UseVisualStyleBackColor = true;
            // 
            // lstQeydler
            // 
            lstQeydler.FormattingEnabled = true;
            lstQeydler.Location = new Point(12, 237);
            lstQeydler.Name = "lstQeydler";
            lstQeydler.Size = new Size(776, 94);
            lstQeydler.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 561);
            Controls.Add(lstQeydler);
            Controls.Add(btnCixis);
            Controls.Add(btnSil);
            Controls.Add(btnGoster);
            Controls.Add(btnAxtar);
            Controls.Add(btnElaveEt);
            Controls.Add(txtAxtaris);
            Controls.Add(txtQeyd);
            Controls.Add(lblAxtaris);
            Controls.Add(lblQeyd);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Qeydler Defteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQeyd;
        private Label lblAxtaris;
        private TextBox txtQeyd;
        private TextBox txtAxtaris;
        private Button btnElaveEt;
        private Button btnAxtar;
        private Button btnGoster;
        private Button btnSil;
        private Button btnCixis;
        private ListBox lstQeydler;
    }
}
