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

            //radioButtonSblau.ForeColor = farbe;
            //radioButtonSrot.ForeColor = farbe;
            //radioButtonSgelb.ForeColor = farbe;
            //radioButtonSviolett.ForeColor = farbe;
            //radioButtonSweiss.ForeColor = farbe;
            
            //radioButtonHhellgruen.ForeColor = farbe;
            //radioButtonHhellblau.ForeColor = farbe;
            //radioButtonHrosa.ForeColor = farbe;
            //radioButtonHgelb.ForeColor = farbe;
            //radioButtonHanthrazit.ForeColor = farbe;

            //checkBoxFett.ForeColor = farbe;
            //checkBoxKursiv.ForeColor = farbe;
            //checkBoxUnterStrichen.ForeColor = farbe;
            //checkBoxDurchgestrichen.ForeColor = farbe;


            // so ist es kürzer, da die untergeordneten sachen, von der übergeordneten übernehmen
            this.ForeColor = farbe;


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

            FontStyle test = 0; // macht doch mehr sinn lol... brauch ich unten nicht casten
            FontStyle styleToSet = FontStyle.Regular; // nch besser ist das so

            if (checkBoxFett.Checked)
            {
                style += 1;
                test += 1;

                styleToSet = FontStyle.Bold;

            }

            if (checkBoxKursiv.Checked)
            {
                style += 2;
                test += 2;

                styleToSet |= FontStyle.Italic; // bitweises Ver-ODEREN

            }

            if (checkBoxUnterStrichen.Checked)
            {
                style += 4;
                test += 4;

                styleToSet |= FontStyle.Underline;
            }

            if (checkBoxDurchgestrichen.Checked)
            {
                style += 8;
                test += 8;

                styleToSet |= FontStyle.Strikeout;
            }










           // Font fontAll = new System.Drawing.Font("Calibri", 11.25F, (System.Drawing.FontStyle)style);
           // Font fontAll = new System.Drawing.Font("Calibri", 11.25F, test);
            Font fontAll = new System.Drawing.Font("Calibri", 11.25F, styleToSet); // noch besser ist das so

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

            // wie oben auch,kann ich das font vom hauptfenster nehmen
            // da die anderen untergeordneten sachen, die font vom hauptfenster übernehmen
            // falls die default werte noch nicht geändert wurden

            //this.Font = fontAll;


        }
    }
}
