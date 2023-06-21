namespace WinFormsAppDemo
{
    partial class frmHRMain
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
            dgvEmployees = new DataGridView();
            groupBox1 = new GroupBox();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(58, 329);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 72;
            dgvEmployees.RowTemplate.Height = 39;
            dgvEmployees.Size = new Size(1351, 450);
            dgvEmployees.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(58, 832);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1351, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(961, 52);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(173, 61);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(700, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(173, 61);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(445, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(173, 61);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(192, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(173, 61);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 46);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 2;
            label1.Text = "Employee Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 132);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 217);
            label3.Name = "label3";
            label3.Size = new Size(170, 37);
            label3.TabIndex = 4;
            label3.Text = "Working Day";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(371, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 42);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(371, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 42);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(371, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(366, 42);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(836, 46);
            label4.Name = "label4";
            label4.Size = new Size(170, 37);
            label4.TabIndex = 8;
            label4.Text = "Date Of Birth";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(1061, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 42);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(836, 134);
            label5.Name = "label5";
            label5.Size = new Size(159, 37);
            label5.TabIndex = 10;
            label5.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1061, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 44);
            comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(836, 219);
            label6.Name = "label6";
            label6.Size = new Size(148, 37);
            label6.TabIndex = 12;
            label6.Text = "Rate Salary";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(1061, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 42);
            textBox4.TabIndex = 13;
            // 
            // frmHRMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 1008);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(dgvEmployees);
            MaximizeBox = false;
            Name = "frmHRMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Management Application";
            Load += frmHRMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployees;
        private GroupBox groupBox1;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox4;
    }
}