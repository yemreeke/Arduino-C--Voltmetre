
namespace VoltMetre
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaglantiKes = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxVoltaj = new System.Windows.Forms.TextBox();
            this.btnTestDurdur = new System.Windows.Forms.Button();
            this.btnTestBaslat = new System.Windows.Forms.Button();
            this.timerVeriOku = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxPort
            // 
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Location = new System.Drawing.Point(199, 38);
            this.cboxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.Size = new System.Drawing.Size(160, 33);
            this.cboxPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seri Port";
            // 
            // cboxBaudRate
            // 
            this.cboxBaudRate.FormattingEnabled = true;
            this.cboxBaudRate.Location = new System.Drawing.Point(199, 86);
            this.cboxBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxBaudRate.Name = "cboxBaudRate";
            this.cboxBaudRate.Size = new System.Drawing.Size(160, 33);
            this.cboxBaudRate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBaglantiKes);
            this.groupBox1.Controls.Add(this.btnBaglan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxPort);
            this.groupBox1.Controls.Add(this.cboxBaudRate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(385, 267);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seri Port Ayarları";
            // 
            // btnBaglantiKes
            // 
            this.btnBaglantiKes.Enabled = false;
            this.btnBaglantiKes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglantiKes.Location = new System.Drawing.Point(24, 198);
            this.btnBaglantiKes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaglantiKes.Name = "btnBaglantiKes";
            this.btnBaglantiKes.Size = new System.Drawing.Size(336, 58);
            this.btnBaglantiKes.TabIndex = 5;
            this.btnBaglantiKes.Text = "Bağlantıyı Kes";
            this.btnBaglantiKes.UseVisualStyleBackColor = true;
            this.btnBaglantiKes.Click += new System.EventHandler(this.btnBaglantiKes_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(24, 133);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(336, 58);
            this.btnBaglan.TabIndex = 4;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tboxVoltaj);
            this.groupBox2.Controls.Add(this.btnTestDurdur);
            this.groupBox2.Controls.Add(this.btnTestBaslat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(435, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(475, 267);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Batarya Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(268, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 76);
            this.label3.TabIndex = 6;
            this.label3.Text = "Volt";
            // 
            // tboxVoltaj
            // 
            this.tboxVoltaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tboxVoltaj.Location = new System.Drawing.Point(12, 44);
            this.tboxVoltaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxVoltaj.Name = "tboxVoltaj";
            this.tboxVoltaj.ReadOnly = true;
            this.tboxVoltaj.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tboxVoltaj.Size = new System.Drawing.Size(247, 82);
            this.tboxVoltaj.TabIndex = 6;
            this.tboxVoltaj.Text = "0.000";
            // 
            // btnTestDurdur
            // 
            this.btnTestDurdur.Enabled = false;
            this.btnTestDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestDurdur.Location = new System.Drawing.Point(239, 162);
            this.btnTestDurdur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestDurdur.Name = "btnTestDurdur";
            this.btnTestDurdur.Size = new System.Drawing.Size(219, 86);
            this.btnTestDurdur.TabIndex = 5;
            this.btnTestDurdur.Text = "Test Durdur";
            this.btnTestDurdur.UseVisualStyleBackColor = true;
            this.btnTestDurdur.Click += new System.EventHandler(this.btnTestDurdur_Click);
            // 
            // btnTestBaslat
            // 
            this.btnTestBaslat.Enabled = false;
            this.btnTestBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestBaslat.Location = new System.Drawing.Point(12, 162);
            this.btnTestBaslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestBaslat.Name = "btnTestBaslat";
            this.btnTestBaslat.Size = new System.Drawing.Size(219, 86);
            this.btnTestBaslat.TabIndex = 4;
            this.btnTestBaslat.Text = "Test Başlat";
            this.btnTestBaslat.UseVisualStyleBackColor = true;
            this.btnTestBaslat.Click += new System.EventHandler(this.btnTestBaslat_Click);
            // 
            // timerVeriOku
            // 
            this.timerVeriOku.Tick += new System.EventHandler(this.timerVeriOku_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 295);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Volt Metre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBaglantiKes;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxVoltaj;
        private System.Windows.Forms.Button btnTestDurdur;
        private System.Windows.Forms.Button btnTestBaslat;
        private System.Windows.Forms.Timer timerVeriOku;
    }
}

