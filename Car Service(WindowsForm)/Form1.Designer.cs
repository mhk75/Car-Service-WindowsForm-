
namespace Car_Service_WindowsForm_
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
            this.btnShowData = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbVaskazin = new System.Windows.Forms.ComboBox();
            this.ShowOilData = new System.Windows.Forms.Button();
            this.btnNewService = new System.Windows.Forms.Button();
            this.txbCarTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbKilometrfeli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbKilometrbadi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTarikh = new System.Windows.Forms.TextBox();
            this.chbFilterHava = new System.Windows.Forms.CheckBox();
            this.chbFilterRoghan = new System.Windows.Forms.CheckBox();
            this.chbFliterCabin = new System.Windows.Forms.CheckBox();
            this.chbSafiBenzin = new System.Windows.Forms.CheckBox();
            this.cmbRoghan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCarTagNew = new System.Windows.Forms.TextBox();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCarName = new System.Windows.Forms.TextBox();
            this.txbCarModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbOwner = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbOilType = new System.Windows.Forms.TextBox();
            this.txbOilName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbOilID = new System.Windows.Forms.TextBox();
            this.lable13 = new System.Windows.Forms.Label();
            this.btnNewOil = new System.Windows.Forms.Button();
            this.btnRemoveOil = new System.Windows.Forms.Button();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(9, 10);
            this.btnShowData.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(93, 35);
            this.btnShowData.TabIndex = 0;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // txbResult
            // 
            this.txbResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbResult.Location = new System.Drawing.Point(9, 155);
            this.txbResult.Margin = new System.Windows.Forms.Padding(2);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResult.Size = new System.Drawing.Size(1043, 23);
            this.txbResult.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 182);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1042, 297);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbVaskazin
            // 
            this.cmbVaskazin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVaskazin.FormattingEnabled = true;
            this.cmbVaskazin.Location = new System.Drawing.Point(518, 84);
            this.cmbVaskazin.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVaskazin.Name = "cmbVaskazin";
            this.cmbVaskazin.Size = new System.Drawing.Size(92, 21);
            this.cmbVaskazin.TabIndex = 4;
            this.cmbVaskazin.SelectedIndexChanged += new System.EventHandler(this.cmbVaskazin_SelectedIndexChanged);
            // 
            // ShowOilData
            // 
            this.ShowOilData.Location = new System.Drawing.Point(107, 10);
            this.ShowOilData.Name = "ShowOilData";
            this.ShowOilData.Size = new System.Drawing.Size(97, 35);
            this.ShowOilData.TabIndex = 5;
            this.ShowOilData.Text = "ShowOilData";
            this.ShowOilData.UseVisualStyleBackColor = true;
            this.ShowOilData.Click += new System.EventHandler(this.ShowOilData_Click);
            // 
            // btnNewService
            // 
            this.btnNewService.Location = new System.Drawing.Point(210, 10);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(107, 35);
            this.btnNewService.TabIndex = 6;
            this.btnNewService.Text = "New Service";
            this.btnNewService.UseVisualStyleBackColor = true;
            this.btnNewService.Click += new System.EventHandler(this.btnNewService_Click);
            // 
            // txbCarTag
            // 
            this.txbCarTag.Location = new System.Drawing.Point(92, 58);
            this.txbCarTag.Name = "txbCarTag";
            this.txbCarTag.ReadOnly = true;
            this.txbCarTag.Size = new System.Drawing.Size(100, 20);
            this.txbCarTag.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CarTag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "KiloMetrFeli:";
            // 
            // txbKilometrfeli
            // 
            this.txbKilometrfeli.Location = new System.Drawing.Point(92, 84);
            this.txbKilometrfeli.Name = "txbKilometrfeli";
            this.txbKilometrfeli.Size = new System.Drawing.Size(100, 20);
            this.txbKilometrfeli.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "KiloMetrBadi:";
            // 
            // txbKilometrbadi
            // 
            this.txbKilometrbadi.Location = new System.Drawing.Point(92, 110);
            this.txbKilometrbadi.Name = "txbKilometrbadi";
            this.txbKilometrbadi.Size = new System.Drawing.Size(100, 20);
            this.txbKilometrbadi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tarikh:";
            // 
            // txbTarikh
            // 
            this.txbTarikh.Location = new System.Drawing.Point(518, 110);
            this.txbTarikh.Name = "txbTarikh";
            this.txbTarikh.Size = new System.Drawing.Size(92, 20);
            this.txbTarikh.TabIndex = 13;
            // 
            // chbFilterHava
            // 
            this.chbFilterHava.AutoSize = true;
            this.chbFilterHava.Location = new System.Drawing.Point(210, 87);
            this.chbFilterHava.Name = "chbFilterHava";
            this.chbFilterHava.Size = new System.Drawing.Size(100, 17);
            this.chbFilterHava.TabIndex = 15;
            this.chbFilterHava.Text = "TavizFilterHava";
            this.chbFilterHava.UseVisualStyleBackColor = true;
            // 
            // chbFilterRoghan
            // 
            this.chbFilterRoghan.AutoSize = true;
            this.chbFilterRoghan.Location = new System.Drawing.Point(316, 88);
            this.chbFilterRoghan.Name = "chbFilterRoghan";
            this.chbFilterRoghan.Size = new System.Drawing.Size(112, 17);
            this.chbFilterRoghan.TabIndex = 16;
            this.chbFilterRoghan.Text = "TavizFilterRoghan";
            this.chbFilterRoghan.UseVisualStyleBackColor = true;
            // 
            // chbFliterCabin
            // 
            this.chbFliterCabin.AutoSize = true;
            this.chbFliterCabin.Location = new System.Drawing.Point(210, 113);
            this.chbFliterCabin.Name = "chbFliterCabin";
            this.chbFliterCabin.Size = new System.Drawing.Size(101, 17);
            this.chbFliterCabin.TabIndex = 17;
            this.chbFliterCabin.Text = "TavizFilterCabin";
            this.chbFliterCabin.UseVisualStyleBackColor = true;
            // 
            // chbSafiBenzin
            // 
            this.chbSafiBenzin.AutoSize = true;
            this.chbSafiBenzin.Location = new System.Drawing.Point(316, 113);
            this.chbSafiBenzin.Name = "chbSafiBenzin";
            this.chbSafiBenzin.Size = new System.Drawing.Size(102, 17);
            this.chbSafiBenzin.TabIndex = 18;
            this.chbSafiBenzin.Text = "TavizSafiBenzin";
            this.chbSafiBenzin.UseVisualStyleBackColor = true;
            // 
            // cmbRoghan
            // 
            this.cmbRoghan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoghan.FormattingEnabled = true;
            this.cmbRoghan.Location = new System.Drawing.Point(518, 58);
            this.cmbRoghan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoghan.Name = "cmbRoghan";
            this.cmbRoghan.Size = new System.Drawing.Size(92, 21);
            this.cmbRoghan.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "OilType:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Vaskazin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "NewCarTag:";
            // 
            // txbCarTagNew
            // 
            this.txbCarTagNew.Location = new System.Drawing.Point(280, 59);
            this.txbCarTagNew.Name = "txbCarTagNew";
            this.txbCarTagNew.Size = new System.Drawing.Size(100, 20);
            this.txbCarTagNew.TabIndex = 22;
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(323, 10);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(102, 35);
            this.btnNewCar.TabIndex = 24;
            this.btnNewCar.Text = "New Car";
            this.btnNewCar.UseVisualStyleBackColor = true;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "CarName:";
            // 
            // txbCarName
            // 
            this.txbCarName.Location = new System.Drawing.Point(684, 59);
            this.txbCarName.Name = "txbCarName";
            this.txbCarName.Size = new System.Drawing.Size(100, 20);
            this.txbCarName.TabIndex = 26;
            // 
            // txbCarModel
            // 
            this.txbCarModel.Location = new System.Drawing.Point(684, 81);
            this.txbCarModel.Name = "txbCarModel";
            this.txbCarModel.Size = new System.Drawing.Size(100, 20);
            this.txbCarModel.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(629, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Model:";
            // 
            // txbOwner
            // 
            this.txbOwner.Location = new System.Drawing.Point(684, 103);
            this.txbOwner.Name = "txbOwner";
            this.txbOwner.Size = new System.Drawing.Size(100, 20);
            this.txbOwner.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Owner:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(813, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "OilType:";
            // 
            // txbOilType
            // 
            this.txbOilType.Location = new System.Drawing.Point(875, 58);
            this.txbOilType.Name = "txbOilType";
            this.txbOilType.Size = new System.Drawing.Size(100, 20);
            this.txbOilType.TabIndex = 32;
            // 
            // txbOilName
            // 
            this.txbOilName.Location = new System.Drawing.Point(875, 81);
            this.txbOilName.Name = "txbOilName";
            this.txbOilName.Size = new System.Drawing.Size(100, 20);
            this.txbOilName.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(813, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "OilName:";
            // 
            // txbOilID
            // 
            this.txbOilID.Location = new System.Drawing.Point(875, 103);
            this.txbOilID.Name = "txbOilID";
            this.txbOilID.ReadOnly = true;
            this.txbOilID.Size = new System.Drawing.Size(100, 20);
            this.txbOilID.TabIndex = 36;
            // 
            // lable13
            // 
            this.lable13.AutoSize = true;
            this.lable13.Location = new System.Drawing.Point(813, 106);
            this.lable13.Name = "lable13";
            this.lable13.Size = new System.Drawing.Size(33, 13);
            this.lable13.TabIndex = 35;
            this.lable13.Text = "OilID:";
            // 
            // btnNewOil
            // 
            this.btnNewOil.Location = new System.Drawing.Point(434, 10);
            this.btnNewOil.Name = "btnNewOil";
            this.btnNewOil.Size = new System.Drawing.Size(95, 35);
            this.btnNewOil.TabIndex = 37;
            this.btnNewOil.Text = "New Oil";
            this.btnNewOil.UseVisualStyleBackColor = true;
            this.btnNewOil.Click += new System.EventHandler(this.btnNewOil_Click);
            // 
            // btnRemoveOil
            // 
            this.btnRemoveOil.Location = new System.Drawing.Point(535, 10);
            this.btnRemoveOil.Name = "btnRemoveOil";
            this.btnRemoveOil.Size = new System.Drawing.Size(91, 35);
            this.btnRemoveOil.TabIndex = 38;
            this.btnRemoveOil.Text = "Remove Oil";
            this.btnRemoveOil.UseVisualStyleBackColor = true;
            this.btnRemoveOil.Click += new System.EventHandler(this.btnRemoveOil_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Location = new System.Drawing.Point(632, 10);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(87, 35);
            this.btnRemoveCar.TabIndex = 39;
            this.btnRemoveCar.Text = "Remove Car";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 489);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnRemoveOil);
            this.Controls.Add(this.btnNewOil);
            this.Controls.Add(this.txbOilID);
            this.Controls.Add(this.lable13);
            this.Controls.Add(this.txbOilName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txbOilType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbOwner);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbCarModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbCarName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNewCar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbCarTagNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRoghan);
            this.Controls.Add(this.chbSafiBenzin);
            this.Controls.Add(this.chbFliterCabin);
            this.Controls.Add(this.chbFilterRoghan);
            this.Controls.Add(this.chbFilterHava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTarikh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbKilometrbadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbKilometrfeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCarTag);
            this.Controls.Add(this.btnNewService);
            this.Controls.Add(this.ShowOilData);
            this.Controls.Add(this.cmbVaskazin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnShowData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Servic Cars";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbVaskazin;
        private System.Windows.Forms.Button ShowOilData;
        private System.Windows.Forms.Button btnNewService;
        private System.Windows.Forms.TextBox txbCarTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbKilometrfeli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKilometrbadi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTarikh;
        private System.Windows.Forms.CheckBox chbFilterHava;
        private System.Windows.Forms.CheckBox chbFilterRoghan;
        private System.Windows.Forms.CheckBox chbFliterCabin;
        private System.Windows.Forms.CheckBox chbSafiBenzin;
        private System.Windows.Forms.ComboBox cmbRoghan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCarTagNew;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCarName;
        private System.Windows.Forms.TextBox txbCarModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbOwner;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbOilType;
        private System.Windows.Forms.TextBox txbOilName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbOilID;
        private System.Windows.Forms.Label lable13;
        private System.Windows.Forms.Button btnNewOil;
        private System.Windows.Forms.Button btnRemoveOil;
        private System.Windows.Forms.Button btnRemoveCar;
    }
}

