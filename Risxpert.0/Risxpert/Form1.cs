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
using LiteDB;

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
            if (dataGridView1.SelectedRows.Count > 0)
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

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                var dtgvValuesRows =dataGridView2.Rows[i];

                int F = Convert.ToInt32(dtgvValuesRows.Cells[4].Value);
                int S = Convert.ToInt32(dtgvValuesRows.Cells[5].Value);
                int P = Convert.ToInt32(dtgvValuesRows.Cells[6].Value);
                int E = Convert.ToInt32(dtgvValuesRows.Cells[7].Value);
                int A = Convert.ToInt32(dtgvValuesRows.Cells[8].Value);
                int V = Convert.ToInt32(dtgvValuesRows.Cells[9].Value);

                int I = F * S;
                int D = P * E;
                int Pb = A * V;
                int C = I + D;
                int ER = Pb * C;

                if (dataGridView3.Rows.Count < dataGridView2.Rows.Count)
                {
                    dataGridView3.Rows.Add();
                }
                var dtgvEvaluationRows = dataGridView3.Rows[i];

                dtgvEvaluationRows.Cells[0].Value = dtgvValuesRows.Cells[0].Value;
                dtgvEvaluationRows.Cells[1].Value = dtgvValuesRows.Cells[1].Value;
                dtgvEvaluationRows.Cells[2].Value = dtgvValuesRows.Cells[2].Value;
                dtgvEvaluationRows.Cells[3].Value = dtgvValuesRows.Cells[3].Value;

                dtgvEvaluationRows.Cells[4].Value = C;
                dtgvEvaluationRows.Cells[5].Value = Pb;
                dtgvEvaluationRows.Cells[6].Value = ER;
            }
        }

        private void ActualizartabPage4(int i)
        {
            throw new NotImplementedException();
        }

        private void ActualizartabPage3(int i)
        {
            throw new NotImplementedException();
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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridFase6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void PasarInformacion_1_2()
        {
            // Obtener el DataGridView de la pestaña de origen
            DataGridView DataGridView_Informacion = dataGridView1; // Cambia esto según tu diseño

            // Obtener el DataGridView de la pestaña de destino
            DataGridView DataGridView_Destino = dataGridView2; // Cambia esto según tu diseño

            // Copiar los datos seleccionados o todas las filas del DataGridView de origen al DataGridView de destino
            foreach (DataGridViewRow row in DataGridView_Informacion.SelectedRows)
            {
                // Crear una nueva fila en el DataGridView de destino y copiar los valores de celdas
                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }

                // Agregar la nueva fila al DataGridView de destino
                DataGridView_Destino.Rows.Add(newRow);
            }
        }

        private void Fases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Fases.SelectedIndex == 1)
            {
                dataGridView2.Rows.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                    dataGridView2.Rows.Add(rowData);
                }
            }

        }
        private DataGridView GetDataGridViewByTabIndex(int tabIndex)
        {
            switch (tabIndex)
            {
                case 0:
                    return dataGridView1;
                case 1:
                    return dataGridView2;
                case 2:
                    return dataGridView3;
                case 3:
                    return dataGridFase4;
                default:
                    return null;
            }
        }
        private bool IsColumnToCopyOrCalculate(int columnIndex)
        {
            // Aquí defines los índices de las columnas S, F, P, A, V, E que deseas copiar o calcular
            int[] columnIndices = new int[] { 1, 2, 3, 4, 5, 6 };

            return columnIndices.Contains(columnIndex);
        }
        private void CalculateValuesForDataGridFase3(DataGridView targetGrid, int rowIndex)
        {
            int indexOfS = targetGrid.Columns["S"].Index;
            int indexOfF = targetGrid.Columns["F"].Index;
            int indexOfP = targetGrid.Columns["P"].Index;
            int indexOfA = targetGrid.Columns["A"].Index;
            int indexOfV = targetGrid.Columns["V"].Index;
            int indexOfE = targetGrid.Columns["E"].Index;
            int indexOfC = targetGrid.Columns["C"].Index;
            int indexOfPB = targetGrid.Columns["PB"].Index;
            int indexOfER = targetGrid.Columns["ER"].Index;

            int valueOfS = Convert.ToInt32(targetGrid.Rows[rowIndex].Cells[indexOfS].Value);
            int valueOfF = Convert.ToInt32(targetGrid.Rows[rowIndex].Cells[indexOfF].Value);
            int valueOfP = Convert.ToInt32(targetGrid.Rows[rowIndex].Cells[indexOfP].Value);
            int valueOfA = Convert.ToInt32(targetGrid.Rows[rowIndex].Cells[indexOfA].Value);
            int valueOfV = Convert.ToInt32(targetGrid.Rows[rowIndex].Cells[indexOfV].Value);
            int valueOfE = Convert.ToInt32(targetGrid.Rows[rowIndex].Cells[indexOfE].Value);

            int calculatedValueC = valueOfS * valueOfF; // Calcula el valor C
            int calculatedValuePB = valueOfA * valueOfV; // Calcula el valor PB
            int calculatedValueER = calculatedValueC * calculatedValuePB; // Calcula el valor ER

            targetGrid.Rows[rowIndex].Cells[indexOfC].Value = calculatedValueC; // Cambia "indexOfC" por el índice real de la columna C
            targetGrid.Rows[rowIndex].Cells[indexOfPB].Value = calculatedValuePB; // Cambia "indexOfPB" por el índice real de la columna PB
            targetGrid.Rows[rowIndex].Cells[indexOfER].Value = calculatedValueER; // Cambia "indexOfER" por el índice real de la columna ER
        }
        public class AnalisisdeRiesgo
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string[] Phones { get; set; }
            public bool IsActive { get; set; }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex == 3)
                {
                    e.Cancel = true;  // Cancelar edición para las columnas ID, Activo, Riesgo, Daño
                }
            }
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
           
               
            

        }
        private void CalculateValuesForDataGridFase3(int rowIndex)
        {
            int indexOfS = dataGridView2.Columns["S"].Index;
            int indexOfF = dataGridView2.Columns["F"].Index;
            int indexOfP = dataGridView2.Columns["P"].Index;
            int indexOfA = dataGridView2.Columns["A"].Index;
            int indexOfV = dataGridView2.Columns["V"].Index;
            int indexOfE = dataGridView2.Columns["E"].Index;
            int indexOfC = dataGridView3.Columns["C"].Index;
            int indexOfPB = dataGridView3.Columns["PB"].Index;
            int indexOfER = dataGridView3.Columns["ER"].Index;

            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            int valueS = Convert.ToInt32(row.Cells[indexOfS].Value);
            int valueF = Convert.ToInt32(row.Cells[indexOfF].Value);
            int valueP = Convert.ToInt32(row.Cells[indexOfP].Value);
            int valueA = Convert.ToInt32(row.Cells[indexOfA].Value);
            int valueV = Convert.ToInt32(row.Cells[indexOfV].Value);
            int valueE = Convert.ToInt32(row.Cells[indexOfE].Value);

            int valueC = valueF * valueS;
            int valuePB = valueA * valueV;
            int valueER = valueC * valuePB;

            dataGridView3.Rows[rowIndex].Cells[indexOfC].Value = valueC;
            dataGridView3.Rows[rowIndex].Cells[indexOfPB].Value = valuePB;
            dataGridView3.Rows[rowIndex].Cells[indexOfER].Value = valueER;
        }
        public class AnalisisRiesgo
        {
            public string Analista { get; set; }
            public string Activo { get; set; }
            public string Riesgo { get; set; }
            public string Dano { get; set; }
            public string Clasificacion { get; set; }
            public int S { get; set; }
            public int F { get; set; }
            public int P { get; set; }
            public int A { get; set; }
            public int V { get; set; }
            public int E { get; set; }
            public int CR { get; set; }
            public int Pb { get; set; }
            public int ER { get; set; }
        }

        private void BtnGuardar3_Click(object sender, EventArgs e)
        {
            if (dataGridFase4.Rows.Count < dataGridView3.Rows.Count)
            {
                dataGridFase4.Rows.Add();
            }
            for (int i = 0; i < dataGridView3.Rows.Count-1;i++)
            {
                var dtgvClassRows = dataGridFase4.Rows[i];
                var dtgvEvaluationRows = dataGridView3.Rows[i];

                dtgvClassRows.Cells[0].Value = dtgvEvaluationRows.Cells[1].Value;
                dtgvClassRows.Cells[1].Value = dtgvEvaluationRows.Cells[2].Value;
                dtgvClassRows.Cells[2].Value = dtgvEvaluationRows.Cells[5].Value;

                DataGridViewCell ERValue = dataGridFase4.Rows[i].Cells[2];
                DataGridViewRow ClassRow = dataGridFase4.Rows[i];
            
            if (Convert.ToInt32(ERValue.Value) >= 2 && Convert.ToInt32(ERValue.Value) <= 250)

            {
                ClassRow.Cells[3].Value = "Muy Pequeño";
                ClassRow.Cells[3].Style.BackColor = Color.Lime;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 251 && Convert.ToInt32(ERValue.Value) <= 500)
            {
                ClassRow.Cells[3].Value = "Pequeño";
                ClassRow.Cells[3].Style.BackColor = Color.LimeGreen;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 501 && Convert.ToInt32(ERValue.Value) <= 750)
            {
                ClassRow.Cells[3].Value = "Normal";
                ClassRow.Cells[3].Style.BackColor = Color.Yellow;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 751 && Convert.ToInt32(ERValue.Value) <= 1000)
            {
                ClassRow.Cells[3].Value = "Grande";
                ClassRow.Cells[3].Style.BackColor = Color.Orange;
            }
            else if (Convert.ToInt32(ERValue.Value) >= 1001 && Convert.ToInt32(ERValue.Value) <= 1250)
            {
                ClassRow.Cells[3].Value = "Elevado";
                ClassRow.Cells[3].Style.BackColor = Color.Red;
            }
        }
        }

        private void Analista3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                if (column.Name != "S" && column.Name != "F" && column.Name != "P" &&
                    column.Name != "A" && column.Name != "V" && column.Name != "E")
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cellValues = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.ColumnIndex >= 4)
            {
                if (int.TryParse(cellValues.Value?.ToString(), out int numericValue))
                {
                    switch (numericValue)
                    {
                        case 1:
                            cellValues.Style.BackColor = Color.Lime;
                            break;
                        case 2:
                            cellValues.Style.BackColor = Color.LimeGreen;
                            break;
                        case 3:
                            cellValues.Style.BackColor = Color.Yellow;
                            break;
                        case 4:
                            cellValues.Style.BackColor = Color.Orange;
                            break;
                        case 5:
                            cellValues.Style.BackColor = Color.Red;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}













