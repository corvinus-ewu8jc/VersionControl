
namespace ExcelExport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.realEstateDataSet = new ExcelExport.RealEstateDataSet();
            this.flatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flatTableAdapter = new ExcelExport.RealEstateDataSetTableAdapters.FlatTableAdapter();
            this.flatSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevatorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numberOfRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flatSKDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.vendorDataGridViewTextBoxColumn,
            this.sideDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.elevatorDataGridViewCheckBoxColumn,
            this.numberOfRoomsDataGridViewTextBoxColumn,
            this.floorAreaDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // realEstateDataSet
            // 
            this.realEstateDataSet.DataSetName = "RealEstateDataSet";
            this.realEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flatBindingSource
            // 
            this.flatBindingSource.DataMember = "Flat";
            this.flatBindingSource.DataSource = this.realEstateDataSet;
            // 
            // flatTableAdapter
            // 
            this.flatTableAdapter.ClearBeforeFill = true;
            // 
            // flatSKDataGridViewTextBoxColumn
            // 
            this.flatSKDataGridViewTextBoxColumn.DataPropertyName = "FlatSK";
            this.flatSKDataGridViewTextBoxColumn.HeaderText = "FlatSK";
            this.flatSKDataGridViewTextBoxColumn.Name = "flatSKDataGridViewTextBoxColumn";
            this.flatSKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // vendorDataGridViewTextBoxColumn
            // 
            this.vendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor";
            this.vendorDataGridViewTextBoxColumn.HeaderText = "Vendor";
            this.vendorDataGridViewTextBoxColumn.Name = "vendorDataGridViewTextBoxColumn";
            // 
            // sideDataGridViewTextBoxColumn
            // 
            this.sideDataGridViewTextBoxColumn.DataPropertyName = "Side";
            this.sideDataGridViewTextBoxColumn.HeaderText = "Side";
            this.sideDataGridViewTextBoxColumn.Name = "sideDataGridViewTextBoxColumn";
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            // 
            // elevatorDataGridViewCheckBoxColumn
            // 
            this.elevatorDataGridViewCheckBoxColumn.DataPropertyName = "Elevator";
            this.elevatorDataGridViewCheckBoxColumn.HeaderText = "Elevator";
            this.elevatorDataGridViewCheckBoxColumn.Name = "elevatorDataGridViewCheckBoxColumn";
            // 
            // numberOfRoomsDataGridViewTextBoxColumn
            // 
            this.numberOfRoomsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.HeaderText = "NumberOfRooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.Name = "numberOfRoomsDataGridViewTextBoxColumn";
            // 
            // floorAreaDataGridViewTextBoxColumn
            // 
            this.floorAreaDataGridViewTextBoxColumn.DataPropertyName = "FloorArea";
            this.floorAreaDataGridViewTextBoxColumn.HeaderText = "FloorArea";
            this.floorAreaDataGridViewTextBoxColumn.Name = "floorAreaDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RealEstateDataSet realEstateDataSet;
        private System.Windows.Forms.BindingSource flatBindingSource;
        private RealEstateDataSetTableAdapters.FlatTableAdapter flatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn elevatorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

