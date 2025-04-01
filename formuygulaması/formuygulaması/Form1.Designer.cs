namespace formuygulaması
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            txtKapiSayisi = new TextBox();
            txtPencereSayisi = new TextBox();
            txtYakitTuketimi = new TextBox();
            btnBilgileriGoster = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 19);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Marka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 73);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Model:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 117);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Renk:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 168);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Kapı Sayısı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 223);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "Pencere Sayısı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 272);
            label6.Name = "label6";
            label6.Size = new Size(206, 20);
            label6.TabIndex = 5;
            label6.Text = "100 km’de Yaktığı Yakıt (Litre):";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(278, 19);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 6;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(278, 66);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 7;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(278, 114);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(125, 27);
            txtRenk.TabIndex = 8;
            // 
            // txtKapiSayisi
            // 
            txtKapiSayisi.Location = new Point(278, 168);
            txtKapiSayisi.Name = "txtKapiSayisi";
            txtKapiSayisi.Size = new Size(125, 27);
            txtKapiSayisi.TabIndex = 9;
            // 
            // txtPencereSayisi
            // 
            txtPencereSayisi.Location = new Point(278, 220);
            txtPencereSayisi.Name = "txtPencereSayisi";
            txtPencereSayisi.Size = new Size(125, 27);
            txtPencereSayisi.TabIndex = 10;
            // 
            // txtYakitTuketimi
            // 
            txtYakitTuketimi.Location = new Point(278, 272);
            txtYakitTuketimi.Name = "txtYakitTuketimi";
            txtYakitTuketimi.Size = new Size(125, 27);
            txtYakitTuketimi.TabIndex = 11;
            // 
            // btnBilgileriGoster
            // 
            btnBilgileriGoster.Location = new Point(158, 346);
            btnBilgileriGoster.Name = "btnBilgileriGoster";
            btnBilgileriGoster.Size = new Size(175, 29);
            btnBilgileriGoster.TabIndex = 12;
            btnBilgileriGoster.Text = "Bilgileri Göster";
            btnBilgileriGoster.UseVisualStyleBackColor = true;
            btnBilgileriGoster.Click += btnBilgileriGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBilgileriGoster);
            Controls.Add(txtYakitTuketimi);
            Controls.Add(txtPencereSayisi);
            Controls.Add(txtKapiSayisi);
            Controls.Add(txtRenk);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtRenk;
        private TextBox txtKapiSayisi;
        private TextBox txtPencereSayisi;
        private TextBox txtYakitTuketimi;
        private Button btnBilgileriGoster;
    }
}
