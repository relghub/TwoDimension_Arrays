namespace TwoDimension_Arrays
{
    partial class frmArray
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
            cmdEvalBut = new Button();
            cmdClearBut = new Button();
            cmdExitBut = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRow = new TextBox();
            txtCol = new TextBox();
            txtRes = new TextBox();
            dgvArray = new DataGridView();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvArray).BeginInit();
            SuspendLayout();
            // 
            // cmdEvalBut
            // 
            cmdEvalBut.Location = new Point(12, 364);
            cmdEvalBut.Name = "cmdEvalBut";
            cmdEvalBut.Size = new Size(252, 23);
            cmdEvalBut.TabIndex = 0;
            cmdEvalBut.Text = "Обчислити";
            cmdEvalBut.UseVisualStyleBackColor = true;
            cmdEvalBut.Click += button1_Click;
            // 
            // cmdClearBut
            // 
            cmdClearBut.Location = new Point(551, 415);
            cmdClearBut.Name = "cmdClearBut";
            cmdClearBut.Size = new Size(237, 23);
            cmdClearBut.TabIndex = 1;
            cmdClearBut.Text = "Очистити поля";
            cmdClearBut.UseVisualStyleBackColor = true;
            cmdClearBut.Click += button2_Click;
            // 
            // cmdExitBut
            // 
            cmdExitBut.Location = new Point(12, 415);
            cmdExitBut.Name = "cmdExitBut";
            cmdExitBut.Size = new Size(252, 23);
            cmdExitBut.TabIndex = 2;
            cmdExitBut.Text = "Завершити роботу";
            cmdExitBut.UseVisualStyleBackColor = true;
            cmdExitBut.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Кількість рядків";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Кількість стовпців";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Результат";
            // 
            // txtRow
            // 
            txtRow.Location = new Point(12, 50);
            txtRow.Name = "txtRow";
            txtRow.Size = new Size(252, 23);
            txtRow.TabIndex = 6;
            // 
            // txtCol
            // 
            txtCol.Location = new Point(12, 98);
            txtCol.Name = "txtCol";
            txtCol.Size = new Size(252, 23);
            txtCol.TabIndex = 7;
            // 
            // txtRes
            // 
            txtRes.Location = new Point(12, 150);
            txtRes.Multiline = true;
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(252, 198);
            txtRes.TabIndex = 8;
            // 
            // dgvArray
            // 
            dgvArray.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArray.Location = new Point(281, 12);
            dgvArray.Name = "dgvArray";
            dgvArray.RowTemplate.Height = 25;
            dgvArray.Size = new Size(507, 397);
            dgvArray.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 346);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Введення змінних";
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvArray);
            Controls.Add(txtRes);
            Controls.Add(txtCol);
            Controls.Add(txtRow);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmdExitBut);
            Controls.Add(cmdClearBut);
            Controls.Add(cmdEvalBut);
            Controls.Add(groupBox1);
            Name = "frmArray";
            Text = "Двовимірні масиви";
            ((System.ComponentModel.ISupportInitialize)dgvArray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdEvalBut;
        private Button cmdClearBut;
        private Button cmdExitBut;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRow;
        private TextBox txtCol;
        private TextBox txtRes;
        private DataGridView dgvArray;
        private GroupBox groupBox1;
    }
}