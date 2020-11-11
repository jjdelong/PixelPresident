using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            int Random;
            Random = Randomizer();
            label1.Text += Dission(Random);
            radioButton1.Text = Choice(Random, 0);
            radioButton2.Text = Choice(Random, 1);
            radioButton3.Text = Choice(Random, 2);
            radioButton4.Text = Choice(Random, 3);
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
            foreach (var item in radBtns)
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



        public static string Dission(int random)
        {
            

            string[] events = new string[4];
            events[0] = "Your country is being ravaged by a pandemic that has taken the world by a storm. How will you handle this?";
            events[1] = "Riots! Protests! The people are unhappy and have taken their issues to the streets, causing mayhem. How will you resolve this issue?";
            events[2] = "Oh no! Troops stationed at the border of another country have run into some problems with the local militias. How do you handle this conflict?";
            events[3] = "There are some policies that need to be signed. Which party do you want to sign policies for?";

            string[] passes = new string[4];
            passes[0] = "You handle the pandemic successfully and your country doesn’t suffer as badly as others.";
            passes[1] = "The people calm down and peace returns to the streets eventually.";
            passes[2] = "No war ensues, and hostilities gradually come down between you and the other country.";
            passes[3] = "The policies pass and parties are affected.";

            string[] fails = new string[4];
            fails[0] = "You failed to handle the pandemic and your popularity has been impacted drastically.";
            fails[1] = "The chaos continues as your actions fail to stop their movement.";
            fails[2] = "Regardless of your actions, the relations between you and the other country worsen and your public view is brought down even more.";
            fails[3] = "The policies pass and parties are affected.";


            string eventer =  events[random];
            //LabelValue.set(eventer);
            return eventer;
            //Label EventPopup.label1.Text = "label1";
        }

        public static int Randomizer()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 3);
            return value;
        }
        public static string Choice(int Random, int Radio)
        {
            string textvalue;
            textvalue = " ";
            string[] pandemicChoices = new string[4];
            pandemicChoices[0] = "Unify the country with a inspiring speech";
            pandemicChoices[1] = "Write some policies that will help the country deal with the pandemic";
            pandemicChoices[2] = "Call for help from another country";
            pandemicChoices[3] = "Use the power of the stock market to help buy some supplies that hospitals can use";

            string[] unrestChoices = new string[4];
            unrestChoices[0] = "Hold a press conference";
            unrestChoices[1] = "Pass a bill";
            unrestChoices[2] = "Get advice from other leaders";
            unrestChoices[3] = "Use the power of captialism!";

            string[] borderChoices = new string[4];
            borderChoices[0] = "Deliver a speech to your country to help calm the people down";
            borderChoices[1] = "Order a ceasefire";
            borderChoices[2] = "Meet with the other country leader";
            borderChoices[3] = "Embargo the other country";

            string[] policiesChoices = new string[4];
            policiesChoices[0] = "Democrat";
            policiesChoices[1] = "Republican";
            policiesChoices[2] = "Libertarian";
            policiesChoices[3] = "Green";
            if (Random == 0)
            {
                textvalue = pandemicChoices[Radio];
            }
            if (Random == 1)
            {
                textvalue = unrestChoices[Radio];
            }
            if (Random == 2)
            {
                textvalue = borderChoices[Radio];
            }
            if (Random == 3)
            {
                textvalue = policiesChoices[Radio];
            }
            return textvalue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        //public string LabelValue(string eventer)
        // {
        //get { return label1.Text; }
        //set { label1.Text = eventer; }
        // }
    }
}
