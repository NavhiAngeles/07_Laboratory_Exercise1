namespace _07_Laboratory_Exercise1
{
    partial class FrmUpdateMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateMember));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            StudIDcomboBox = new ComboBox();
            UPDprogramcomboBox = new ComboBox();
            UPDGenderComboBox = new ComboBox();
            UPDLast = new TextBox();
            UPDFirst = new TextBox();
            UPDmid = new TextBox();
            UPDage = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 133);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 191);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Middle Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 249);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Age: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 304);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 362);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 6;
            label7.Text = "Program: ";
            // 
            // StudIDcomboBox
            // 
            StudIDcomboBox.FormattingEnabled = true;
            StudIDcomboBox.Location = new Point(30, 42);
            StudIDcomboBox.Name = "StudIDcomboBox";
            StudIDcomboBox.Size = new Size(274, 23);
            StudIDcomboBox.TabIndex = 7;
            // 
            // UPDprogramcomboBox
            // 
            UPDprogramcomboBox.FormattingEnabled = true;
            UPDprogramcomboBox.Location = new Point(30, 385);
            UPDprogramcomboBox.Name = "UPDprogramcomboBox";
            UPDprogramcomboBox.Size = new Size(274, 23);
            UPDprogramcomboBox.TabIndex = 8;
            // 
            // UPDGenderComboBox
            // 
            UPDGenderComboBox.FormattingEnabled = true;
            UPDGenderComboBox.Location = new Point(30, 327);
            UPDGenderComboBox.Name = "UPDGenderComboBox";
            UPDGenderComboBox.Size = new Size(274, 23);
            UPDGenderComboBox.TabIndex = 9;
            // 
            // UPDLast
            // 
            UPDLast.Location = new Point(30, 97);
            UPDLast.Name = "UPDLast";
            UPDLast.Size = new Size(274, 23);
            UPDLast.TabIndex = 10;
            // 
            // UPDFirst
            // 
            UPDFirst.Location = new Point(30, 156);
            UPDFirst.Name = "UPDFirst";
            UPDFirst.Size = new Size(274, 23);
            UPDFirst.TabIndex = 11;
            // 
            // UPDmid
            // 
            UPDmid.Location = new Point(30, 214);
            UPDmid.Name = "UPDmid";
            UPDmid.Size = new Size(274, 23);
            UPDmid.TabIndex = 12;
            // 
            // UPDage
            // 
            UPDage.Location = new Point(30, 272);
            UPDage.Name = "UPDage";
            UPDage.Size = new Size(274, 23);
            UPDage.TabIndex = 13;
            UPDage.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(101, 439);
            button1.Name = "button1";
            button1.Size = new Size(138, 47);
            button1.TabIndex = 14;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(339, 514);
            Controls.Add(button1);
            Controls.Add(UPDage);
            Controls.Add(UPDmid);
            Controls.Add(UPDFirst);
            Controls.Add(UPDLast);
            Controls.Add(UPDGenderComboBox);
            Controls.Add(UPDprogramcomboBox);
            Controls.Add(StudIDcomboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
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
        private ComboBox StudIDcomboBox;
        private ComboBox UPDprogramcomboBox;
        private ComboBox UPDGenderComboBox;
        private TextBox UPDLast;
        private TextBox UPDFirst;
        private TextBox UPDmid;
        private TextBox UPDage;
        private Button button1;
    }
}