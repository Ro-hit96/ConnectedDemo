namespace ConnectedDemo
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
            this.EmpIdlbl = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.ENamelbl = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.Agelbl = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.Salarylbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmddid = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpIdlbl
            // 
            this.EmpIdlbl.AutoSize = true;
            this.EmpIdlbl.Location = new System.Drawing.Point(52, 15);
            this.EmpIdlbl.Name = "EmpIdlbl";
            this.EmpIdlbl.Size = new System.Drawing.Size(59, 20);
            this.EmpIdlbl.TabIndex = 0;
            this.EmpIdlbl.Text = "EmpID";
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(172, 15);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(188, 26);
            this.txtempid.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(172, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(188, 26);
            this.txtname.TabIndex = 3;
            // 
            // ENamelbl
            // 
            this.ENamelbl.AutoSize = true;
            this.ENamelbl.Location = new System.Drawing.Point(52, 75);
            this.ENamelbl.Name = "ENamelbl";
            this.ENamelbl.Size = new System.Drawing.Size(62, 20);
            this.ENamelbl.TabIndex = 2;
            this.ENamelbl.Text = "EName";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(52, 130);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(48, 20);
            this.emaillbl.TabIndex = 4;
            this.emaillbl.Text = "EMail";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(172, 185);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(188, 26);
            this.txtage.TabIndex = 7;
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Location = new System.Drawing.Point(52, 185);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(38, 20);
            this.Agelbl.TabIndex = 6;
            this.Agelbl.Text = "Age";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(172, 246);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(188, 26);
            this.txtsalary.TabIndex = 9;
            // 
            // Salarylbl
            // 
            this.Salarylbl.AutoSize = true;
            this.Salarylbl.Location = new System.Drawing.Point(52, 246);
            this.Salarylbl.Name = "Salarylbl";
            this.Salarylbl.Size = new System.Drawing.Size(53, 20);
            this.Salarylbl.TabIndex = 8;
            this.Salarylbl.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Did";
            // 
            // cmddid
            // 
            this.cmddid.FormattingEnabled = true;
            this.cmddid.Location = new System.Drawing.Point(172, 301);
            this.cmddid.Name = "cmddid";
            this.cmddid.Size = new System.Drawing.Size(188, 28);
            this.cmddid.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(786, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(512, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 46);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(512, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 46);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(512, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 46);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 46);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowall
            // 
            this.btnShowall.Location = new System.Drawing.Point(792, 261);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(201, 40);
            this.btnShowall.TabIndex = 17;
            this.btnShowall.Text = "Show All";
            this.btnShowall.UseVisualStyleBackColor = true;
            this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.btnShowall);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmddid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.Salarylbl);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.Agelbl);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.ENamelbl);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.EmpIdlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpIdlbl;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label ENamelbl;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label Salarylbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmddid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowall;
    }
}

