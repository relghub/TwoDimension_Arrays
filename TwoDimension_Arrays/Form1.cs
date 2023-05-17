namespace TwoDimension_Arrays
{
    public partial class frmArray : Form
    {
        public frmArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cmdEvalBut is used instead
            int row, col = 0;
            row = int.Parse(txtRow.Text);
            col = int.Parse(txtCol.Text);
            dgvArray.RowCount = row;
            dgvArray.ColumnCount = col;
            ArrayCreate arrayInForm = new(row, col);
            DataGridViewFill dgvProcess = new(arrayInForm.arrayOut, dgvArray);
            dgvArray = dgvProcess.dgvOutput;
            txtRes.Text = "Середнє арифметичне додатних елементів" +
            $" масиву становить {Math.Round(arrayInForm.posCellMean)}" +
            Environment.NewLine + "Кількість додатних елементів" +
            " масиву становить " + arrayInForm.posCellCount.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cmdClearBut is used instead
            txtRow.Clear();
            txtCol.Clear();
            txtRes.Clear();
            dgvArray.Rows.Clear();
            dgvArray.Columns.Clear();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // cmdExitBut is used instead
            Close();
        }
    }
}