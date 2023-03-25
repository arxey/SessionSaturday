namespace MegaDriveMordovskiy
{
    partial class Vehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.ComboBoxFilter = new System.Windows.Forms.ComboBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.PictureCar = new System.Windows.Forms.PictureBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.DateManufactureLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.VehicleView = new System.Windows.Forms.DataGridView();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.megaDriveMordovskiyDataSet = new MegaDriveMordovskiy.MegaDriveMordovskiyDataSet();
            this.transportTableAdapter = new MegaDriveMordovskiy.MegaDriveMordovskiyDataSetTableAdapters.transportTableAdapter();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCar)).BeginInit();
            this.PanelBottom.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaDriveMordovskiyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.PanelTop.Controls.Add(this.ComboBoxFilter);
            this.PanelTop.Controls.Add(this.TextBoxSearch);
            this.PanelTop.Controls.Add(this.LabelSearch);
            this.PanelTop.Controls.Add(this.LabelName);
            this.PanelTop.Controls.Add(this.PictureCar);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 100);
            this.PanelTop.TabIndex = 1;
            // 
            // ComboBoxFilter
            // 
            this.ComboBoxFilter.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxFilter.FormattingEnabled = true;
            this.ComboBoxFilter.Items.AddRange(new object[] {
            "Все",
            "Доступные для бронирования",
            "Недоступные",
            "Виды"});
            this.ComboBoxFilter.Location = new System.Drawing.Point(386, 50);
            this.ComboBoxFilter.Name = "ComboBoxFilter";
            this.ComboBoxFilter.Size = new System.Drawing.Size(121, 43);
            this.ComboBoxFilter.TabIndex = 4;
            this.ComboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilter_SelectedIndexChanged);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearch.Location = new System.Drawing.Point(242, 50);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(100, 40);
            this.TextBoxSearch.TabIndex = 3;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSearch.Location = new System.Drawing.Point(183, 53);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(53, 35);
            this.LabelSearch.TabIndex = 2;
            this.LabelSearch.Text = "Поиск";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(318, 9);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(159, 35);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Компания \"Мегадрайв\"";
            // 
            // PictureCar
            // 
            this.PictureCar.Image = ((System.Drawing.Image)(resources.GetObject("PictureCar.Image")));
            this.PictureCar.Location = new System.Drawing.Point(12, 3);
            this.PictureCar.Name = "PictureCar";
            this.PictureCar.Size = new System.Drawing.Size(100, 94);
            this.PictureCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCar.TabIndex = 0;
            this.PictureCar.TabStop = false;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.PanelBottom.Controls.Add(this.PanelInfo);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 335);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(800, 115);
            this.PanelBottom.TabIndex = 2;
            // 
            // PanelInfo
            // 
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelInfo.Controls.Add(this.ColorLabel);
            this.PanelInfo.Controls.Add(this.CostLabel);
            this.PanelInfo.Controls.Add(this.DateManufactureLabel);
            this.PanelInfo.Controls.Add(this.LocationLabel);
            this.PanelInfo.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PanelInfo.Location = new System.Drawing.Point(189, 3);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(417, 109);
            this.PanelInfo.TabIndex = 0;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(3, 49);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 35);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Цвет";
            this.ColorLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostLabel.Location = new System.Drawing.Point(3, 25);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(185, 35);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Стоимость аренды в сутки";
            // 
            // DateManufactureLabel
            // 
            this.DateManufactureLabel.AutoSize = true;
            this.DateManufactureLabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateManufactureLabel.Location = new System.Drawing.Point(3, 2);
            this.DateManufactureLabel.Name = "DateManufactureLabel";
            this.DateManufactureLabel.Size = new System.Drawing.Size(141, 35);
            this.DateManufactureLabel.TabIndex = 3;
            this.DateManufactureLabel.Text = "Дата производства";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationLabel.Location = new System.Drawing.Point(3, 74);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(196, 35);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Текущее место расположения";
            // 
            // VehicleView
            // 
            this.VehicleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleView.Location = new System.Drawing.Point(0, 100);
            this.VehicleView.Name = "VehicleView";
            this.VehicleView.Size = new System.Drawing.Size(800, 235);
            this.VehicleView.TabIndex = 3;
            this.VehicleView.Click += new System.EventHandler(this.VehicleView_Click);
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataMember = "transport";
            this.transportBindingSource.DataSource = this.megaDriveMordovskiyDataSet;
            // 
            // megaDriveMordovskiyDataSet
            // 
            this.megaDriveMordovskiyDataSet.DataSetName = "MegaDriveMordovskiyDataSet";
            this.megaDriveMordovskiyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportTableAdapter
            // 
            this.transportTableAdapter.ClearBeforeFill = true;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehicleView);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vehicle";
            this.Text = "Транспорт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vehicle_FormClosing);
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCar)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaDriveMordovskiyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox PictureCar;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label DateManufactureLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.DataGridView VehicleView;
        private MegaDriveMordovskiyDataSet megaDriveMordovskiyDataSet;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private MegaDriveMordovskiyDataSetTableAdapters.transportTableAdapter transportTableAdapter;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.ComboBox ComboBoxFilter;
    }
}