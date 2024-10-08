﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(frmVerTodos))
                {
                    return;
                }
            }
            */

            frmVerTodos ventana = new frmVerTodos();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }

        private void busquedaAvanzadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerTodos ventana = new frmVerTodos();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar ventana = new frmAgregar();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar ventana = new frmEliminar();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }

        private void agregarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarMarca ventana = new frmAgregarMarca();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }

        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarMarca ventana = new frmEliminarMarca();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }

        private void agregarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ventana = new frmAgregarCategoria();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }

        private void eliminarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarCategoria ventana = new frmEliminarCategoria();
            ventana.MdiParent = this;
            ventana.Dock = DockStyle.Fill;
            ventana.Show();
        }
    }
}
