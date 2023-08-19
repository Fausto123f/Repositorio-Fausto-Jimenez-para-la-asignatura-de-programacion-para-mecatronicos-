namespace hospital_Proyecto
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener respuestas de los RadioButtons
            string frecuenciaSintomas = GetSelectedRadioButtonText(groupBox3);
            string intensidadMalestar = GetSelectedRadioButtonText(groupBox2);
            bool fumaOConsumeAlcohol = radioButton12.Checked;
            bool antecedentesMedicos = radioButton12.Checked;

            // Determinar la gravedad del problema basado en las respuestas
            int gravedad = 0; // 0: Leve, 1: Moderado, 2: Grave

            if (frecuenciaSintomas == "Constantemente" || intensidadMalestar == "Alto")
            {
                gravedad = 2; // Problema grave
            }
            else if (frecuenciaSintomas == "Semanalmente" || intensidadMalestar == "Medio")
            {
                gravedad = 1; // Problema moderado
            }
            else
            {
                gravedad = 0; // Problema leve
            }

            // Dar consejos basados en la gravedad del problema
            string consejo = "";

            if (gravedad == 0) // Problema leve
            {
                consejo = "Puede ser útil descansar y mantenerse hidratado. Si los síntomas persisten, consulte a su médico.";
                MessageBox.Show(consejo);
            }
            else if (gravedad == 1) // Problema moderado
            {
                consejo = "Le recomendamos consultar a un médico para una evaluación más detallada de sus síntomas.";
                MessageBox.Show(consejo);

            }
            else if (gravedad == 2) // Problema grave
            {
                if (fumaOConsumeAlcohol || antecedentesMedicos)
                {
                    consejo = "Es importante buscar atención médica de inmediato. Le recomendamos no demorar en contactar a un médico o acudir a la sala de emergencias.";
                    MessageBox.Show(consejo);
                }
                else
                {
                    consejo = "Dada la gravedad de los síntomas, es crucial buscar atención médica de urgencia sin demora.";
                    MessageBox.Show(consejo);
                }
            }

            // Mostrar el consejo en un Label u otro control en tu formulario

        }
        private string GetSelectedRadioButtonText(GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return "";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
