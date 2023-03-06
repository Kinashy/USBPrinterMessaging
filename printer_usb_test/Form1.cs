using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace printer_usb_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Allow the user to select a printer.
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                // Send a printer-specific to the printer.
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, richTextBox1.Text);
                MessageBox.Show("Data sent to printer.");
            }
            else
            {
                MessageBox.Show("Data not sent to printer.");
            }
        }
    }
}
