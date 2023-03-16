namespace Serialization
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
            this.labelDepartmentId = new System.Windows.Forms.Label();
            this.labeldeptName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBinartWrite = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDepartmentId
            // 
            this.labelDepartmentId.AutoSize = true;
            this.labelDepartmentId.Location = new System.Drawing.Point(102, 31);
            this.labelDepartmentId.Name = "labelDepartmentId";
            this.labelDepartmentId.Size = new System.Drawing.Size(74, 13);
            this.labelDepartmentId.TabIndex = 0;
            this.labelDepartmentId.Text = "Department Id";
            this.labelDepartmentId.Click += new System.EventHandler(this.labelDepartmentId_Click);
            // 
            // labeldeptName
            // 
            this.labeldeptName.AutoSize = true;
            this.labeldeptName.Location = new System.Drawing.Point(102, 75);
            this.labeldeptName.Name = "labeldeptName";
            this.labeldeptName.Size = new System.Drawing.Size(93, 13);
            this.labeldeptName.TabIndex = 1;
            this.labeldeptName.Text = "Department Name";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(102, 132);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location";
            this.labelLocation.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(228, 31);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(143, 20);
            this.txtDeptId.TabIndex = 3;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(228, 75);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(143, 20);
            this.txtDeptName.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(228, 125);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(143, 20);
            this.txtLocation.TabIndex = 5;
            // 
            // btnBinartWrite
            // 
            this.btnBinartWrite.Location = new System.Drawing.Point(99, 174);
            this.btnBinartWrite.Name = "btnBinartWrite";
            this.btnBinartWrite.Size = new System.Drawing.Size(96, 23);
            this.btnBinartWrite.TabIndex = 6;
            this.btnBinartWrite.Text = "BinaryWrite";
            this.btnBinartWrite.UseVisualStyleBackColor = true;
            this.btnBinartWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(99, 223);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(96, 23);
            this.btnXMLWrite.TabIndex = 7;
            this.btnXMLWrite.Text = "XML Write ";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(99, 268);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(96, 23);
            this.btnSOAPWrite.TabIndex = 8;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(253, 317);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(102, 23);
            this.btnJSONRead.TabIndex = 9;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(253, 174);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(102, 23);
            this.btnBinaryRead.TabIndex = 10;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(253, 223);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(102, 23);
            this.btnXMLRead.TabIndex = 11;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(253, 268);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(102, 23);
            this.btnSOAPRead.TabIndex = 12;
            this.btnSOAPRead.Text = "SOAP Read";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(99, 317);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(96, 23);
            this.btnJSONWrite.TabIndex = 13;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinartWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labeldeptName);
            this.Controls.Add(this.labelDepartmentId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDepartmentId;
        private System.Windows.Forms.Label labeldeptName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBinartWrite;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnJSONRead;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONWrite;
    }
}

