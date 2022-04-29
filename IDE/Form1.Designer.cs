namespace IDE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abirirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fases = new System.Windows.Forms.TextBox();
            this.code_Inter = new System.Windows.Forms.Button();
            this.fase_Semantico = new System.Windows.Forms.Button();
            this.fase_Sintactico = new System.Windows.Forms.Button();
            this.faseLexico = new System.Windows.Forms.Button();
            this.group_error = new System.Windows.Forms.GroupBox();
            this.errorPanel = new System.Windows.Forms.TextBox();
            this.resultados = new System.Windows.Forms.Button();
            this.errores = new System.Windows.Forms.Button();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.group_error.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ajustesToolStripMenuItem,
            this.ejecutarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abirirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abirirToolStripMenuItem
            // 
            this.abirirToolStripMenuItem.Name = "abirirToolStripMenuItem";
            this.abirirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abirirToolStripMenuItem.Text = "Abirir";
            this.abirirToolStripMenuItem.Click += new System.EventHandler(this.abirirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.copiarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // ajustesToolStripMenuItem
            // 
            this.ajustesToolStripMenuItem.Name = "ajustesToolStripMenuItem";
            this.ajustesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ajustesToolStripMenuItem.Text = "Ajustes";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // editor
            // 
            this.editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.editor.AutoScrollMinSize = new System.Drawing.Size(27, 17);
            this.editor.BackBrush = null;
            this.editor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.editor.BookmarkColor = System.Drawing.Color.PaleTurquoise;
            this.editor.CharHeight = 17;
            this.editor.CharWidth = 8;
            this.editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor.FoldingIndicatorColor = System.Drawing.Color.Navy;
            this.editor.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.editor.ForeColor = System.Drawing.Color.Purple;
            this.editor.IndentBackColor = System.Drawing.Color.Black;
            this.editor.IsReplaceMode = false;
            this.editor.Location = new System.Drawing.Point(0, 31);
            this.editor.Name = "editor";
            this.editor.Paddings = new System.Windows.Forms.Padding(0);
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("editor.ServiceColors")));
            this.editor.Size = new System.Drawing.Size(559, 343);
            this.editor.TabIndex = 1;
            this.editor.Zoom = 100;
            this.editor.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fases);
            this.groupBox1.Controls.Add(this.code_Inter);
            this.groupBox1.Controls.Add(this.fase_Semantico);
            this.groupBox1.Controls.Add(this.fase_Sintactico);
            this.groupBox1.Controls.Add(this.faseLexico);
            this.groupBox1.Location = new System.Drawing.Point(565, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 343);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fases
            // 
            this.fases.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fases.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fases.ForeColor = System.Drawing.Color.DarkOrchid;
            this.fases.Location = new System.Drawing.Point(0, 33);
            this.fases.Multiline = true;
            this.fases.Name = "fases";
            this.fases.Size = new System.Drawing.Size(511, 304);
            this.fases.TabIndex = 4;
            // 
            // code_Inter
            // 
            this.code_Inter.Location = new System.Drawing.Point(383, 10);
            this.code_Inter.Name = "code_Inter";
            this.code_Inter.Size = new System.Drawing.Size(128, 23);
            this.code_Inter.TabIndex = 3;
            this.code_Inter.Text = "Codigo intermedio";
            this.code_Inter.UseVisualStyleBackColor = true;
            // 
            // fase_Semantico
            // 
            this.fase_Semantico.Location = new System.Drawing.Point(257, 10);
            this.fase_Semantico.Name = "fase_Semantico";
            this.fase_Semantico.Size = new System.Drawing.Size(132, 23);
            this.fase_Semantico.TabIndex = 2;
            this.fase_Semantico.Text = "Semantico";
            this.fase_Semantico.UseVisualStyleBackColor = true;
            // 
            // fase_Sintactico
            // 
            this.fase_Sintactico.Location = new System.Drawing.Point(127, 10);
            this.fase_Sintactico.Name = "fase_Sintactico";
            this.fase_Sintactico.Size = new System.Drawing.Size(133, 23);
            this.fase_Sintactico.TabIndex = 1;
            this.fase_Sintactico.Text = "Sintatico";
            this.fase_Sintactico.UseVisualStyleBackColor = true;
            // 
            // faseLexico
            // 
            this.faseLexico.Location = new System.Drawing.Point(0, 10);
            this.faseLexico.Name = "faseLexico";
            this.faseLexico.Size = new System.Drawing.Size(131, 23);
            this.faseLexico.TabIndex = 0;
            this.faseLexico.Text = "Lexico";
            this.faseLexico.UseVisualStyleBackColor = true;
            this.faseLexico.Click += new System.EventHandler(this.faseLexico_Click);
            // 
            // group_error
            // 
            this.group_error.Controls.Add(this.errorPanel);
            this.group_error.Controls.Add(this.resultados);
            this.group_error.Controls.Add(this.errores);
            this.group_error.Location = new System.Drawing.Point(12, 376);
            this.group_error.Name = "group_error";
            this.group_error.Size = new System.Drawing.Size(1058, 207);
            this.group_error.TabIndex = 3;
            this.group_error.TabStop = false;
            this.group_error.Enter += new System.EventHandler(this.group_error_Enter);
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.errorPanel.Location = new System.Drawing.Point(0, 30);
            this.errorPanel.Multiline = true;
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(1052, 171);
            this.errorPanel.TabIndex = 2;
            // 
            // resultados
            // 
            this.resultados.Location = new System.Drawing.Point(96, 10);
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(99, 23);
            this.resultados.TabIndex = 1;
            this.resultados.Text = "Resultados";
            this.resultados.UseVisualStyleBackColor = true;
            // 
            // errores
            // 
            this.errores.Location = new System.Drawing.Point(0, 10);
            this.errores.Name = "errores";
            this.errores.Size = new System.Drawing.Size(99, 23);
            this.errores.TabIndex = 0;
            this.errores.Text = "Errores";
            this.errores.UseVisualStyleBackColor = true;
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1088, 595);
            this.Controls.Add(this.group_error);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IDE CaPi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_error.ResumeLayout(false);
            this.group_error.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abirirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FastColoredTextBoxNS.FastColoredTextBox editor;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fases;
        private System.Windows.Forms.Button code_Inter;
        private System.Windows.Forms.Button fase_Semantico;
        private System.Windows.Forms.Button fase_Sintactico;
        private System.Windows.Forms.Button faseLexico;
        private System.Windows.Forms.GroupBox group_error;
        private System.Windows.Forms.Button errores;
        private System.Windows.Forms.Button resultados;
        private System.Windows.Forms.TextBox errorPanel;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    }
}

