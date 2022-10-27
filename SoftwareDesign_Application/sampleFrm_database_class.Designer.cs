namespace SoftwareDesign_Application
{
    partial class sampleFrm_database_class
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
            this.student_numTxtbox = new System.Windows.Forms.TextBox();
            this.student_nameTxtbox = new System.Windows.Forms.TextBox();
            this.student_departmentTxtbox = new System.Windows.Forms.TextBox();
            this.datagrid_display = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.picturpathTxtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student No.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(565, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department:";
            // 
            // student_numTxtbox
            // 
            this.student_numTxtbox.Location = new System.Drawing.Point(714, 45);
            this.student_numTxtbox.MaximumSize = new System.Drawing.Size(250, 25);
            this.student_numTxtbox.MinimumSize = new System.Drawing.Size(250, 25);
            this.student_numTxtbox.Multiline = true;
            this.student_numTxtbox.Name = "student_numTxtbox";
            this.student_numTxtbox.Size = new System.Drawing.Size(250, 25);
            this.student_numTxtbox.TabIndex = 5;
            // 
            // student_nameTxtbox
            // 
            this.student_nameTxtbox.Location = new System.Drawing.Point(714, 84);
            this.student_nameTxtbox.MaximumSize = new System.Drawing.Size(300, 25);
            this.student_nameTxtbox.MinimumSize = new System.Drawing.Size(300, 25);
            this.student_nameTxtbox.Name = "student_nameTxtbox";
            this.student_nameTxtbox.Size = new System.Drawing.Size(300, 22);
            this.student_nameTxtbox.TabIndex = 6;
            // 
            // student_departmentTxtbox
            // 
            this.student_departmentTxtbox.Location = new System.Drawing.Point(714, 126);
            this.student_departmentTxtbox.MaximumSize = new System.Drawing.Size(300, 25);
            this.student_departmentTxtbox.MinimumSize = new System.Drawing.Size(300, 25);
            this.student_departmentTxtbox.Multiline = true;
            this.student_departmentTxtbox.Name = "student_departmentTxtbox";
            this.student_departmentTxtbox.Size = new System.Drawing.Size(300, 25);
            this.student_departmentTxtbox.TabIndex = 7;
            // 
            // datagrid_display
            // 
            this.datagrid_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_display.Location = new System.Drawing.Point(566, 168);
            this.datagrid_display.Name = "datagrid_display";
            this.datagrid_display.RowHeadersWidth = 51;
            this.datagrid_display.RowTemplate.Height = 24;
            this.datagrid_display.Size = new System.Drawing.Size(471, 237);
            this.datagrid_display.TabIndex = 8;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(579, 420);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 37);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBtn.Location = new System.Drawing.Point(732, 420);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(129, 37);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBtn.Location = new System.Drawing.Point(885, 420);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(129, 37);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBtn.Location = new System.Drawing.Point(579, 479);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(129, 37);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "UPDATE/EDIT";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBtn.Location = new System.Drawing.Point(732, 479);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(129, 37);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newBtn.Location = new System.Drawing.Point(885, 479);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(129, 37);
            this.newBtn.TabIndex = 14;
            this.newBtn.Text = "NEW";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // picturpathTxtbox
            // 
            this.picturpathTxtbox.Location = new System.Drawing.Point(103, 380);
            this.picturpathTxtbox.MaximumSize = new System.Drawing.Size(350, 30);
            this.picturpathTxtbox.MinimumSize = new System.Drawing.Size(350, 30);
            this.picturpathTxtbox.Multiline = true;
            this.picturpathTxtbox.Name = "picturpathTxtbox";
            this.picturpathTxtbox.Size = new System.Drawing.Size(350, 30);
            this.picturpathTxtbox.TabIndex = 15;
            this.picturpathTxtbox.TextChanged += new System.EventHandler(this.picturepathTxtbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftwareDesign_Application.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(26, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // sampleFrm_database_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.picturpathTxtbox);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.datagrid_display);
            this.Controls.Add(this.student_departmentTxtbox);
            this.Controls.Add(this.student_nameTxtbox);
            this.Controls.Add(this.student_numTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "sampleFrm_database_class";
            this.Text = "sampleFrm_database_class";
            this.Load += new System.EventHandler(this.sampleFrm_database_class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_numTxtbox;
        private System.Windows.Forms.TextBox student_nameTxtbox;
        private System.Windows.Forms.TextBox student_departmentTxtbox;
        private System.Windows.Forms.DataGridView datagrid_display;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.TextBox picturpathTxtbox;
    }
}