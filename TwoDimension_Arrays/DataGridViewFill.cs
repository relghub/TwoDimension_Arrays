using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimension_Arrays
{
    internal class DataGridViewFill
    {
        protected int[,] arrayInput { get; set; }
        protected DataGridView dgvInput { get; set; }
        internal DataGridView dgvOutput;
        public DataGridViewFill(int[,] arrayInput,
            DataGridView dgvInput)
        {
            this.arrayInput = arrayInput;
            this.dgvInput = dgvInput;
            int dgvRowCount = dgvInput.Rows.Count;
            int dgvColCount = dgvInput.Columns.Count;
            dgvOutput = DGVIter(arrayInput,
                                dgvInput,
                                dgvRowCount,
                                dgvColCount);
        }
        public DataGridView DGVIter(int[,] arrayInput,
            DataGridView dgvInput, 
            int dgvRowCount,
            int dgvColCount)
        {
            for (int i = 0; i < dgvRowCount; i++)
            {
                for (int j = 0; j < dgvColCount; j++)
                {
                    dgvInput.Rows[i].Cells[j].Value = arrayInput[i, j];
                    dgvInput.Columns[j].Width = 50;
                }
            }
            return dgvInput;
        }

    }
}
