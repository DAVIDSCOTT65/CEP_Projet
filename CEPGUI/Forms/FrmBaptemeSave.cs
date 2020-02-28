﻿using BaptemeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Forms
{
    public partial class FrmBaptemeSave : Form
    {
        public int Id = 0;
        public FrmBaptemeSave()
        {
            InitializeComponent();
        }

        private void FrmBaptemeSave_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }
        void Enregistrer()
        {
            try
            {
                DateTime datecelebr;
                datecelebr = Convert.ToDateTime(dateTxt.Text);
                if (lieuTxt.Text == "" || dateTxt.Text == "" || pastTxt.Text == "" || datecelebr < DateTime.Today)
                {
                    MessageBox.Show("Impossible d'enregistrer, Champs vides ou dates supérieur", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Bapteme b = new Bapteme();

                    b.Id = Id;
                    b.Lieu = lieuTxt.Text;
                    b.DateCelebration = Convert.ToDateTime(dateTxt.Text);
                    b.Pasteur = pastTxt.Text;

                    b.SaveDatas(b);

                    Initialise();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Initialise()
        {
            Id = 0;
            lieuTxt.Clear();
            dateTxt.Clear();
            pastTxt.Clear();
        }
    }
}
