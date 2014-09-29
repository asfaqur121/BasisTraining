using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTicketApp
{
    public partial class TicketInformationForm : Form
    {
        public TicketInformationForm()
        {
            InitializeComponent();
        }

        String customarName;
        int numberOfTicket;
        int total;


        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            customarName = nameTextBox.Text;
            numberOfTicket = Convert.ToInt32(ticketTextBox.Text);
            total = numberOfTicket * 10;

            nameTextBox.Text = "";
            ticketTextBox.Text = "";

            MessageBox.Show(customarName + ", Please Pay=" + total+"tk.");
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customar Name=" + customarName + "\nUnit Price= 10" + "\nTotal Price=" + total);

        }
    }
}
