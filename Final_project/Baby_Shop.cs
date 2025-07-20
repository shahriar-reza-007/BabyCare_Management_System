using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Baby_Shop : Form
    {
        public Baby_Shop()
        {
            InitializeComponent();
        }

        private void MushiecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MushiecheckBox.Checked)
            {
                MushieTextBox.Enabled = true;
            }
            else
            {
                MushieTextBox.Enabled = false;
                MushieTextBox.Text = "0";
            }
        }

        private void CreamCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CreamCheckBox.Checked)
            {
                CreamTextBox.Enabled = true;
            }
            else
            {
                CreamTextBox.Enabled = false;
                CreamTextBox.Text = "0";
            }
        }

        private void KokosocheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (KokosocheckBox.Checked)
            {
                KokosotextBox.Enabled = true;
            }
            else
            {
                KokosotextBox.Enabled = false;
                KokosotextBox.Text = "0";
            }
        }

        private void SOSBalmcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SOSBalmcheckBox.Checked)
            {
                SOSBalmtextBox.Enabled = true;
            }
            else
            {
                SOSBalmtextBox.Enabled = false;
                SOSBalmtextBox.Text = "0";
            }
        }

        private void BathSpongecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BathSpongecheckBox.Checked)
            {
                BathSpongetextBox.Enabled = true;
            }
            else
            {
                BathSpongetextBox.Enabled = false;
                BathSpongetextBox.Text = "0";
            }
        }

        private void BodyLotioncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BodyLotioncheckBox.Checked)
            {
                BodyLotiontextBox.Enabled = true;
            }
            else
            {
                BodyLotiontextBox.Enabled = false;
                BodyLotiontextBox.Text = "0";
            }
        }

        private void SkipHopcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SkipHopcheckBox.Checked)
            {
                SkipHoptextBox.Enabled = true;
            }
            else
            {
                SkipHoptextBox.Enabled = false;
                SkipHoptextBox.Text = "0";
            }
        }

        private void FRIGGcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FRIGGcheckBox.Checked)
            {
                FRIGGtextBox.Enabled = true;
            }
            else
            {
                FRIGGtextBox.Enabled = false;
                FRIGGtextBox.Text = "0";
            }
        }

        private void LivlycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LivlycheckBox.Checked)
            {
                LivlytextBox.Enabled = true;
            }
            else
            {
                LivlytextBox.Enabled = false;
                LivlytextBox.Text = "0";
            }
        }

        private void EasygrowcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EasygrowcheckBox.Checked)
            {
                EasygrowtextBox.Enabled = true;
            }
            else
            {
                EasygrowtextBox.Enabled = false;
                EasygrowtextBox.Text = "0";
            }
        }

        private void FabelabcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FabelabcheckBox.Checked)
            {
                FabelabtextBox.Enabled = true;
            }
            else
            {
                FabelabtextBox.Enabled = false;
                FabelabtextBox.Text = "0";
            }
        }

        private void PiupiuchickcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PiupiuchickcheckBox.Checked)
            {
                PiupiuchicktextBox.Enabled = true;
            }
            else
            {
                PiupiuchicktextBox.Enabled = false;
                PiupiuchicktextBox.Text = "0";
            }
        }

        private void Baby_Shop_Load(object sender, EventArgs e)
        {
            Time_Label.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        // Declare unit prices for different products
        double Mushieup = 300, Creamup = 350, Kokosoup = 400, SOSBalmup = 425, BathSpongeup = 450, BabyLotionup = 500;
        double SkipHopup = 700, FRIGGup = 350, Livlyup = 190, Easgrowup = 1500, Fabelabup = 400, Piupiuchickup = 250;

        double Mushiecp, Creamcp, Kokosocp, SOSBalmcp, BathSpongecp, BabyLotioncp, SkipHopcp, FRIGGcp, Livlycp, Easgrowcp, Fabelabcp, Piupiuchickcp;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AvailableMoneyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        double Subtotal = 0, tax, grdtotal;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(MAINrichTextBox.Text + "Subtotal: " + Subtotal + "\nTax: " + tax + "\nGrand Total: " + grdtotal, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_Label.Text = DateTime.Now.ToLongTimeString();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void RESETbutton_Click(object sender, EventArgs e)
        {
            MushiecheckBox.Checked = false;
            CreamCheckBox.Checked = false;
            KokosocheckBox.Checked = false;
            SOSBalmcheckBox.Checked = false;
            BathSpongecheckBox.Checked = false;
            BodyLotioncheckBox.Checked = false;
            SkipHopcheckBox.Checked = false;
            FRIGGcheckBox.Checked = false;
            LivlycheckBox.Checked = false;
            EasygrowcheckBox.Checked = false;
            FabelabcheckBox.Checked = false;
            PiupiuchickcheckBox.Checked = false;
        }

        private void Time_Label_Click(object sender, EventArgs e)
        {
            Time_Label.Text = DateTime.Now.ToLongTimeString();
        }

        private void LeftBodyLotionLabel_Click(object sender, EventArgs e)
        {

        }

        private void LivlytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkipHoptextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BodyLotiontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PRINTbutton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                ValidateInput(MushieTextBox.Text);
                ValidateInput(CreamTextBox.Text);
                ValidateInput(KokosotextBox.Text);
                ValidateInput(SOSBalmtextBox.Text);
                ValidateInput(BathSpongetextBox.Text);
                ValidateInput(BodyLotiontextBox.Text);
                ValidateInput(SkipHoptextBox.Text);
                ValidateInput(FRIGGtextBox.Text);
                ValidateInput(LivlytextBox.Text);
                ValidateInput(EasygrowtextBox.Text);
                ValidateInput(FabelabtextBox.Text);
                ValidateInput(PiupiuchicktextBox.Text);

                Mushiecp = Mushieup * Convert.ToDouble(MushieTextBox.Text);
                Creamcp = Creamup * Convert.ToDouble(CreamTextBox.Text);
                Kokosocp = Kokosoup * Convert.ToDouble(KokosotextBox.Text);
                SOSBalmcp = SOSBalmup * Convert.ToDouble(SOSBalmtextBox.Text);
                BathSpongecp = BathSpongeup * Convert.ToDouble(BathSpongetextBox.Text);
                BabyLotioncp = BabyLotionup * Convert.ToDouble(BodyLotiontextBox.Text);
                SkipHopcp = SkipHopup * Convert.ToDouble(SkipHoptextBox.Text);
                FRIGGcp = FRIGGup * Convert.ToDouble(FRIGGtextBox.Text);
                Livlycp = Livlyup * Convert.ToDouble(LivlytextBox.Text);
                Easgrowcp = Easgrowup * Convert.ToDouble(EasygrowtextBox.Text);
                Fabelabcp = Fabelabup * Convert.ToDouble(FabelabtextBox.Text);
                Piupiuchickcp = Piupiuchickup * Convert.ToDouble(PiupiuchicktextBox.Text);

                MAINrichTextBox.Clear();
                Subtotal = 0;
                tax = 0;
                grdtotal = 0;
                MAINrichTextBox.AppendText(Environment.NewLine);
                MAINrichTextBox.AppendText("\t\t\tBaby Shop\t\t\t" + Time_Label.Text + Environment.NewLine);
                MAINrichTextBox.AppendText("\t\t\t *******************" + Environment.NewLine);

                AddToRichTextBox(MushiecheckBox, "Mushie", Mushiecp);
                AddToRichTextBox(CreamCheckBox, "Cream", Creamcp);
                AddToRichTextBox(KokosocheckBox, "Kokoso", Kokosocp);
                AddToRichTextBox(SOSBalmcheckBox, "SOS Balm", SOSBalmcp);
                AddToRichTextBox(BathSpongecheckBox, "Bath Sponge", BathSpongecp);
                AddToRichTextBox(BodyLotioncheckBox, "Baby Lotion", BabyLotioncp);
                AddToRichTextBox(SkipHopcheckBox, "Skip Hop", SkipHopcp);
                AddToRichTextBox(FRIGGcheckBox, "Feeder", FRIGGcp);
                AddToRichTextBox(LivlycheckBox, "Baby Soap", Livlycp);
                AddToRichTextBox(EasygrowcheckBox, "Pampers", Easgrowcp);
                AddToRichTextBox(FabelabcheckBox, "Olive Oil", Fabelabcp);
                AddToRichTextBox(PiupiuchickcheckBox, "Piupiu Chick", Piupiuchickcp);

                tax = Subtotal * 0.15; // 15% tax
                grdtotal = Subtotal + tax;
                RSlabel2.Text = "Tk " + tax;
                Total_label.Text = "Tk " + grdtotal;

                // Check if we have enough money
                double availableMoney = double.Parse(AvailableMoneyTextBox.Text);
                if (grdtotal > availableMoney)
                {
                    MessageBox.Show("You do not have enough money. Adjusting the quantities...");
                    AdjustQuantitiesToFitBudget(availableMoney);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidateInput(string input)
        {
            if (!int.TryParse(input, out _))
            {
                throw new Exception("Please insert integer value");
            }
        }

        private void AddToRichTextBox(CheckBox checkBox, string itemName, double itemCost)
        {
            if (checkBox.Checked)
            {
                MAINrichTextBox.AppendText($"\t{itemName}:\t{itemCost} Tk" + Environment.NewLine);
                Subtotal += itemCost;
                RSlabel1.Text = " " + Subtotal;
            }
        }

        private void AdjustQuantitiesToFitBudget(double availableMoney)
        {
            var items = new[]
            {
                new { CheckBox = MushiecheckBox, TextBox = MushieTextBox, UnitPrice = Mushieup },
                new { CheckBox = CreamCheckBox, TextBox = CreamTextBox, UnitPrice = Creamup },
                new { CheckBox = KokosocheckBox, TextBox = KokosotextBox, UnitPrice = Kokosoup },
                new { CheckBox = SOSBalmcheckBox, TextBox = SOSBalmtextBox, UnitPrice = SOSBalmup },
                new { CheckBox = BathSpongecheckBox, TextBox = BathSpongetextBox, UnitPrice = BathSpongeup },
                new { CheckBox = BodyLotioncheckBox, TextBox = BodyLotiontextBox, UnitPrice = BabyLotionup },
                new { CheckBox = SkipHopcheckBox, TextBox = SkipHoptextBox, UnitPrice = SkipHopup },
                new { CheckBox = FRIGGcheckBox, TextBox = FRIGGtextBox, UnitPrice = FRIGGup },
                new { CheckBox = LivlycheckBox, TextBox = LivlytextBox, UnitPrice = Livlyup },
                new { CheckBox = EasygrowcheckBox, TextBox = EasygrowtextBox, UnitPrice = Easgrowup },
                new { CheckBox = FabelabcheckBox, TextBox = FabelabtextBox, UnitPrice = Fabelabup },
                new { CheckBox = PiupiuchickcheckBox, TextBox = PiupiuchicktextBox, UnitPrice = Piupiuchickup }
            };

            Array.Sort(items, (x, y) => y.UnitPrice.CompareTo(x.UnitPrice));

            foreach (var item in items)
            {
                if (item.CheckBox.Checked)
                {
                    while (Convert.ToDouble(item.TextBox.Text) > 0 && grdtotal > availableMoney)
                    {
                        item.TextBox.Text = (Convert.ToDouble(item.TextBox.Text) - 1).ToString();
                        UpdateCosts();
                    }

                    if (grdtotal <= availableMoney)
                        break;
                }
            }

            if (grdtotal > availableMoney)
            {
                MessageBox.Show("Even after adjustments, you do not have enough money to buy the selected items.");
            }
        }

        private void UpdateCosts()
        {
            Mushiecp = Mushieup * Convert.ToDouble(MushieTextBox.Text);
            Creamcp = Creamup * Convert.ToDouble(CreamTextBox.Text);
            Kokosocp = Kokosoup * Convert.ToDouble(KokosotextBox.Text);
            SOSBalmcp = SOSBalmup * Convert.ToDouble(SOSBalmtextBox.Text);
            BathSpongecp = BathSpongeup * Convert.ToDouble(BathSpongetextBox.Text);
            BabyLotioncp = BabyLotionup * Convert.ToDouble(BodyLotiontextBox.Text);
            SkipHopcp = SkipHopup * Convert.ToDouble(SkipHoptextBox.Text);
            FRIGGcp = FRIGGup * Convert.ToDouble(FRIGGtextBox.Text);
            Livlycp = Livlyup * Convert.ToDouble(LivlytextBox.Text);
            Easgrowcp = Easgrowup * Convert.ToDouble(EasygrowtextBox.Text);
            Fabelabcp = Fabelabup * Convert.ToDouble(FabelabtextBox.Text);
            Piupiuchickcp = Piupiuchickup * Convert.ToDouble(PiupiuchicktextBox.Text);

            MAINrichTextBox.Clear();
            Subtotal = 0;
            tax = 0;
            grdtotal = 0;
            MAINrichTextBox.AppendText(Environment.NewLine);
            MAINrichTextBox.AppendText("\t\t\tBaby Shop\t\t\t" + Time_Label.Text + Environment.NewLine);
            MAINrichTextBox.AppendText("\t\t\t *******************" + Environment.NewLine);

            AddToRichTextBox(MushiecheckBox, "Mushie", Mushiecp);
            AddToRichTextBox(CreamCheckBox, "Cream", Creamcp);
            AddToRichTextBox(KokosocheckBox, "Kokoso", Kokosocp);
            AddToRichTextBox(SOSBalmcheckBox, "SOS Balm", SOSBalmcp);
            AddToRichTextBox(BathSpongecheckBox, "Bath Sponge", BathSpongecp);
            AddToRichTextBox(BodyLotioncheckBox, "Baby Lotion", BabyLotioncp);
            AddToRichTextBox(SkipHopcheckBox, "Skip Hop", SkipHopcp);
            AddToRichTextBox(FRIGGcheckBox, "Feeder", FRIGGcp);
            AddToRichTextBox(LivlycheckBox, "Baby Soap", Livlycp);
            AddToRichTextBox(EasygrowcheckBox, "Pampers", Easgrowcp);
            AddToRichTextBox(FabelabcheckBox, "Olive Oil", Fabelabcp);
            AddToRichTextBox(PiupiuchickcheckBox, "Piupiu Chick", Piupiuchickcp);

            tax = Subtotal * 0.15; // 15% tax
            grdtotal = Subtotal + tax;
            RSlabel2.Text = "Tk " + tax;
            Total_label.Text = "Tk " + grdtotal;
        }
    }
}
