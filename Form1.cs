using System.DirectoryServices.ActiveDirectory;

namespace MIDTERM_ACT9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool MochaReady = false;
        public bool CappReady = false;
        public bool JellyReady = false;
        public bool JavaReady = false;

        public void isReady(Button button1, Button button2, bool coffeeReady)
        {
            if (coffeeReady == true)
            {
                button1.Enabled = true;
                button2.Enabled = true;

                button1.BackColor = Color.FromArgb(133, 79, 53);
                button2.BackColor = Color.FromArgb(133, 79, 53);
            }

        }

        public void notReady(Button button1, Button button2)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button2.BackColor = Color.FromArgb(224, 224, 224);
        }



        public int Xmocha;
        public int Xcapp;
        public int Xjelly;
        public int Xjava;

        public int Ymocha;
        public int Ycapp;
        public int Yjelly;
        public int Yjava;



        public int QtyMocha;
        public int QtyCapp;
        public int QtyJelly;
        public int QtyJava;


        public string TypeMocha = "";
        public string TypeCapp = "";
        public string TypeJelly = "";
        public string TypeJava = "";



        private void comboBoxMochaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false)
            {
                isReady(buttonMochaAdd, buttonMochaLess, MochaReady);
                MochaReady = true;

                Xmocha = 0;
                Ymocha = comboBoxMochaSize.SelectedIndex;

                callClass(textBoxMochaQty, labelMochaPrice, Xmocha, Ymocha, TypeMocha);
            }

            
        }

        private void comboBoxMochaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false)
            {
                isReady(buttonMochaAdd, buttonMochaLess, MochaReady);
                MochaReady = true;

                TypeMocha = comboBoxMochaType.GetItemText(comboBoxMochaType.SelectedItem);
                callClass(textBoxMochaQty, labelMochaPrice, Xmocha, Ymocha, TypeMocha);
            }

        }

        private void comboBoxCappSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false) 
            { 
            isReady(buttonCappAdd, buttonCappLess, CappReady);
            CappReady = true;

                Xcapp = 1;
                Ycapp = comboBoxCappSize.SelectedIndex;
                callClass(textBoxCappQty, labelCappPrice, Xcapp, Ycapp, TypeCapp);
            }

        }

        private void comboBoxCappType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false) 
            {
            isReady(buttonCappAdd, buttonCappLess, CappReady);
            CappReady = true;

                TypeCapp = comboBoxCappType.GetItemText(comboBoxCappType.SelectedItem);
                callClass(textBoxCappQty, labelCappPrice, Xcapp, Ycapp, TypeCapp);
            }


        }

        private void comboBoxJellySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false) 
            {
            isReady(buttonJellyAdd, buttonJellyLess, JellyReady);
                JellyReady = true;

                Xjelly = 2;
                Yjelly = comboBoxJellySize.SelectedIndex;
                callClass(textBoxJellyQty, labelJellyPrice, Xjelly, Yjelly, TypeJelly);
            }
;
        }

        private void comboBoxJellyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false) 
            {
            isReady(buttonJellyAdd, buttonJellyLess, JellyReady);
            JellyReady = true;

                TypeJelly = comboBoxJellyType.GetItemText(comboBoxJellyType.SelectedItem);
                callClass(textBoxJellyQty, labelJellyPrice, Xjelly, Yjelly, TypeJelly);
            }

        }

        private void comboBoxJavaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false) 
            {
            isReady(buttonJavaAdd, buttonJavaLess, JavaReady);
            JavaReady = true;

                Xjava = 3;
                Yjava = comboBoxJavaSize.SelectedIndex;
                callClass(textBoxJavaQty, labelJavaPrice, Xjava, Yjava, TypeJava);
            }

        }

        private void comboBoxJavaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (justClearing == false)
            {
            isReady(buttonJavaAdd, buttonJavaLess, JavaReady);
            JavaReady = true;

                TypeJava = comboBoxJavaType.GetItemText(comboBoxJavaType.SelectedItem);
                callClass(textBoxJavaQty, labelJavaPrice, Xjava, Yjava, TypeJava);
            }

        }


        public void addQty(Button button, TextBox txt)
        {

            int qty = int.Parse(txt.Text) + 1;
            txt.Text = qty.ToString();
        }

        public void lessQty(Button button, TextBox txt)
        {
            if (int.Parse(txt.Text) != 0)
            {
                int qty = int.Parse(txt.Text) - 1;
                txt.Text = qty.ToString();
            }
        }


        private void buttonMochaAdd_Click(object sender, EventArgs e)
        {
            addQty(buttonMochaAdd, textBoxMochaQty);
        }

        private void buttonMochaLess_Click(object sender, EventArgs e)
        {
            lessQty(buttonMochaLess, textBoxMochaQty);
        }

        private void buttonCappAdd_Click(object sender, EventArgs e)
        {
            addQty(buttonCappAdd, textBoxCappQty);
        }

        private void buttonCappLess_Click(object sender, EventArgs e)
        {
            lessQty(buttonCappLess, textBoxCappQty);
        }

        private void buttonJellyAdd_Click(object sender, EventArgs e)
        {
            addQty(buttonJellyAdd, textBoxJellyQty);
        }

        private void buttonJellyLess_Click(object sender, EventArgs e)
        {
            lessQty(buttonJellyLess, textBoxJellyQty);
        }

        private void buttonJavaAdd_Click(object sender, EventArgs e)
        {
            addQty(buttonJavaAdd, textBoxJavaQty);
        }

        private void buttonJavaLess_Click(object sender, EventArgs e)
        {
            lessQty(buttonJavaLess, textBoxJavaQty);
        }



        public bool justClearing = false;
        private void buttonClear_Click(object sender, EventArgs e)
        {

            DialogResult result= MessageBox.Show("Do you want to clear all inputs?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                justClearing = true;
                MochaReady = false;
                CappReady = false;
                JellyReady = false;
                JavaReady = false;

                comboBoxMochaSize.SelectedIndex = -1;
                comboBoxMochaType.SelectedIndex = -1;
                comboBoxCappSize.SelectedIndex = -1;
                comboBoxCappType.SelectedIndex = -1;
                comboBoxJellySize.SelectedIndex = -1;
                comboBoxJellyType.SelectedIndex = -1;
                comboBoxJavaSize.SelectedIndex = -1;
                comboBoxJavaType.SelectedIndex = -1;

                textBoxMochaQty.Text = "0";
                textBoxCappQty.Text = "0";
                textBoxJellyQty.Text = "0";
                textBoxJavaQty.Text = "0";

                justClearing = false;

                notReady(buttonMochaAdd, buttonMochaLess);
                notReady(buttonCappAdd, buttonCappLess);
                notReady(buttonJellyAdd, buttonJellyLess);
                notReady(buttonJavaAdd, buttonJavaLess);

                labelMochaPrice.Text = "0";
                labelCappPrice.Text = "0";
                labelJellyPrice.Text = "0";
                labelJavaPrice.Text = "0";

                checkBoxDonut.Checked = false;
                checkBoxCinn.Checked = false;
                checkBoxPizz.Checked = false;
                checkBoxHam.Checked = false;
                checkBoxCook.Checked = false;
                checkBoxCake.Checked = false;

                textBoxMoney.Text = "";
                textBoxMoney.Enabled = false;

                labelChange.Text = "0";
            }

            
        }

        private void textBoxMochaQty_TextChanged(object sender, EventArgs e)
        {
            callClass(textBoxMochaQty, labelMochaPrice, Xmocha, Ymocha, TypeMocha);
        }

        private void textBoxCappQty_TextChanged(object sender, EventArgs e)
        {
            callClass(textBoxCappQty, labelCappPrice, Xcapp, Ycapp, TypeCapp);
        }




        public void callClass(TextBox txt, Label lbl, int x, int y, string type)
        {
            int qty = int.Parse(txt.Text);
            Class1 c1 = new Class1();
            double total = c1.computePriceQty(x, y, qty, type);
            lbl.Text = total.ToString();
        }

        private void textBoxJellyQty_TextChanged(object sender, EventArgs e)
        {
            callClass(textBoxJellyQty, labelJellyPrice, Xjelly, Yjelly, TypeJelly);
        }

        private void textBoxJavaQty_TextChanged(object sender, EventArgs e)
        {
            callClass(textBoxJavaQty, labelJavaPrice, Xjava, Yjava, TypeJava);
        }


        public double pastryTotal = 0;
        private void checkBoxDonut_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDonut.Checked)
            {
                pastryTotal += 80;
            }
            else
            {
                pastryTotal -= 80;
            }
            labelPastryPrice.Text = pastryTotal.ToString();
        }

        private void checkBoxCinn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCinn.Checked)
            {
                pastryTotal += 100;
            }
            else
            {
                pastryTotal -= 100;
            }
            labelPastryPrice.Text = pastryTotal.ToString();
        }

        private void checkBoxPizz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPizz.Checked)
            {
                pastryTotal += 80;
            }
            else
            {
                pastryTotal -= 80;
            }
            labelPastryPrice.Text = pastryTotal.ToString();
        }

        private void checkBoxHam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHam.Checked)
            {
                pastryTotal += 90;
            }
            else
            {
                pastryTotal -= 90;
            }
            labelPastryPrice.Text = pastryTotal.ToString();
        }

        private void checkBoxCook_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCook.Checked)
            {
                pastryTotal += 85;
            }
            else
            {
                pastryTotal -= 85;
            }
            labelPastryPrice.Text = pastryTotal.ToString();
        }

        private void checkBoxCake_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCake.Checked)
            {
                pastryTotal += 120;
            }
            else
            {
                pastryTotal -= 120;
            }
            labelPastryPrice.Text = pastryTotal.ToString();
        }




        private void labelMochaPrice_TextChanged(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            notZero(c1.computedTotal(labelVatable, labelVat, labelTotal, double.Parse(labelMochaPrice.Text), double.Parse(labelCappPrice.Text), double.Parse(labelJellyPrice.Text), 
                             double.Parse(labelJavaPrice.Text), double.Parse(labelPastryPrice.Text)));

        }



        private void labelCappPrice_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            notZero(c1.computedTotal(labelVatable, labelVat, labelTotal, double.Parse(labelMochaPrice.Text), double.Parse(labelCappPrice.Text), double.Parse(labelJellyPrice.Text),
                             double.Parse(labelJavaPrice.Text), double.Parse(labelPastryPrice.Text)));

            
        }

        private void labelJellyPrice_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            notZero(c1.computedTotal(labelVatable, labelVat, labelTotal, double.Parse(labelMochaPrice.Text), double.Parse(labelCappPrice.Text), double.Parse(labelJellyPrice.Text),
                             double.Parse(labelJavaPrice.Text), double.Parse(labelPastryPrice.Text)));
        }

        private void labelJavaPrice_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            notZero(c1.computedTotal(labelVatable, labelVat, labelTotal, double.Parse(labelMochaPrice.Text), double.Parse(labelCappPrice.Text), double.Parse(labelJellyPrice.Text),
                             double.Parse(labelJavaPrice.Text), double.Parse(labelPastryPrice.Text)));
        }

        private void labelPastryPrice_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            notZero(c1.computedTotal(labelVatable, labelVat, labelTotal, double.Parse(labelMochaPrice.Text), double.Parse(labelCappPrice.Text), double.Parse(labelJellyPrice.Text),
                             double.Parse(labelJavaPrice.Text), double.Parse(labelPastryPrice.Text)));
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            try
            {

                double total = double.Parse(labelTotal.Text);
                double money = double.Parse(textBoxMoney.Text);
                double change = money - total;

                if (change >= 0)
                {
                    labelChange.Text = String.Format("{0:0.00}", change);
                }
                else
                {
                    MessageBox.Show("Insufficient Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Wrong Payment Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    


        public void notZero(double total)
        {
            if (total > 0)
            {
                textBoxMoney.Enabled = true;
            }
        }

    }
}