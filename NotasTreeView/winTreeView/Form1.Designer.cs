namespace winTreeView
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
            this.ssMensaje = new System.Windows.Forms.StatusStrip();
            this.stlMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnElemento = new System.Windows.Forms.Button();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnNodo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.treeNodos = new System.Windows.Forms.TreeView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarElem = new System.Windows.Forms.Button();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ssMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMensaje
            // 
            this.ssMensaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlMensaje});
            this.ssMensaje.Location = new System.Drawing.Point(0, 410);
            this.ssMensaje.Name = "ssMensaje";
            this.ssMensaje.Size = new System.Drawing.Size(786, 22);
            this.ssMensaje.TabIndex = 34;
            this.ssMensaje.Text = "statusStrip1";
            // 
            // stlMensaje
            // 
            this.stlMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.stlMensaje.ForeColor = System.Drawing.Color.Red;
            this.stlMensaje.Name = "stlMensaje";
            this.stlMensaje.Size = new System.Drawing.Size(0, 17);
            // 
            // btnElemento
            // 
            this.btnElemento.Enabled = false;
            this.btnElemento.Location = new System.Drawing.Point(174, 1);
            this.btnElemento.Name = "btnElemento";
            this.btnElemento.Size = new System.Drawing.Size(91, 23);
            this.btnElemento.TabIndex = 33;
            this.btnElemento.Text = "Añadir elemento";
            this.btnElemento.UseVisualStyleBackColor = true;
            this.btnElemento.Click += new System.EventHandler(this.btnElemento_Click);
            // 
            // txtElemento
            // 
            this.txtElemento.Font = new System.Drawing.Font("Californian FB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento.Location = new System.Drawing.Point(142, 80);
            this.txtElemento.Multiline = true;
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(404, 44);
            this.txtElemento.TabIndex = 32;
            // 
            // btnNodo
            // 
            this.btnNodo.Location = new System.Drawing.Point(5, 1);
            this.btnNodo.Name = "btnNodo";
            this.btnNodo.Size = new System.Drawing.Size(76, 23);
            this.btnNodo.TabIndex = 30;
            this.btnNodo.Text = "Añadir nodo";
            this.btnNodo.UseVisualStyleBackColor = true;
            this.btnNodo.Click += new System.EventHandler(this.btnNodo_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Añada un nombre al Folder";
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(329, 32);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(94, 20);
            this.txtNodo.TabIndex = 28;
            // 
            // lstElementos
            // 
            this.lstElementos.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.HorizontalScrollbar = true;
            this.lstElementos.ItemHeight = 20;
            this.lstElementos.Location = new System.Drawing.Point(145, 157);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(627, 164);
            this.lstElementos.TabIndex = 25;
            // 
            // treeNodos
            // 
            this.treeNodos.Location = new System.Drawing.Point(0, 30);
            this.treeNodos.Name = "treeNodos";
            this.treeNodos.Size = new System.Drawing.Size(136, 375);
            this.treeNodos.TabIndex = 24;
            this.treeNodos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNodos_AfterSelect);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(378, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 23);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarElem
            // 
            this.btnEliminarElem.Location = new System.Drawing.Point(271, 1);
            this.btnEliminarElem.Name = "btnEliminarElem";
            this.btnEliminarElem.Size = new System.Drawing.Size(101, 23);
            this.btnEliminarElem.TabIndex = 36;
            this.btnEliminarElem.Text = "Eliminar elemento";
            this.btnEliminarElem.UseVisualStyleBackColor = true;
            this.btnEliminarElem.Click += new System.EventHandler(this.btnEliminarElem_Click);
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.Location = new System.Drawing.Point(87, 1);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(81, 23);
            this.btnEliminarNodo.TabIndex = 35;
            this.btnEliminarNodo.Text = "Eliminar nodo";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Notebook";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Asunto";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Visualizar Mensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssMensaje);
            this.Controls.Add(this.btnElemento);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.btnNodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.treeNodos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarElem);
            this.Controls.Add(this.btnEliminarNodo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ssMensaje.ResumeLayout(false);
            this.ssMensaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMensaje;
        private System.Windows.Forms.ToolStripStatusLabel stlMensaje;
        private System.Windows.Forms.Button btnElemento;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnNodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.TreeView treeNodos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarElem;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

