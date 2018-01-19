namespace Sqlite
{
    partial class FormAsueto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.pruebaDataSet3 = new Sqlite.PruebaDataSet3();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new Sqlite.PruebaDataSet3TableAdapters.PersonaTableAdapter();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.personaNombreCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaDataSet4 = new Sqlite.PruebaDataSet4();
            this.personaNombreCompletoTableAdapter = new Sqlite.PruebaDataSet4TableAdapters.personaNombreCompletoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaNombreCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Asueto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Fin";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "B",
            "V",
            "P"});
            this.cbTipo.Location = new System.Drawing.Point(536, 55);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(42, 21);
            this.cbTipo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo";
            // 
            // dpFechaFin
            // 
            this.dpFechaFin.Location = new System.Drawing.Point(320, 56);
            this.dpFechaFin.Name = "dpFechaFin";
            this.dpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dpFechaFin.TabIndex = 6;
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(97, 56);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dpFechaInicio.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 55);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(79, 20);
            this.txtId.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnCargar.Location = new System.Drawing.Point(341, 95);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(422, 95);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(503, 95);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(15, 133);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(566, 171);
            this.dgvDatos.TabIndex = 12;
            // 
            // pruebaDataSet3
            // 
            this.pruebaDataSet3.DataSetName = "PruebaDataSet3";
            this.pruebaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.pruebaDataSet3;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // cbPersona
            // 
            this.cbPersona.DataSource = this.personaNombreCompletoBindingSource;
            this.cbPersona.DisplayMember = "nombreCompleto";
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Location = new System.Drawing.Point(15, 97);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(299, 21);
            this.cbPersona.TabIndex = 13;
            this.cbPersona.ValueMember = "id";
            // 
            // personaNombreCompletoBindingSource
            // 
            this.personaNombreCompletoBindingSource.DataMember = "personaNombreCompleto";
            this.personaNombreCompletoBindingSource.DataSource = this.pruebaDataSet4;
            // 
            // pruebaDataSet4
            // 
            this.pruebaDataSet4.DataSetName = "PruebaDataSet4";
            this.pruebaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaNombreCompletoTableAdapter
            // 
            this.personaNombreCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // FormAsueto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 321);
            this.Controls.Add(this.cbPersona);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dpFechaInicio);
            this.Controls.Add(this.dpFechaFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAsueto";
            this.Text = "FormAsueto";
            this.Load += new System.EventHandler(this.FormAsueto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaNombreCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpFechaFin;
        private System.Windows.Forms.DateTimePicker dpFechaInicio;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private PruebaDataSet3 pruebaDataSet3;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private PruebaDataSet3TableAdapters.PersonaTableAdapter personaTableAdapter;
        private System.Windows.Forms.ComboBox cbPersona;
        private PruebaDataSet4 pruebaDataSet4;
        private System.Windows.Forms.BindingSource personaNombreCompletoBindingSource;
        private PruebaDataSet4TableAdapters.personaNombreCompletoTableAdapter personaNombreCompletoTableAdapter;
    }
}