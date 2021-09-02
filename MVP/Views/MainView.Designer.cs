namespace MVP.Views
{
    partial class MainView
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.listBoxCar = new System.Windows.Forms.ListBox();
			this.btnAddCar = new System.Windows.Forms.Button();
			this.btnLoadCars = new System.Windows.Forms.Button();
			this.comboBoxColor = new System.Windows.Forms.ComboBox();
			this.CbVendor = new System.Windows.Forms.ComboBox();
			this.cbModel = new System.Windows.Forms.ComboBox();
			this.cbTransmission = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.cbYear = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(39, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vendor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(39, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 42);
			this.label2.TabIndex = 1;
			this.label2.Text = "Model";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(39, 217);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 42);
			this.label3.TabIndex = 2;
			this.label3.Text = "Color";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(39, 305);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 42);
			this.label4.TabIndex = 3;
			this.label4.Text = "Year";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(39, 390);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(252, 42);
			this.label5.TabIndex = 4;
			this.label5.Text = "Transmission";
			// 
			// listBoxCar
			// 
			this.listBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBoxCar.FormattingEnabled = true;
			this.listBoxCar.ItemHeight = 29;
			this.listBoxCar.Location = new System.Drawing.Point(590, 22);
			this.listBoxCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listBoxCar.Name = "listBoxCar";
			this.listBoxCar.Size = new System.Drawing.Size(381, 410);
			this.listBoxCar.TabIndex = 10;
			this.listBoxCar.SelectedIndexChanged += new System.EventHandler(this.listBoxCar_SelectedIndexChanged);
			// 
			// btnAddCar
			// 
			this.btnAddCar.AutoSize = true;
			this.btnAddCar.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddCar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnAddCar.Location = new System.Drawing.Point(389, 458);
			this.btnAddCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddCar.Name = "btnAddCar";
			this.btnAddCar.Size = new System.Drawing.Size(146, 47);
			this.btnAddCar.TabIndex = 11;
			this.btnAddCar.Text = "Add Car";
			this.btnAddCar.UseVisualStyleBackColor = false;
			this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
			// 
			// btnLoadCars
			// 
			this.btnLoadCars.AutoSize = true;
			this.btnLoadCars.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnLoadCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLoadCars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLoadCars.Location = new System.Drawing.Point(795, 458);
			this.btnLoadCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLoadCars.Name = "btnLoadCars";
			this.btnLoadCars.Size = new System.Drawing.Size(176, 47);
			this.btnLoadCars.TabIndex = 12;
			this.btnLoadCars.Text = "Load Cars";
			this.btnLoadCars.UseVisualStyleBackColor = false;
			this.btnLoadCars.Click += new System.EventHandler(this.btnLoadCars_Click);
			// 
			// comboBoxColor
			// 
			this.comboBoxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.comboBoxColor.FormattingEnabled = true;
			this.comboBoxColor.Location = new System.Drawing.Point(332, 229);
			this.comboBoxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxColor.Name = "comboBoxColor";
			this.comboBoxColor.Size = new System.Drawing.Size(181, 32);
			this.comboBoxColor.TabIndex = 13;
			this.comboBoxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxColor_DrawItem);
			// 
			// CbVendor
			// 
			this.CbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.CbVendor.FormattingEnabled = true;
			this.CbVendor.Location = new System.Drawing.Point(332, 57);
			this.CbVendor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CbVendor.Name = "CbVendor";
			this.CbVendor.Size = new System.Drawing.Size(181, 33);
			this.CbVendor.TabIndex = 14;
			this.CbVendor.SelectedIndexChanged += new System.EventHandler(this.CbVendor_SelectedIndexChanged);
			// 
			// cbModel
			// 
			this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.cbModel.FormattingEnabled = true;
			this.cbModel.Location = new System.Drawing.Point(332, 134);
			this.cbModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbModel.Name = "cbModel";
			this.cbModel.Size = new System.Drawing.Size(181, 33);
			this.cbModel.TabIndex = 15;
			// 
			// cbTransmission
			// 
			this.cbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.cbTransmission.FormattingEnabled = true;
			this.cbTransmission.Location = new System.Drawing.Point(332, 402);
			this.cbTransmission.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbTransmission.Name = "cbTransmission";
			this.cbTransmission.Size = new System.Drawing.Size(181, 33);
			this.cbTransmission.TabIndex = 16;
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = true;
			this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDelete.Location = new System.Drawing.Point(599, 458);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(178, 47);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete Car";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
			// 
			// cbYear
			// 
			this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
			this.cbYear.FormattingEnabled = true;
			this.cbYear.Location = new System.Drawing.Point(332, 317);
			this.cbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbYear.Name = "cbYear";
			this.cbYear.Size = new System.Drawing.Size(181, 33);
			this.cbYear.TabIndex = 18;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 554);
			this.Controls.Add(this.cbYear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.cbTransmission);
			this.Controls.Add(this.cbModel);
			this.Controls.Add(this.CbVendor);
			this.Controls.Add(this.comboBoxColor);
			this.Controls.Add(this.btnLoadCars);
			this.Controls.Add(this.btnAddCar);
			this.Controls.Add(this.listBoxCar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainView";
			this.Text = "MainView";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnLoadCars;
		private System.Windows.Forms.ComboBox comboBoxColor;
		private System.Windows.Forms.ComboBox CbVendor;
		private System.Windows.Forms.ComboBox cbModel;
		private System.Windows.Forms.ComboBox cbTransmission;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ComboBox cbYear;
	}
}