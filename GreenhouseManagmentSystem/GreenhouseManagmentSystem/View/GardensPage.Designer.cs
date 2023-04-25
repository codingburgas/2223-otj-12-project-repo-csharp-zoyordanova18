
namespace GreenhouseManagmentSystem
{
    partial class GardensPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDeleteGarden = new System.Windows.Forms.Button();
            this.BtnEditGarden = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BtnSearchGarden = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GardenDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPlantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.greenHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GardenDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenHouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.BtnDeleteGarden);
            this.panel1.Controls.Add(this.BtnEditGarden);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 322);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 44);
            this.panel1.TabIndex = 0;
            // 
            // BtnDeleteGarden
            // 
            this.BtnDeleteGarden.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnDeleteGarden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteGarden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteGarden.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteGarden.Location = new System.Drawing.Point(464, 2);
            this.BtnDeleteGarden.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDeleteGarden.Name = "BtnDeleteGarden";
            this.BtnDeleteGarden.Size = new System.Drawing.Size(129, 37);
            this.BtnDeleteGarden.TabIndex = 4;
            this.BtnDeleteGarden.Text = "Delete";
            this.BtnDeleteGarden.UseVisualStyleBackColor = false;
            this.BtnDeleteGarden.Click += new System.EventHandler(this.BtnDeleteGarden_Click);
            // 
            // BtnEditGarden
            // 
            this.BtnEditGarden.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnEditGarden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditGarden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEditGarden.ForeColor = System.Drawing.Color.White;
            this.BtnEditGarden.Location = new System.Drawing.Point(236, 2);
            this.BtnEditGarden.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEditGarden.Name = "BtnEditGarden";
            this.BtnEditGarden.Size = new System.Drawing.Size(129, 37);
            this.BtnEditGarden.TabIndex = 3;
            this.BtnEditGarden.Text = "Edit";
            this.BtnEditGarden.UseVisualStyleBackColor = false;
            this.BtnEditGarden.Click += new System.EventHandler(this.BtnEditGarden_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.BtnSearchGarden);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 68);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.YellowGreen;
            this.panel6.Controls.Add(this.SearchBox);
            this.panel6.ForeColor = System.Drawing.SystemColors.Window;
            this.panel6.Location = new System.Drawing.Point(9, 16);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel6.Size = new System.Drawing.Size(460, 37);
            this.panel6.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(460, 26);
            this.SearchBox.TabIndex = 0;
            // 
            // BtnSearchGarden
            // 
            this.BtnSearchGarden.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnSearchGarden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchGarden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSearchGarden.ForeColor = System.Drawing.Color.White;
            this.BtnSearchGarden.Location = new System.Drawing.Point(471, 16);
            this.BtnSearchGarden.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearchGarden.Name = "BtnSearchGarden";
            this.BtnSearchGarden.Size = new System.Drawing.Size(122, 37);
            this.BtnSearchGarden.TabIndex = 5;
            this.BtnSearchGarden.Text = "Search";
            this.BtnSearchGarden.UseVisualStyleBackColor = false;
            this.BtnSearchGarden.Click += new System.EventHandler(this.BtnSearchGarden_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GardenDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 254);
            this.panel3.TabIndex = 2;
            // 
            // GardenDataGrid
            // 
            this.GardenDataGrid.AllowUserToAddRows = false;
            this.GardenDataGrid.AllowUserToDeleteRows = false;
            this.GardenDataGrid.AutoGenerateColumns = false;
            this.GardenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GardenDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.numberOfPlantsDataGridViewTextBoxColumn});
            this.GardenDataGrid.DataSource = this.greenHouseBindingSource;
            this.GardenDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GardenDataGrid.Location = new System.Drawing.Point(0, 0);
            this.GardenDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.GardenDataGrid.Name = "GardenDataGrid";
            this.GardenDataGrid.ReadOnly = true;
            this.GardenDataGrid.RowHeadersWidth = 51;
            this.GardenDataGrid.RowTemplate.Height = 24;
            this.GardenDataGrid.Size = new System.Drawing.Size(600, 254);
            this.GardenDataGrid.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfPlantsDataGridViewTextBoxColumn
            // 
            this.numberOfPlantsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfPlantsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfPlants";
            this.numberOfPlantsDataGridViewTextBoxColumn.HeaderText = "Number of plants";
            this.numberOfPlantsDataGridViewTextBoxColumn.Name = "numberOfPlantsDataGridViewTextBoxColumn";
            this.numberOfPlantsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // greenHouseBindingSource
            // 
            this.greenHouseBindingSource.DataSource = typeof(GreenhouseManagmentSystem.Models.GreenHouse);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(9, 2);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 37);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add New";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // GardensPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GardensPage";
            this.Text = "DataPage";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GardenDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenHouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnDeleteGarden;
        private System.Windows.Forms.Button BtnEditGarden;
        private System.Windows.Forms.Button BtnSearchGarden;
        private System.Windows.Forms.DataGridView GardenDataGrid;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.BindingSource greenHouseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPlantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddButton;
    }
}