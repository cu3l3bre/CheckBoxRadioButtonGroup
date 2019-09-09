using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxRadioButtonGroup
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            setHintergrundFarbe(Color.LightSkyBlue);
            setSchriftFarbe(Color.White);
        }


        // Buttons
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Radio Buttons für Hintergrundfarbe
        private void RadioButtonHhellgruen_CheckedChanged(object sender, EventArgs e)
        {
            setHintergrundFarbe(Color.LightGreen);
        }

        private void RadioButtonHhellblau_CheckedChanged(object sender, EventArgs e)
        {
            setHintergrundFarbe(Color.LightSkyBlue);
        }

        private void RadioButtonHrosa_CheckedChanged(object sender, EventArgs e)
        {
            setHintergrundFarbe(Color.LightPink);
        }

        private void RadioButtonHgelb_CheckedChanged(object sender, EventArgs e)
        {
            setHintergrundFarbe(Color.Yellow);
        }


        private void RadioButtonHanthrazit_CheckedChanged(object sender, EventArgs e)
        {
            setHintergrundFarbe(Color.Gray);
        }


        // Radio Buttons für Schriftfarbe
        private void RadioButtonSBlau_CheckedChanged(object sender, EventArgs e)
        {
            setSchriftFarbe(Color.Blue);
        }

        private void RadioButtonSRot_CheckedChanged(object sender, EventArgs e)
        {
            setSchriftFarbe(Color.Red);
        }

        private void RadioButtonSgelb_CheckedChanged(object sender, EventArgs e)
        {
            setSchriftFarbe(Color.Yellow);
        }

        private void RadioButtonSviolett_CheckedChanged(object sender, EventArgs e)
        {
            setSchriftFarbe(Color.Violet);
        }

        private void RadioButtonSweiss_CheckedChanged(object sender, EventArgs e)
        {
            setSchriftFarbe(Color.White);
        }



        // Methode zum Setzen der Hintergrundfarbe des Hauptfensters
        private void setHintergrundFarbe(Color farbe)
        {
            if (farbe == Color.Yellow)
            {
                radioButtonSgelb.Enabled = false;
            }
            else
            {
                radioButtonSgelb.Enabled = true;
            }

            this.BackColor = farbe;
        }


        // Methode zum Setzen der Schriftfarbe
        private void setSchriftFarbe(Color farbe)
        {

            if(farbe == Color.Yellow)
            {
                radioButtonHgelb.Enabled = false;
            }
            else
            {
                radioButtonHgelb.Enabled = true;
            }

            radioButtonSblau.ForeColor = farbe;
            radioButtonSrot.ForeColor = farbe;
            radioButtonSgelb.ForeColor = farbe;
            radioButtonSviolett.ForeColor = farbe;
            radioButtonSweiss.ForeColor = farbe;
            
            radioButtonHhellgruen.ForeColor = farbe;
            radioButtonHhellblau.ForeColor = farbe;
            radioButtonHrosa.ForeColor = farbe;
            radioButtonHgelb.ForeColor = farbe;
            radioButtonHanthrazit.ForeColor = farbe;

            checkBoxFett.ForeColor = farbe;
            checkBoxKursiv.ForeColor = farbe;
            checkBoxUnterStrichen.ForeColor = farbe;
            checkBoxDurchgestrichen.ForeColor = farbe;
        }

        // Methode zum Setzen des Fonts
        private void setFont(object sender, EventArgs e)
        {
            //System.Drawing.FontStyle.Regular == 0;
            //System.Drawing.FontStyle.Bold == 1;
            //System.Drawing.FontStyle.Italic == 2;
            //System.Drawing.FontStyle.Underline == 4;
            //System.Drawing.FontStyle.Strikeout == 8

            byte style = 0;
           // byte test = 0b1111;

            if (checkBoxFett.Checked)
            {
                style += 1;
            }

            if (checkBoxKursiv.Checked)
            {
                style += 2;
            }

            if (checkBoxUnterStrichen.Checked)
            {
                style += 4;
            }

            if (checkBoxDurchgestrichen.Checked)
            {
                style += 8;
            }

            Font fontAll = new System.Drawing.Font("Calibri", 11.0F, (System.Drawing.FontStyle)style);

            buttonClose.Font = fontAll;

            checkBoxUnterStrichen.Font = fontAll;
            checkBoxFett.Font = fontAll;
            checkBoxKursiv.Font = fontAll;
            checkBoxDurchgestrichen.Font = fontAll;

            radioButtonHanthrazit.Font = fontAll;
            radioButtonHgelb.Font = fontAll;
            radioButtonHrosa.Font = fontAll;
            radioButtonHhellgruen.Font = fontAll;
            radioButtonHhellblau.Font = fontAll;

            radioButtonSrot.Font = fontAll;
            radioButtonSblau.Font = fontAll;
            radioButtonSgelb.Font = fontAll;
            radioButtonSviolett.Font = fontAll;
            radioButtonSweiss.Font = fontAll;

        }
    }
}
