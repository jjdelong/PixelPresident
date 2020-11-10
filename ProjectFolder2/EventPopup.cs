using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackStreet
{
    public partial class EventPopup : Form
    {
        public EventPopup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int errctr = 0;

            //radio buttons array 
            RadioButton[] radBtns = { radioButton1, radioButton2, radioButton3, radioButton4 };


            errctr += CType(radBtns);


            //used to represent radio button that is selected

            if (errctr == 0)
            {
                string ctype = " ";

                foreach (var pBtn in radBtns)
                {
                    if (pBtn.Checked)
                    {
                        ctype = Convert.ToString(pBtn.Text);
                        break;
                    }
                }

            }
            this.Close();
        }
        RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }


        private int CType(RadioButton[] radBtns)
        {
            int errors = 0;
            bool selected = false;
            foreach(var item in radBtns)
            {
                if (item.Checked)
                {
                    selected = true;
                    break;
                }
            }
            if (!selected)
            {
                MessageBox.Show("No part was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            return errors;
           // throw new NotImplementedException();
        }
    }
}
