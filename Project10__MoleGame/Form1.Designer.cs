namespace Project10__MoleGame
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbMole = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblScore);
            this.panel2.Controls.Add(this.pbMole);
            this.panel2.Controls.Add(this.pb2);
            this.panel2.Controls.Add(this.pb4);
            this.panel2.Controls.Add(this.pb5);
            this.panel2.Controls.Add(this.pb3);
            this.panel2.Controls.Add(this.pb1);
            this.panel2.Controls.Add(this.pb6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 600);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(944, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Kristen ITC", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(22, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(141, 36);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score : 0";
            // 
            // pbMole
            // 
            this.pbMole.BackColor = System.Drawing.Color.Transparent;
            this.pbMole.Image = ((System.Drawing.Image)(resources.GetObject("pbMole.Image")));
            this.pbMole.Location = new System.Drawing.Point(370, 160);
            this.pbMole.Margin = new System.Windows.Forms.Padding(0);
            this.pbMole.Name = "pbMole";
            this.pbMole.ShadowDecoration.Parent = this.pbMole;
            this.pbMole.Size = new System.Drawing.Size(180, 129);
            this.pbMole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMole.TabIndex = 1;
            this.pbMole.TabStop = false;
            this.pbMole.Click += new System.EventHandler(this.pbMole_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(370, 160);
            this.pb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb2.Name = "pb2";
            this.pb2.ShadowDecoration.Parent = this.pb2;
            this.pb2.Size = new System.Drawing.Size(180, 129);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(110, 330);
            this.pb4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb4.Name = "pb4";
            this.pb4.ShadowDecoration.Parent = this.pb4;
            this.pb4.Size = new System.Drawing.Size(180, 129);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 1;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Transparent;
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(420, 410);
            this.pb5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb5.Name = "pb5";
            this.pb5.ShadowDecoration.Parent = this.pb5;
            this.pb5.Size = new System.Drawing.Size(180, 129);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 1;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(670, 125);
            this.pb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb3.Name = "pb3";
            this.pb3.ShadowDecoration.Parent = this.pb3;
            this.pb3.Size = new System.Drawing.Size(180, 129);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(70, 160);
            this.pb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb1.Name = "pb1";
            this.pb1.ShadowDecoration.Parent = this.pb1;
            this.pb1.Size = new System.Drawing.Size(180, 129);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.Image = ((System.Drawing.Image)(resources.GetObject("pb6.Image")));
            this.pb6.Location = new System.Drawing.Point(740, 340);
            this.pb6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb6.Name = "pb6";
            this.pb6.ShadowDecoration.Parent = this.pb6;
            this.pb6.Size = new System.Drawing.Size(180, 129);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 1;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pbMole;
        private Guna.UI2.WinForms.Guna2PictureBox pb2;
        private Guna.UI2.WinForms.Guna2PictureBox pb4;
        private Guna.UI2.WinForms.Guna2PictureBox pb5;
        private Guna.UI2.WinForms.Guna2PictureBox pb3;
        private Guna.UI2.WinForms.Guna2PictureBox pb1;
        private Guna.UI2.WinForms.Guna2PictureBox pb6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
    }
}

