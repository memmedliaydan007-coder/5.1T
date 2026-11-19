using System;
using System.IO;
using System.Windows.Forms;

namespace _5._1T
{
    public partial class Form1 : Form
    {
        string faylAdi = Path.Combine(
            Application.StartupPath,
            "qeydler.txt"
        );

        public Form1()
        {
            InitializeComponent();

            btnElaveEt.Click += btnElaveEt_Click;
            btnGoster.Click += btnGoster_Click;
            btnAxtar.Click += btnAxtar_Click;
            btnSil.Click += btnSil_Click;
            btnCixis.Click += btnCixis_Click;
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            try
            {
                string qeyd = txtQeyd.Text.Trim();

                if (string.IsNullOrWhiteSpace(qeyd))
                {
                    MessageBox.Show("Zehmet olmasa qeyd daxil edin!");
                    return;
                }

                string tarix = DateTime.Now.ToString(
                    "dd.MM.yyyy HH:mm:ss"
                );

                using (StreamWriter sw = new StreamWriter(faylAdi, true))
                {
                    sw.WriteLine(tarix + " | " + qeyd);
                }

                MessageBox.Show("Qeyd ugurla yadda saxlanildi!");

                txtQeyd.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

       
        private void btnGoster_Click(object sender, EventArgs e)
        {
            try
            {
                lstQeydler.Items.Clear();

                if (!File.Exists(faylAdi))
                {
                    MessageBox.Show("Hele hec bir qeyd yoxdur!");
                    return;
                }

                using (StreamReader sr = new StreamReader(faylAdi))
                {
                    string setir;

                    while ((setir = sr.ReadLine()) != null)
                    {
                        lstQeydler.Items.Add(setir);
                    }
                }

                if (lstQeydler.Items.Count == 0)
                {
                    MessageBox.Show("Qeydler siyahisi bosdur!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

   
        private void btnAxtar_Click(object sender, EventArgs e)
        {
            try
            {
                string acarSoz = txtAxtaris.Text.Trim();

                if (string.IsNullOrWhiteSpace(acarSoz))
                {
                    MessageBox.Show("Axtaris sozu daxil edin!");
                    return;
                }

                lstQeydler.Items.Clear();

                if (!File.Exists(faylAdi))
                {
                    MessageBox.Show("Qeyd fayli movcud deyil!");
                    return;
                }

                bool tapildi = false;

                using (StreamReader sr = new StreamReader(faylAdi))
                {
                    string setir;

                    while ((setir = sr.ReadLine()) != null)
                    {
                        if (setir.IndexOf(
                            acarSoz,
                            StringComparison.OrdinalIgnoreCase
                        ) >= 0)
                        {
                            lstQeydler.Items.Add(setir);
                            tapildi = true;
                        }
                    }
                }

                if (!tapildi)
                {
                    MessageBox.Show("Axtarilan qeyd tapilmadi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(faylAdi))
                {
                    MessageBox.Show("Silinecek qeyd yoxdur!");
                    return;
                }

                DialogResult cavab = MessageBox.Show(
                    "Butun qeydləri silmek isteyirsiniz?",
                    "Tesdiq",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (cavab == DialogResult.Yes)
                {
                    File.WriteAllText(faylAdi, "");

                    lstQeydler.Items.Clear();

                    MessageBox.Show("Butun qeydlər silindi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xeta: " + ex.Message);
            }
        }

        private void btnCixis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}