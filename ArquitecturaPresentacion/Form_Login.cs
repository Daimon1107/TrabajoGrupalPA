﻿using ArquitecturaEntidades;
using ArquitecturaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArquitecturaPresentacion
{
    public partial class Form_Login : Form
    {
        DocenteEntidad docente = new DocenteEntidad();

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          IniciarSesión();

        }

        private void IniciarSesión() {
            docente.Usuario = textBox_Usuario.Text;
            docente.Contraseña = textBox_Contraseña.Text;
            if (ValidarInicioSesion()) {
                Form_Búsqueda búsqueda = new Form_Búsqueda(docente.Id);
                búsqueda.Show();
                this.Visible = false;

            }

        }

        private bool ValidarInicioSesion()
        {
            return DocenteNegocio.ComprobarSesiónVálida(docente);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_Usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "USUARIO:")
            {
                textBox_Usuario.Text = "";
                textBox_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void textBox_Usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "")
            {
                textBox_Usuario.Text = "USUARIO:";
                textBox_Usuario.ForeColor = Color.DimGray;
            }
        }

        private void textBox_Contraseña_Enter(object sender, EventArgs e)
        {
            if (textBox_Contraseña.Text == "CONTRASEÑA:") {
                textBox_Contraseña.Text = "";
                textBox_Contraseña.ForeColor = Color.Red;
                textBox_Contraseña.UseSystemPasswordChar = true;

            }
        }

        private void textBox_Contraseña_Leave(object sender, EventArgs e)
        {
            if (textBox_Contraseña.Text == "")
            {
                textBox_Contraseña.Text = "CONTRASEÑA:";
                textBox_Contraseña.ForeColor = Color.DimGray;
                textBox_Contraseña.UseSystemPasswordChar = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Estudiante búsqueda = new Form_Estudiante();
            búsqueda.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Carrera carrera = new Form_Carrera();
            carrera.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form_Facultad facultad = new Form_Facultad();
            facultad.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Docente docente= new Form_Docente();
            docente.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_Menu menu= new Form_Menu();
            menu.Show();
            this.Visible = false;

        }
    }
}
