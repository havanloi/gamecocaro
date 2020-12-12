namespace Game_cờ_caro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlchessboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctbAvata = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLAN = new System.Windows.Forms.Button();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.pctbMark = new System.Windows.Forms.PictureBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txbPlayerName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvata)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlchessboard
            // 
            this.pnlchessboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlchessboard.BackColor = System.Drawing.SystemColors.Control;
            this.pnlchessboard.Location = new System.Drawing.Point(12, 12);
            this.pnlchessboard.Name = "pnlchessboard";
            this.pnlchessboard.Size = new System.Drawing.Size(530, 395);
            this.pnlchessboard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pctbAvata);
            this.panel2.Location = new System.Drawing.Point(545, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 1;
            // 
            // pctbAvata
            // 
            this.pctbAvata.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pctbAvata.Location = new System.Drawing.Point(0, 0);
            this.pctbAvata.Name = "pctbAvata";
            this.pctbAvata.Size = new System.Drawing.Size(200, 200);
            this.pctbAvata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbAvata.TabIndex = 0;
            this.pctbAvata.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnLAN);
            this.panel3.Controls.Add(this.txbIP);
            this.panel3.Controls.Add(this.pctbMark);
            this.panel3.Controls.Add(this.prcbCoolDown);
            this.panel3.Controls.Add(this.txbPlayerName);
            this.panel3.Location = new System.Drawing.Point(545, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 189);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line \r\n   to win";
            // 
            // btnLAN
            // 
            this.btnLAN.Location = new System.Drawing.Point(3, 84);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(100, 23);
            this.btnLAN.TabIndex = 4;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = true;
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(3, 58);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(100, 20);
            this.txbIP.TabIndex = 3;
            this.txbIP.Text = "127.0.0.1";
            // 
            // pctbMark
            // 
            this.pctbMark.BackColor = System.Drawing.SystemColors.Control;
            this.pctbMark.Location = new System.Drawing.Point(109, 3);
            this.pctbMark.Name = "pctbMark";
            this.pctbMark.Size = new System.Drawing.Size(88, 86);
            this.pctbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbMark.TabIndex = 2;
            this.pctbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.Location = new System.Drawing.Point(3, 29);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(100, 23);
            this.prcbCoolDown.TabIndex = 1;
            // 
            // txbPlayerName
            // 
            this.txbPlayerName.Location = new System.Drawing.Point(3, 3);
            this.txbPlayerName.Name = "txbPlayerName";
            this.txbPlayerName.ReadOnly = true;
            this.txbPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txbPlayerName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 409);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlchessboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Game Caro LAN";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbAvata)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlchessboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctbAvata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.PictureBox pctbMark;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.TextBox txbPlayerName;
    }
}

