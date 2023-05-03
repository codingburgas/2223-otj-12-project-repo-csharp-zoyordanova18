
namespace GreenhouseManagmentSystem.Controllers
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
            this.AddButton = new System.Windows.Forms.Button();
            this.BtnDeleteGarden = new System.Windows.Forms.Button();
            this.BtnEditGarden = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BtnSearchGarden = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GardenDataGrid = new System.Windows.Forms.DataGridView();
            this.greenHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.greenhouseDataSet = new GreenhouseManagementSystemProject.GreenhouseDataSet();
            this.sensorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sensorsTableAdapter = new GreenhouseManagementSystemProject.GreenhouseDataSetTableAdapters.SensorsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GardenDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenhouseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.BtnDeleteGarden);
            this.panel1.Controls.Add(this.BtnEditGarden);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.YellowGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(12, 2);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(172, 46);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add New";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BtnDeleteGarden
            // 
            this.BtnDeleteGarden.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnDeleteGarden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteGarden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteGarden.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteGarden.Location = new System.Drawing.Point(619, 2);
            this.BtnDeleteGarden.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDeleteGarden.Name = "BtnDeleteGarden";
            this.BtnDeleteGarden.Size = new System.Drawing.Size(172, 46);
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
            this.BtnEditGarden.Location = new System.Drawing.Point(315, 2);
            this.BtnEditGarden.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEditGarden.Name = "BtnEditGarden";
            this.BtnEditGarden.Size = new System.Drawing.Size(172, 46);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 84);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.YellowGreen;
            this.panel6.Controls.Add(this.SearchBox);
            this.panel6.ForeColor = System.Drawing.SystemColors.Window;
            this.panel6.Location = new System.Drawing.Point(12, 20);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panel6.Size = new System.Drawing.Size(613, 46);
            this.panel6.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(613, 30);
            this.SearchBox.TabIndex = 0;
            // 
            // BtnSearchGarden
            // 
            this.BtnSearchGarden.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnSearchGarden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchGarden.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSearchGarden.ForeColor = System.Drawing.Color.White;
            this.BtnSearchGarden.Location = new System.Drawing.Point(628, 20);
            this.BtnSearchGarden.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearchGarden.Name = "BtnSearchGarden";
            this.BtnSearchGarden.Size = new System.Drawing.Size(163, 46);
            this.BtnSearchGarden.TabIndex = 5;
            this.BtnSearchGarden.Text = "Search";
            this.BtnSearchGarden.UseVisualStyleBackColor = false;
            this.BtnSearchGarden.Click += new System.EventHandler(this.BtnSearchGarden_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GardenDataGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 312);
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
            this.Value,
            this.Date});
            this.GardenDataGrid.DataSource = this.sensorsBindingSource;
            this.GardenDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GardenDataGrid.Location = new System.Drawing.Point(0, 0);
            this.GardenDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GardenDataGrid.Name = "GardenDataGrid";
            this.GardenDataGrid.ReadOnly = true;
            this.GardenDataGrid.RowHeadersWidth = 51;
            this.GardenDataGrid.RowTemplate.Height = 24;
            this.GardenDataGrid.Size = new System.Drawing.Size(800, 312);
            this.GardenDataGrid.TabIndex = 0;
            this.GardenDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GardenDataGrid_CellContentClick);
            // 
            // greenHouseBindingSource
            // 
            this.greenHouseBindingSource.DataSource = typeof(GreenhouseManagmentSystem.Models.GreenHouse);
            // 
            // greenhouseDataSet
            // 
            this.greenhouseDataSet.DataSetName = "GreenhouseDataSet";
            this.greenhouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sensorsBindingSource
            // 
            this.sensorsBindingSource.DataMember = "Sensors";
            this.sensorsBindingSource.DataSource = this.greenhouseDataSet;
            // 
            // sensorsTableAdapter
            // 
            this.sensorsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // GardensPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GardensPage";
            this.Text = "DataPage";
            this.Load += new System.EventHandler(this.GardensPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GardenDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenhouseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorsBindingSource)).EndInit();
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
        private System.Windows.Forms.Button AddButton;
        private GreenhouseManagementSystemProject.GreenhouseDataSet greenhouseDataSet;
        private System.Windows.Forms.BindingSource sensorsBindingSource;
        private GreenhouseManagementSystemProject.GreenhouseDataSetTableAdapters.SensorsTableAdapter sensorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}