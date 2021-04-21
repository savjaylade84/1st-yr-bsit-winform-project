namespace Student_info
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.std_id = new System.Windows.Forms.TextBox();
            this.std_name = new System.Windows.Forms.TextBox();
            this.std_dept = new System.Windows.Forms.TextBox();
            this.save_db = new System.Windows.Forms.Button();
            this.search_db = new System.Windows.Forms.Button();
            this.del_db = new System.Windows.Forms.Button();
            this.edit_db = new System.Windows.Forms.Button();
            this.cancel_db = new System.Windows.Forms.Button();
            this.new_db = new System.Windows.Forms.Button();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.pictureURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(13, 13);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(480, 686);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(521, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(521, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // std_id
            // 
            this.std_id.Location = new System.Drawing.Point(763, 129);
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(224, 22);
            this.std_id.TabIndex = 5;
            // 
            // std_name
            // 
            this.std_name.Location = new System.Drawing.Point(763, 165);
            this.std_name.Name = "std_name";
            this.std_name.Size = new System.Drawing.Size(320, 22);
            this.std_name.TabIndex = 6;
            // 
            // std_dept
            // 
            this.std_dept.Location = new System.Drawing.Point(763, 213);
            this.std_dept.Name = "std_dept";
            this.std_dept.Size = new System.Drawing.Size(320, 22);
            this.std_dept.TabIndex = 7;
            // 
            // save_db
            // 
            this.save_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_db.Location = new System.Drawing.Point(520, 513);
            this.save_db.Name = "save_db";
            this.save_db.Size = new System.Drawing.Size(169, 90);
            this.save_db.TabIndex = 8;
            this.save_db.Text = "Save";
            this.save_db.UseVisualStyleBackColor = true;
            this.save_db.Click += new System.EventHandler(this.save_db_Click);
            // 
            // search_db
            // 
            this.search_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.search_db.Location = new System.Drawing.Point(763, 513);
            this.search_db.Name = "search_db";
            this.search_db.Size = new System.Drawing.Size(169, 90);
            this.search_db.TabIndex = 9;
            this.search_db.Text = "Search";
            this.search_db.UseVisualStyleBackColor = true;
            this.search_db.Click += new System.EventHandler(this.search_db_Click);
            // 
            // del_db
            // 
            this.del_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.del_db.Location = new System.Drawing.Point(1010, 513);
            this.del_db.Name = "del_db";
            this.del_db.Size = new System.Drawing.Size(169, 90);
            this.del_db.TabIndex = 10;
            this.del_db.Text = "Delete";
            this.del_db.UseVisualStyleBackColor = true;
            this.del_db.Click += new System.EventHandler(this.del_db_Click);
            // 
            // edit_db
            // 
            this.edit_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.edit_db.Location = new System.Drawing.Point(520, 609);
            this.edit_db.Name = "edit_db";
            this.edit_db.Size = new System.Drawing.Size(169, 90);
            this.edit_db.TabIndex = 11;
            this.edit_db.Text = "Edit";
            this.edit_db.UseVisualStyleBackColor = true;
            this.edit_db.Click += new System.EventHandler(this.edit_db_Click);
            // 
            // cancel_db
            // 
            this.cancel_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cancel_db.Location = new System.Drawing.Point(763, 609);
            this.cancel_db.Name = "cancel_db";
            this.cancel_db.Size = new System.Drawing.Size(169, 90);
            this.cancel_db.TabIndex = 12;
            this.cancel_db.Text = "Cancel";
            this.cancel_db.UseVisualStyleBackColor = true;
            this.cancel_db.Click += new System.EventHandler(this.cancel_db_Click);
            // 
            // new_db
            // 
            this.new_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.new_db.Location = new System.Drawing.Point(1010, 609);
            this.new_db.Name = "new_db";
            this.new_db.Size = new System.Drawing.Size(169, 90);
            this.new_db.TabIndex = 13;
            this.new_db.Text = "New";
            this.new_db.UseVisualStyleBackColor = true;
            this.new_db.Click += new System.EventHandler(this.new_db_Click);
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToOrderColumns = true;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Enabled = false;
            this.datagridview.Location = new System.Drawing.Point(526, 278);
            this.datagridview.Name = "datagridview";
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(653, 212);
            this.datagridview.TabIndex = 14;
            // 
            // pictureURL
            // 
            this.pictureURL.Location = new System.Drawing.Point(73, 554);
            this.pictureURL.Name = "pictureURL";
            this.pictureURL.Size = new System.Drawing.Size(365, 22);
            this.pictureURL.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 711);
            this.Controls.Add(this.pictureURL);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.new_db);
            this.Controls.Add(this.cancel_db);
            this.Controls.Add(this.edit_db);
            this.Controls.Add(this.del_db);
            this.Controls.Add(this.search_db);
            this.Controls.Add(this.save_db);
            this.Controls.Add(this.std_dept);
            this.Controls.Add(this.std_name);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox std_id;
        private System.Windows.Forms.TextBox std_name;
        private System.Windows.Forms.TextBox std_dept;
        private System.Windows.Forms.Button save_db;
        private System.Windows.Forms.Button search_db;
        private System.Windows.Forms.Button del_db;
        private System.Windows.Forms.Button edit_db;
        private System.Windows.Forms.Button cancel_db;
        private System.Windows.Forms.Button new_db;
        private System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.TextBox pictureURL;
    }
}

