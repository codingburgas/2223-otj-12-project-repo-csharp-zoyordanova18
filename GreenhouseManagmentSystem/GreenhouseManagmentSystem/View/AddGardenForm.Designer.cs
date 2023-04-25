
namespace GreenhouseManagmentSystem
{
    partial class AddGardenPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGardenPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAddGarden = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ShowGardensBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAddGarden
            // 
            this.BtnAddGarden.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnAddGarden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddGarden.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddGarden.ForeColor = System.Drawing.Color.White;
            this.BtnAddGarden.Location = new System.Drawing.Point(9, 13);
            this.BtnAddGarden.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddGarden.Name = "BtnAddGarden";
            this.BtnAddGarden.Size = new System.Drawing.Size(172, 89);
            this.BtnAddGarden.TabIndex = 0;
            this.BtnAddGarden.Text = "Add Garden";
            this.BtnAddGarden.UseVisualStyleBackColor = false;
            this.BtnAddGarden.Click += new System.EventHandler(this.BtnAddGarden_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAddGarden);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 400);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ShowGardensBtn);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(189, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 400);
            this.panel3.TabIndex = 3;
            // 
            // ShowGardensBtn
            // 
            this.ShowGardensBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.ShowGardensBtn.Enabled = false;
            this.ShowGardensBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowGardensBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowGardensBtn.ForeColor = System.Drawing.Color.White;
            this.ShowGardensBtn.Location = new System.Drawing.Point(311, 291);
            this.ShowGardensBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ShowGardensBtn.Name = "ShowGardensBtn";
            this.ShowGardensBtn.Size = new System.Drawing.Size(172, 89);
            this.ShowGardensBtn.TabIndex = 1;
            this.ShowGardensBtn.Text = "Show my gardens";
            this.ShowGardensBtn.UseVisualStyleBackColor = false;
            this.ShowGardensBtn.Click += new System.EventHandler(this.ShowGardensBtn_Click);
            // 
            // AddGardenPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddGardenPage";
            this.RightToLeftLayout = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAddGarden;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ShowGardensBtn;
    }
}