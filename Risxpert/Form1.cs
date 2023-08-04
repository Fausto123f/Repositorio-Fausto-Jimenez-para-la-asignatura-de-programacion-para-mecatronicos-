using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risxpert
{
    public partial class Risxpert0 : Form
    {
        private object sb;

        public Risxpert0()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                MessageBox.Show("Fila Eliminada Correctamente");
                    }
            else
            {
                MessageBox.Show("Por Favor, Selecciona una fila para eliminar");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Risxpert0_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].ToString();

            DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
            bool isLastRowEmpty = true;
            foreach (DataGridViewCell cell in lastRow.Cells)
            {
                if (cell.Value != null && cell.Value.ToString().Trim() != "")
                {
                    isLastRowEmpty = false;
                    break;
                }
            }

            // Si la última fila está vacía, agregar una nueva fila
            if (isLastRowEmpty)
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Selected = true; // Opcional: seleccionar la nueva fila
            }
            else
            { }

            dataGridView1.Rows.Add();
        }

        private void Fecha1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar2_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void LineaBlanca1_Click(object sender, EventArgs e)
        {

        }

        private void LineaBlanca2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

