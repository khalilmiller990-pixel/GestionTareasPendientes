namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstTareas.Items.Clear();
            ActualizarEstadoBotones();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text.Trim();

            if (string.IsNullOrEmpty(tarea))
            {
                MessageBox.Show(
                    "Escribe una tarea antes de agregarla.",
                    "Tarea no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTarea.Focus();
                return;
            }

            lstTareas.Items.Add(tarea);
            txtTarea.Clear();
            txtTarea.Focus();
            ActualizarEstadoBotones();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Selecciona una tarea para eliminarla.",
                    "Ninguna tarea seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
            ActualizarEstadoBotones();
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            if (lstTareas.Items.Count == 0)
            {
                return;
            }

            lstTareas.Items.Clear();
            ActualizarEstadoBotones();
        }

        private void ActualizarEstadoBotones()
        {
            bool hayTareas = lstTareas.Items.Count > 0;
            btnEliminarTarea.Enabled = hayTareas;
            btnLimpiarLista.Enabled = hayTareas;
        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
