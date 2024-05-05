namespace TPFinalHaasEric.Forms
{
    partial class UserDetails
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
            txtEmployeeFullName = new TextBox();
            txtEmployeeDNI = new TextBox();
            txtEmployeeAge = new TextBox();
            txtEmployeeSalary = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnUserAccept = new Button();
            btnUserCancel = new Button();
            comboEmployeeIsMarried = new ComboBox();
            SuspendLayout();
            // 
            // txtEmployeeFullName
            // 
            txtEmployeeFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeFullName.Location = new Point(170, 55);
            txtEmployeeFullName.Name = "txtEmployeeFullName";
            txtEmployeeFullName.Size = new Size(195, 23);
            txtEmployeeFullName.TabIndex = 0;
            // 
            // txtEmployeeDNI
            // 
            txtEmployeeDNI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeDNI.Location = new Point(170, 102);
            txtEmployeeDNI.Name = "txtEmployeeDNI";
            txtEmployeeDNI.Size = new Size(195, 23);
            txtEmployeeDNI.TabIndex = 1;
            // 
            // txtEmployeeAge
            // 
            txtEmployeeAge.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeAge.Location = new Point(170, 157);
            txtEmployeeAge.Name = "txtEmployeeAge";
            txtEmployeeAge.Size = new Size(195, 23);
            txtEmployeeAge.TabIndex = 2;
            // 
            // txtEmployeeSalary
            // 
            txtEmployeeSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeSalary.Location = new Point(170, 268);
            txtEmployeeSalary.Name = "txtEmployeeSalary";
            txtEmployeeSalary.Size = new Size(195, 23);
            txtEmployeeSalary.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(46, 58);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre completo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(124, 105);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(118, 160);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(105, 214);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Casado:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(109, 271);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Salario:";
            // 
            // btnUserAccept
            // 
            btnUserAccept.Location = new Point(46, 332);
            btnUserAccept.Name = "btnUserAccept";
            btnUserAccept.Size = new Size(75, 23);
            btnUserAccept.TabIndex = 10;
            btnUserAccept.Text = "Aceptar";
            btnUserAccept.UseVisualStyleBackColor = true;
            btnUserAccept.Click += btnUserAccept_Click;
            // 
            // btnUserCancel
            // 
            btnUserCancel.Location = new Point(290, 332);
            btnUserCancel.Name = "btnUserCancel";
            btnUserCancel.Size = new Size(75, 23);
            btnUserCancel.TabIndex = 11;
            btnUserCancel.Text = "Cancelar";
            btnUserCancel.UseVisualStyleBackColor = true;
            btnUserCancel.Click += btnUserCancel_Click;
            // 
            // comboEmployeeIsMarried
            // 
            comboEmployeeIsMarried.FormattingEnabled = true;
            comboEmployeeIsMarried.Location = new Point(170, 211);
            comboEmployeeIsMarried.Name = "comboEmployeeIsMarried";
            comboEmployeeIsMarried.Size = new Size(195, 23);
            comboEmployeeIsMarried.TabIndex = 12;
            // 
            // UserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 391);
            Controls.Add(comboEmployeeIsMarried);
            Controls.Add(btnUserCancel);
            Controls.Add(btnUserAccept);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmployeeSalary);
            Controls.Add(txtEmployeeAge);
            Controls.Add(txtEmployeeDNI);
            Controls.Add(txtEmployeeFullName);
            Name = "UserDetails";
            Text = "Usuario";
            Load += UserDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmployeeFullName;
        private TextBox txtEmployeeDNI;
        private TextBox txtEmployeeAge;
        private TextBox txtEmployeeSalary;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnUserAccept;
        private Button btnUserCancel;
        private ComboBox comboEmployeeIsMarried;
    }
}