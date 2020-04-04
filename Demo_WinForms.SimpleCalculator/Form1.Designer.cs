namespace Demo_WinForms.SimpleCalculator
{
    partial class MainForm
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtbox_Length = new System.Windows.Forms.TextBox();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txtbox_Width = new System.Windows.Forms.TextBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.txtbox_Height = new System.Windows.Forms.TextBox();
            this.grpBox_Inputs = new System.Windows.Forms.GroupBox();
            this.picbox_DumpTruck = new System.Windows.Forms.PictureBox();
            this.radbtn_Pounds = new System.Windows.Forms.RadioButton();
            this.radbut_Killogram = new System.Windows.Forms.RadioButton();
            this.cmbbox_Material = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_GrossWeight = new System.Windows.Forms.Label();
            this.txtbox_GrossWeight = new System.Windows.Forms.TextBox();
            this.lbl_PayloadWeight = new System.Windows.Forms.Label();
            this.txtbox_PayloadWeight = new System.Windows.Forms.TextBox();
            this.lbl_Empty = new System.Windows.Forms.Label();
            this.txtbox_EmptyWeight = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.grpBox_Inputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_DumpTruck)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Title.Location = new System.Drawing.Point(212, 46);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(295, 26);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Dump Trailer Load Calculator";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Exit.Location = new System.Drawing.Point(513, 256);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 34);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // txtbox_Length
            // 
            this.txtbox_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Length.Location = new System.Drawing.Point(73, 19);
            this.txtbox_Length.Name = "txtbox_Length";
            this.txtbox_Length.Size = new System.Drawing.Size(100, 26);
            this.txtbox_Length.TabIndex = 2;
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Length.Location = new System.Drawing.Point(8, 22);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(59, 20);
            this.lbl_Length.TabIndex = 3;
            this.lbl_Length.Text = "Length";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Width.Location = new System.Drawing.Point(8, 63);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(50, 20);
            this.lbl_Width.TabIndex = 5;
            this.lbl_Width.Text = "Width";
            // 
            // txtbox_Width
            // 
            this.txtbox_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Width.Location = new System.Drawing.Point(73, 60);
            this.txtbox_Width.Name = "txtbox_Width";
            this.txtbox_Width.Size = new System.Drawing.Size(100, 26);
            this.txtbox_Width.TabIndex = 4;
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Height.Location = new System.Drawing.Point(8, 105);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(56, 20);
            this.lbl_Height.TabIndex = 7;
            this.lbl_Height.Text = "Height";
            // 
            // txtbox_Height
            // 
            this.txtbox_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Height.Location = new System.Drawing.Point(73, 102);
            this.txtbox_Height.Name = "txtbox_Height";
            this.txtbox_Height.Size = new System.Drawing.Size(100, 26);
            this.txtbox_Height.TabIndex = 6;
            // 
            // grpBox_Inputs
            // 
            this.grpBox_Inputs.Controls.Add(this.lbl_Height);
            this.grpBox_Inputs.Controls.Add(this.txtbox_Height);
            this.grpBox_Inputs.Controls.Add(this.lbl_Width);
            this.grpBox_Inputs.Controls.Add(this.txtbox_Width);
            this.grpBox_Inputs.Controls.Add(this.lbl_Length);
            this.grpBox_Inputs.Controls.Add(this.txtbox_Length);
            this.grpBox_Inputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBox_Inputs.Location = new System.Drawing.Point(24, 98);
            this.grpBox_Inputs.Name = "grpBox_Inputs";
            this.grpBox_Inputs.Size = new System.Drawing.Size(191, 148);
            this.grpBox_Inputs.TabIndex = 8;
            this.grpBox_Inputs.TabStop = false;
            // 
            // picbox_DumpTruck
            // 
            this.picbox_DumpTruck.Image = global::Demo_WinForms.SimpleCalculator.Properties.Resources.dump_truck;
            this.picbox_DumpTruck.InitialImage = global::Demo_WinForms.SimpleCalculator.Properties.Resources.dump_truck;
            this.picbox_DumpTruck.Location = new System.Drawing.Point(24, 16);
            this.picbox_DumpTruck.Name = "picbox_DumpTruck";
            this.picbox_DumpTruck.Size = new System.Drawing.Size(173, 76);
            this.picbox_DumpTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_DumpTruck.TabIndex = 9;
            this.picbox_DumpTruck.TabStop = false;
            // 
            // radbtn_Pounds
            // 
            this.radbtn_Pounds.AutoSize = true;
            this.radbtn_Pounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_Pounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radbtn_Pounds.Location = new System.Drawing.Point(252, 117);
            this.radbtn_Pounds.Name = "radbtn_Pounds";
            this.radbtn_Pounds.Size = new System.Drawing.Size(81, 24);
            this.radbtn_Pounds.TabIndex = 10;
            this.radbtn_Pounds.TabStop = true;
            this.radbtn_Pounds.Text = "Pounds";
            this.radbtn_Pounds.UseVisualStyleBackColor = true;
            // 
            // radbut_Killogram
            // 
            this.radbut_Killogram.AutoSize = true;
            this.radbut_Killogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbut_Killogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.radbut_Killogram.Location = new System.Drawing.Point(252, 141);
            this.radbut_Killogram.Name = "radbut_Killogram";
            this.radbut_Killogram.Size = new System.Drawing.Size(99, 24);
            this.radbut_Killogram.TabIndex = 11;
            this.radbut_Killogram.TabStop = true;
            this.radbut_Killogram.Text = "Killograms";
            this.radbut_Killogram.UseVisualStyleBackColor = true;
            // 
            // cmbbox_Material
            // 
            this.cmbbox_Material.FormattingEnabled = true;
            this.cmbbox_Material.Location = new System.Drawing.Point(240, 203);
            this.cmbbox_Material.Name = "cmbbox_Material";
            this.cmbbox_Material.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Material.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(268, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Material";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.lbl_GrossWeight);
            this.groupBox1.Controls.Add(this.txtbox_GrossWeight);
            this.groupBox1.Controls.Add(this.lbl_PayloadWeight);
            this.groupBox1.Controls.Add(this.txtbox_PayloadWeight);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(397, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 148);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lbl_GrossWeight
            // 
            this.lbl_GrossWeight.AutoSize = true;
            this.lbl_GrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GrossWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_GrossWeight.Location = new System.Drawing.Point(8, 105);
            this.lbl_GrossWeight.Name = "lbl_GrossWeight";
            this.lbl_GrossWeight.Size = new System.Drawing.Size(52, 20);
            this.lbl_GrossWeight.TabIndex = 7;
            this.lbl_GrossWeight.Text = "Gross";
            // 
            // txtbox_GrossWeight
            // 
            this.txtbox_GrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_GrossWeight.Location = new System.Drawing.Point(73, 102);
            this.txtbox_GrossWeight.Name = "txtbox_GrossWeight";
            this.txtbox_GrossWeight.Size = new System.Drawing.Size(100, 26);
            this.txtbox_GrossWeight.TabIndex = 6;
            // 
            // lbl_PayloadWeight
            // 
            this.lbl_PayloadWeight.AutoSize = true;
            this.lbl_PayloadWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PayloadWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_PayloadWeight.Location = new System.Drawing.Point(8, 63);
            this.lbl_PayloadWeight.Name = "lbl_PayloadWeight";
            this.lbl_PayloadWeight.Size = new System.Drawing.Size(65, 20);
            this.lbl_PayloadWeight.TabIndex = 5;
            this.lbl_PayloadWeight.Text = "Payload";
            // 
            // txtbox_PayloadWeight
            // 
            this.txtbox_PayloadWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PayloadWeight.Location = new System.Drawing.Point(73, 60);
            this.txtbox_PayloadWeight.Name = "txtbox_PayloadWeight";
            this.txtbox_PayloadWeight.Size = new System.Drawing.Size(100, 26);
            this.txtbox_PayloadWeight.TabIndex = 4;
            // 
            // lbl_Empty
            // 
            this.lbl_Empty.AutoSize = true;
            this.lbl_Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Empty.Location = new System.Drawing.Point(32, 264);
            this.lbl_Empty.Name = "lbl_Empty";
            this.lbl_Empty.Size = new System.Drawing.Size(102, 20);
            this.lbl_Empty.TabIndex = 3;
            this.lbl_Empty.Text = "Truck Weight";
            // 
            // txtbox_EmptyWeight
            // 
            this.txtbox_EmptyWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_EmptyWeight.Location = new System.Drawing.Point(154, 261);
            this.txtbox_EmptyWeight.Name = "txtbox_EmptyWeight";
            this.txtbox_EmptyWeight.Size = new System.Drawing.Size(100, 26);
            this.txtbox_EmptyWeight.TabIndex = 2;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Calculate.Location = new System.Drawing.Point(12, 22);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(161, 31);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate Weight";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(609, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbox_Material);
            this.Controls.Add(this.radbut_Killogram);
            this.Controls.Add(this.lbl_Empty);
            this.Controls.Add(this.radbtn_Pounds);
            this.Controls.Add(this.txtbox_EmptyWeight);
            this.Controls.Add(this.picbox_DumpTruck);
            this.Controls.Add(this.grpBox_Inputs);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "The Simple Calculator";
            this.grpBox_Inputs.ResumeLayout(false);
            this.grpBox_Inputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_DumpTruck)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txtbox_Length;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.TextBox txtbox_Width;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.TextBox txtbox_Height;
        private System.Windows.Forms.GroupBox grpBox_Inputs;
        private System.Windows.Forms.PictureBox picbox_DumpTruck;
        private System.Windows.Forms.RadioButton radbtn_Pounds;
        private System.Windows.Forms.RadioButton radbut_Killogram;
        private System.Windows.Forms.ComboBox cmbbox_Material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_GrossWeight;
        private System.Windows.Forms.TextBox txtbox_GrossWeight;
        private System.Windows.Forms.Label lbl_PayloadWeight;
        private System.Windows.Forms.TextBox txtbox_PayloadWeight;
        private System.Windows.Forms.Label lbl_Empty;
        private System.Windows.Forms.TextBox txtbox_EmptyWeight;
    }
}

