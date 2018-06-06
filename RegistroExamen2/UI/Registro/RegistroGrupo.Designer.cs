namespace RegistroExamen2.UI.Registro
{
    partial class RegistroGrupo
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
            System.Windows.Forms.Label integrantesLabel;
            System.Windows.Forms.Label gruposDeseadosLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label grupoIdLabel;
            this.GruposDUpDown = new System.Windows.Forms.NumericUpDown();
            this.CantidadUpDown = new System.Windows.Forms.NumericUpDown();
            this.GrupoIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.fechaDateTime = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.IntegrantesUpDown = new System.Windows.Forms.NumericUpDown();
            integrantesLabel = new System.Windows.Forms.Label();
            gruposDeseadosLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            grupoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GruposDUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegrantesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // integrantesLabel
            // 
            integrantesLabel.AutoSize = true;
            integrantesLabel.Location = new System.Drawing.Point(24, 234);
            integrantesLabel.Name = "integrantesLabel";
            integrantesLabel.Size = new System.Drawing.Size(63, 13);
            integrantesLabel.TabIndex = 32;
            integrantesLabel.Text = "Integrantes:";
            // 
            // GruposDUpDown
            // 
            this.GruposDUpDown.Location = new System.Drawing.Point(139, 152);
            this.GruposDUpDown.Name = "GruposDUpDown";
            this.GruposDUpDown.Size = new System.Drawing.Size(100, 20);
            this.GruposDUpDown.TabIndex = 33;
            // 
            // CantidadUpDown
            // 
            this.CantidadUpDown.Location = new System.Drawing.Point(139, 112);
            this.CantidadUpDown.Name = "CantidadUpDown";
            this.CantidadUpDown.Size = new System.Drawing.Size(100, 20);
            this.CantidadUpDown.TabIndex = 31;
            // 
            // GrupoIdUpDown
            // 
            this.GrupoIdUpDown.Location = new System.Drawing.Point(96, 14);
            this.GrupoIdUpDown.Name = "GrupoIdUpDown";
            this.GrupoIdUpDown.Size = new System.Drawing.Size(75, 20);
            this.GrupoIdUpDown.TabIndex = 30;
            // 
            // gruposDeseadosLabel
            // 
            gruposDeseadosLabel.AutoSize = true;
            gruposDeseadosLabel.Location = new System.Drawing.Point(24, 154);
            gruposDeseadosLabel.Name = "gruposDeseadosLabel";
            gruposDeseadosLabel.Size = new System.Drawing.Size(95, 13);
            gruposDeseadosLabel.TabIndex = 29;
            gruposDeseadosLabel.Text = "Grupos Deseados:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(24, 120);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 28;
            cantidadLabel.Text = "Cantidad:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(24, 195);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 26;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTime
            // 
            this.fechaDateTime.Location = new System.Drawing.Point(96, 191);
            this.fechaDateTime.Name = "fechaDateTime";
            this.fechaDateTime.Size = new System.Drawing.Size(143, 20);
            this.fechaDateTime.TabIndex = 27;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(24, 46);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 24;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(96, 43);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(184, 49);
            this.descripcionTextBox.TabIndex = 25;
            // 
            // grupoIdLabel
            // 
            grupoIdLabel.AutoSize = true;
            grupoIdLabel.Location = new System.Drawing.Point(24, 14);
            grupoIdLabel.Name = "grupoIdLabel";
            grupoIdLabel.Size = new System.Drawing.Size(51, 13);
            grupoIdLabel.TabIndex = 23;
            grupoIdLabel.Text = "Grupo Id:";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::RegistroExamen2.Properties.Resources.icons8_Search_16;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(215, 14);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(65, 23);
            this.btn_Buscar.TabIndex = 22;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = global::RegistroExamen2.Properties.Resources.icons8_Delete_Document_32;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Eliminar.Location = new System.Drawing.Point(336, 304);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(106, 55);
            this.btn_Eliminar.TabIndex = 21;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::RegistroExamen2.Properties.Resources.icons8_Save_Close_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(174, 304);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(106, 55);
            this.btn_Guardar.TabIndex = 20;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = global::RegistroExamen2.Properties.Resources.icons8_New_Copy_32;
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Nuevo.Location = new System.Drawing.Point(15, 304);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(106, 55);
            this.btn_Nuevo.TabIndex = 19;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // IntegrantesUpDown
            // 
            this.IntegrantesUpDown.Location = new System.Drawing.Point(94, 234);
            this.IntegrantesUpDown.Name = "IntegrantesUpDown";
            this.IntegrantesUpDown.Size = new System.Drawing.Size(95, 20);
            this.IntegrantesUpDown.TabIndex = 34;
            // 
            // RegistroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 379);
            this.Controls.Add(this.IntegrantesUpDown);
            this.Controls.Add(integrantesLabel);
            this.Controls.Add(this.GruposDUpDown);
            this.Controls.Add(this.CantidadUpDown);
            this.Controls.Add(this.GrupoIdUpDown);
            this.Controls.Add(gruposDeseadosLabel);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTime);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(grupoIdLabel);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Name = "RegistroGrupo";
            this.Text = "RegistroGrupo";
            ((System.ComponentModel.ISupportInitialize)(this.GruposDUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoIdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegrantesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown GruposDUpDown;
        private System.Windows.Forms.NumericUpDown CantidadUpDown;
        private System.Windows.Forms.NumericUpDown GrupoIdUpDown;
        private System.Windows.Forms.DateTimePicker fechaDateTime;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.NumericUpDown IntegrantesUpDown;
    }
}