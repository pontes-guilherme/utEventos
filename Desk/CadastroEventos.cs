﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.DAO;
using Modelo.PN;


namespace Desk
{
    public partial class CadastroEventos : Form
    {
        Usuario currentUser;

        public CadastroEventos(Usuario u)
        {
            InitializeComponent();
            currentUser = u;
        }

        private void CadastroEventos_Load(object sender, EventArgs e)
        {

        }
    }
}