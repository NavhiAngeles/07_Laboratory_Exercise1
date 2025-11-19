namespace _07_Laboratory_Exercise1
{
    partial class FrmClubRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClubRegistration));
            panel1 = new Panel();
            gendercomboBox = new ComboBox();
            ProgcomboBox = new ComboBox();
            Agetxt = new TextBox();
            MiddleNametxt = new TextBox();
            FirstNametxt = new TextBox();
            LastNametxt = new TextBox();
            studIDtxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            DGVList = new DataGridView();
            RegisterButton = new Button();
            button2 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(gendercomboBox);
            panel1.Controls.Add(ProgcomboBox);
            panel1.Controls.Add(Agetxt);
            panel1.Controls.Add(MiddleNametxt);
            panel1.Controls.Add(FirstNametxt);
            panel1.Controls.Add(LastNametxt);
            panel1.Controls.Add(studIDtxt);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 213);
            panel1.TabIndex = 0;
            // 
            // gendercomboBox
            // 
            gendercomboBox.FormattingEnabled = true;
            gendercomboBox.Location = new Point(206, 167);
            gendercomboBox.Name = "gendercomboBox";
            gendercomboBox.Size = new Size(166, 23);
            gendercomboBox.TabIndex = 14;
            // 
            // ProgcomboBox
            // 
            ProgcomboBox.FormattingEnabled = true;
            ProgcomboBox.Location = new Point(406, 40);
            ProgcomboBox.Name = "ProgcomboBox";
            ProgcomboBox.Size = new Size(238, 23);
            ProgcomboBox.TabIndex = 13;
            // 
            // Agetxt
            // 
            Agetxt.Location = new Point(26, 167);
            Agetxt.Name = "Agetxt";
            Agetxt.Size = new Size(166, 23);
            Agetxt.TabIndex = 12;
            // 
            // MiddleNametxt
            // 
            MiddleNametxt.Location = new Point(408, 100);
            MiddleNametxt.Name = "MiddleNametxt";
            MiddleNametxt.Size = new Size(166, 23);
            MiddleNametxt.TabIndex = 10;
            // 
            // FirstNametxt
            // 
            FirstNametxt.Location = new Point(206, 100);
            FirstNametxt.Name = "FirstNametxt";
            FirstNametxt.Size = new Size(166, 23);
            FirstNametxt.TabIndex = 9;
            // 
            // LastNametxt
            // 
            LastNametxt.Location = new Point(26, 100);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(166, 23);
            LastNametxt.TabIndex = 8;
            // 
            // studIDtxt
            // 
            studIDtxt.Location = new Point(26, 41);
            studIDtxt.Name = "studIDtxt";
            studIDtxt.Size = new Size(166, 23);
            studIDtxt.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(408, 82);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 6;
            label7.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(408, 23);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 5;
            label6.Text = "Program:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(206, 149);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(206, 82);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 149);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 82);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(DGVList);
            panel2.Location = new Point(12, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(823, 217);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(684, 14);
            button3.Name = "button3";
            button3.Size = new Size(130, 42);
            button3.TabIndex = 5;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            // 
            // DGVList
            // 
            DGVList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVList.Location = new Point(18, 14);
            DGVList.Name = "DGVList";
            DGVList.Size = new Size(660, 184);
            DGVList.TabIndex = 0;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterButton.Location = new Point(704, 18);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(130, 42);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(704, 77);
            button2.Name = "button2";
            button2.Size = new Size(130, 42);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 249);
            label8.Name = "label8";
            label8.Size = new Size(128, 15);
            label8.TabIndex = 4;
            label8.Text = "List of Club Memebers:";
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(847, 493);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(RegisterButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmClubRegistration";
            Text = "Form1";
            Load += FrmClubRegistration_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox gendercomboBox;
        private ComboBox ProgcomboBox;
        private TextBox Agetxt;
        private TextBox MiddleNametxt;
        private TextBox FirstNametxt;
        private TextBox LastNametxt;
        private TextBox studIDtxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button RegisterButton;
        private Button button2;
        private Button button3;
        private DataGridView DGVList;
        private Label label8;
    }
}
