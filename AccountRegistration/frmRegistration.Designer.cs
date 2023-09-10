namespace AccountRegistration
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtStudNo = new TextBox();
            txtLastname = new TextBox();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtFirstname = new TextBox();
            txtContact = new TextBox();
            txtMiddlename = new TextBox();
            comboProg = new ComboBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 16);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(255, 37);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 98);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(254, 98);
            label4.Name = "label4";
            label4.Size = new Size(79, 16);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(435, 98);
            label5.Name = "label5";
            label5.Size = new Size(100, 16);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 163);
            label6.Name = "label6";
            label6.Size = new Size(38, 16);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(254, 161);
            label7.Name = "label7";
            label7.Size = new Size(88, 16);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(22, 225);
            label8.Name = "label8";
            label8.Size = new Size(64, 16);
            label8.TabIndex = 7;
            label8.Text = "Address:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtStudNo
            // 
            txtStudNo.Location = new Point(22, 56);
            txtStudNo.Name = "txtStudNo";
            txtStudNo.Size = new Size(226, 23);
            txtStudNo.TabIndex = 9;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(22, 117);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(226, 23);
            txtLastname.TabIndex = 10;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(22, 182);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(226, 23);
            txtAge.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(22, 244);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(534, 115);
            txtAddress.TabIndex = 12;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(254, 117);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(175, 23);
            txtFirstname.TabIndex = 13;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(254, 180);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(175, 23);
            txtContact.TabIndex = 14;
            // 
            // txtMiddlename
            // 
            txtMiddlename.Location = new Point(435, 117);
            txtMiddlename.Name = "txtMiddlename";
            txtMiddlename.Size = new Size(121, 23);
            txtMiddlename.TabIndex = 15;
            // 
            // comboProg
            // 
            comboProg.FormattingEnabled = true;
            comboProg.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Computer Engineering", "BS in Accountancy" });
            comboProg.Location = new Point(254, 56);
            comboProg.Name = "comboProg";
            comboProg.Size = new Size(302, 25);
            comboProg.TabIndex = 16;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(245, 385);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(88, 32);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 429);
            Controls.Add(btnNext);
            Controls.Add(comboProg);
            Controls.Add(txtMiddlename);
            Controls.Add(txtContact);
            Controls.Add(txtFirstname);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtLastname);
            Controls.Add(txtStudNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmRegistration";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtStudNo;
        private TextBox txtLastname;
        private TextBox txtAge;
        private TextBox txtAddress;
        private TextBox txtFirstname;
        private TextBox txtContact;
        private TextBox txtMiddlename;
        private ComboBox comboProg;
        private Button btnNext;
    }
}