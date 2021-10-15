
namespace MelodyMusicSystem
{
    partial class frmStudent
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
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboRegNo = new System.Windows.Forms.ComboBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtFName.Location = new System.Drawing.Point(148, 114);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(180, 31);
            this.txtFName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFirstName.Location = new System.Drawing.Point(21, 118);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(117, 24);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRegNo.Location = new System.Drawing.Point(21, 71);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(87, 24);
            this.lblRegNo.TabIndex = 7;
            this.lblRegNo.Text = "Reg No:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTitle.Location = new System.Drawing.Point(130, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Student Form";
            // 
            // cboRegNo
            // 
            this.cboRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cboRegNo.FormattingEnabled = true;
            this.cboRegNo.Location = new System.Drawing.Point(148, 71);
            this.cboRegNo.Name = "cboRegNo";
            this.cboRegNo.Size = new System.Drawing.Size(180, 32);
            this.cboRegNo.TabIndex = 12;
            this.cboRegNo.SelectedIndexChanged += new System.EventHandler(this.cboRegNo_SelectedIndexChanged);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtLName.Location = new System.Drawing.Point(148, 164);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(180, 31);
            this.txtLName.TabIndex = 14;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLastName.Location = new System.Drawing.Point(21, 168);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(114, 24);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAddress.Location = new System.Drawing.Point(148, 214);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 31);
            this.txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddress.Location = new System.Drawing.Point(21, 218);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 24);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDOB.Location = new System.Drawing.Point(21, 270);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(59, 24);
            this.lblDOB.TabIndex = 17;
            this.lblDOB.Text = "DOB:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dtpDOB.Location = new System.Drawing.Point(148, 270);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(180, 20);
            this.dtpDOB.TabIndex = 18;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtContact.Location = new System.Drawing.Point(148, 310);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(180, 31);
            this.txtContact.TabIndex = 20;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblContact.Location = new System.Drawing.Point(21, 314);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(86, 24);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact:";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtAge.Location = new System.Drawing.Point(148, 364);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(180, 31);
            this.txtAge.TabIndex = 22;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAge.Location = new System.Drawing.Point(21, 368);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(54, 24);
            this.lblAge.TabIndex = 21;
            this.lblAge.Text = "Age:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAdd.Location = new System.Drawing.Point(45, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 42);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdate.Location = new System.Drawing.Point(154, 430);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 42);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDelete.Location = new System.Drawing.Point(259, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 42);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnClear.Location = new System.Drawing.Point(94, 493);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 42);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.Location = new System.Drawing.Point(213, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 42);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(397, 566);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.cboRegNo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblRegNo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "frmStudent";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboRegNo;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}