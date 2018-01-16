namespace Sqlite
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaDataSet = new Sqlite.PruebaDataSet();
            this.categoriaTableAdapter = new Sqlite.PruebaDataSetTableAdapters.CategoriaTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.pruebaDataSet2 = new Sqlite.PruebaDataSet2();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personaTableAdapter = new Sqlite.PruebaDataSet2TableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cod. Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Materno";
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Location = new System.Drawing.Point(570, 52);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(56, 17);
            this.cbActivo.TabIndex = 5;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(70, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(314, 53);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(120, 20);
            this.txtPaterno.TabIndex = 8;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(440, 53);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(124, 20);
            this.txtMaterno.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 167);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_RowEnter);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(15, 115);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(470, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(551, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(383, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 53);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(49, 20);
            this.txtId.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Id";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DataSource = this.categoriaBindingSource;
            this.cbCategoria.DisplayMember = "nombre";
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(70, 78);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(185, 21);
            this.cbCategoria.TabIndex = 17;
            this.cbCategoria.ValueMember = "id";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.pruebaDataSet;
            // 
            // pruebaDataSet
            // 
            this.pruebaDataSet.DataSetName = "PruebaDataSet";
            this.pruebaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Categoria";
            // 
            // pruebaDataSet2
            // 
            this.pruebaDataSet2.DataSetName = "PruebaDataSet2";
            this.pruebaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataMember = "Persona";
            this.personaBindingSource.DataSource = this.pruebaDataSet2;
            // 
            // personaTableAdapter
            // 
            this.personaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 344);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategoria;
        private PruebaDataSet pruebaDataSet;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private PruebaDataSetTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Label label7;
        private PruebaDataSet2 pruebaDataSet2;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private PruebaDataSet2TableAdapters.PersonaTableAdapter personaTableAdapter;
    }
}

