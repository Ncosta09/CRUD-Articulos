﻿namespace CRUD
{
    partial class frmEliminarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarCategoria));
            this.lblMarcasViejas = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.pnlDeco = new System.Windows.Forms.Panel();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.tbxEliminarCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminarMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.pnlDeco.SuspendLayout();
            this.pnlMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMarcasViejas
            // 
            this.lblMarcasViejas.AutoSize = true;
            this.lblMarcasViejas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarcasViejas.Location = new System.Drawing.Point(662, 171);
            this.lblMarcasViejas.Name = "lblMarcasViejas";
            this.lblMarcasViejas.Size = new System.Drawing.Size(89, 18);
            this.lblMarcasViejas.TabIndex = 14;
            this.lblMarcasViejas.Text = "Categorias:";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(665, 191);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(451, 226);
            this.dgvCategorias.TabIndex = 13;
            this.dgvCategorias.Click += new System.EventHandler(this.dgvCategorias_Click);
            // 
            // pnlDeco
            // 
            this.pnlDeco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlDeco.Controls.Add(this.pnlMarca);
            this.pnlDeco.Location = new System.Drawing.Point(45, -1);
            this.pnlDeco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDeco.Name = "pnlDeco";
            this.pnlDeco.Size = new System.Drawing.Size(496, 620);
            this.pnlDeco.TabIndex = 12;
            // 
            // pnlMarca
            // 
            this.pnlMarca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMarca.Controls.Add(this.tbxEliminarCategoria);
            this.pnlMarca.Controls.Add(this.btnEliminar);
            this.pnlMarca.Controls.Add(this.label1);
            this.pnlMarca.Location = new System.Drawing.Point(109, 192);
            this.pnlMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(265, 177);
            this.pnlMarca.TabIndex = 0;
            // 
            // tbxEliminarCategoria
            // 
            this.tbxEliminarCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEliminarCategoria.Location = new System.Drawing.Point(13, 48);
            this.tbxEliminarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEliminarCategoria.Name = "tbxEliminarCategoria";
            this.tbxEliminarCategoria.ReadOnly = true;
            this.tbxEliminarCategoria.Size = new System.Drawing.Size(233, 22);
            this.tbxEliminarCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 7.8F);
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(76, 136);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 34);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblEliminarMarca
            // 
            this.lblEliminarMarca.AutoSize = true;
            this.lblEliminarMarca.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblEliminarMarca.Location = new System.Drawing.Point(1033, 11);
            this.lblEliminarMarca.Name = "lblEliminarMarca";
            this.lblEliminarMarca.Size = new System.Drawing.Size(233, 30);
            this.lblEliminarMarca.TabIndex = 11;
            this.lblEliminarMarca.Text = "Eliminar Categoria";
            // 
            // frmEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 618);
            this.Controls.Add(this.lblMarcasViejas);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.pnlDeco);
            this.Controls.Add(this.lblEliminarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEliminarCategoria";
            this.Text = "frmEliminarCategoria";
            this.Load += new System.EventHandler(this.frmEliminarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.pnlDeco.ResumeLayout(false);
            this.pnlMarca.ResumeLayout(false);
            this.pnlMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcasViejas;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Panel pnlDeco;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.TextBox tbxEliminarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminarMarca;
    }
}