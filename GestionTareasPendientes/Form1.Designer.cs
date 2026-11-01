namespace GestionTareasPendientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTarea;
        private Button btnAgregarTarea;
        private Label lblListaTareas;
        private ListBox lstTareas;
        private Button btnEliminarTarea;
        private Button btnLimpiarLista;

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
            txtTarea = new TextBox();
            btnAgregarTarea = new Button();
            lblListaTareas = new Label();
            lstTareas = new ListBox();
            btnEliminarTarea = new Button();
            btnLimpiarLista = new Button();
            SuspendLayout();
            // 
            // txtTarea
            // 
            txtTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTarea.Location = new Point(12, 12);
            txtTarea.Name = "txtTarea";
            txtTarea.PlaceholderText = "Escribe una tarea";
            txtTarea.Size = new Size(776, 27);
            txtTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(12, 52);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(150, 32);
            btnAgregarTarea.TabIndex = 1;
            btnAgregarTarea.Text = "Agregar Tarea";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // lblListaTareas
            // 
            lblListaTareas.AutoSize = true;
            lblListaTareas.Location = new Point(12, 87);
            lblListaTareas.Name = "lblListaTareas";
            lblListaTareas.Size = new Size(113, 20);
            lblListaTareas.TabIndex = 5;
            lblListaTareas.Text = "Lista de Tareas";
            // 
            // lstTareas
            // 
            lstTareas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTareas.FormattingEnabled = true;
            lstTareas.Location = new Point(12, 110);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(776, 254);
            lstTareas.TabIndex = 2;
            lstTareas.SelectedIndexChanged += lstTareas_SelectedIndexChanged;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarTarea.Location = new Point(12, 385);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(150, 32);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar Tarea";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // btnLimpiarLista
            // 
            btnLimpiarLista.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiarLista.Location = new Point(168, 385);
            btnLimpiarLista.Name = "btnLimpiarLista";
            btnLimpiarLista.Size = new Size(150, 32);
            btnLimpiarLista.TabIndex = 4;
            btnLimpiarLista.Text = "Limpiar Lista";
            btnLimpiarLista.UseVisualStyleBackColor = true;
            btnLimpiarLista.Click += btnLimpiarLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiarLista);
            Controls.Add(btnEliminarTarea);
            Controls.Add(lstTareas);
            Controls.Add(lblListaTareas);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtTarea);
            MinimumSize = new Size(450, 350);
            Name = "Form1";
            Text = "Gestión de Tareas Pendientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
