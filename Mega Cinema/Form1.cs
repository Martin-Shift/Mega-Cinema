namespace Mega_Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Clear Form After Loading
            ClearForm(this, new EventArgs());
        }

        //Constant Prices for Tickets
        private readonly decimal _adultPrice = 7.99M;
        private readonly decimal _studentPrice = 4.99M;
        private readonly decimal _childPrice = 2.99M;

        private decimal TotalReceipts { get; set; } = 0;
        private int TotalCashiers { get; set; } = 0;
        private uint TotalTickets { get; set; } = 0;

        //Calculate receipt
        private void CalculateReceipt(object sender, EventArgs e)
        {
            //Check if the input in the ticket box is a number
            if (!uint.TryParse(AdultTicketBox.Text, out uint adultTickets))
            {
                MessageBox.Show("Please enter numerical data for number of adult tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!uint.TryParse(StudentTicketBox.Text, out uint studentTickets))
            {
                MessageBox.Show("Please enter numerical data for number of student tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!uint.TryParse(ChildTicketBox.Text, out uint childTickets))
            {
                MessageBox.Show("Please enter numerical data for number of child tickets", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check if the Cashier name is empty
            if (CashierNameBox.Text == "")
            {
                MessageBox.Show("Please enter cashier's name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Check if total amount of tickets is zero
            if (adultTickets + studentTickets + childTickets == 0)
            {
                MessageBox.Show("Amount of tickets should be more than zero", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Calculate the price
            decimal cashierReceipts = adultTickets * _adultPrice;
            cashierReceipts += studentTickets * _studentPrice;
            cashierReceipts += childTickets * _childPrice;
            //Calculate the tickets
            var ticketsSold = adultTickets + studentTickets + childTickets;

            //Modify global values 
            TotalCashiers++;
            TotalTickets += ticketsSold;
            TotalReceipts += cashierReceipts;

            //Toggle visibilities and disable the inputs
            CompanyGroupBox.Visible = true;
            CashierGroupBox.Visible = true;
            CashierPanel.Enabled = false;
            CalculateButton.Enabled = false;
            SummaryButton.Enabled = true;


            //Change the title
            this.Text = "Transaction Summary";

            //Show the results
            CashierName.Text = CashierNameBox.Text;
            CashierTicketsBox.Text = ticketsSold.ToString();
            CashierReceiptsBox.Text = $"ˆ{cashierReceipts}";
        }

        //Clear Form
        private void ClearForm(object sender, EventArgs e)
        {
            //Change the title
            this.Text = "Purchase Tickets";

            //Toggle All Visibilities
            CashierGroupBox.Visible = false;
            CompanyGroupBox.Visible = false;
            CashierNameLabel.Visible = true;
            CashierNameBox.Visible = true;
            TicketsGroupBox.Visible = true;

            //Enable all fields after Calculating
            CashierPanel.Enabled = true;
            CalculateButton.Enabled = true;

            //Set default text in TextBoxes
            CashierNameBox.Text = "";
            AdultTicketBox.Text = "0";
            StudentTicketBox.Text = "0";
            ChildTicketBox.Text = "0";
        }

        //Exit
        private void Exit(object sender, EventArgs e)
        {
            //Confirm Exit
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
            }
        }

        //Summary
        private void LoadSummary(object sender, EventArgs e)
        {
            //Toggle visibilities and remove the inputs
            CompanyGroupBox.Visible = true;

            CashierGroupBox.Visible = false;
            CashierPanel.Visible = false;
            CalculateButton.Enabled = false;

            //Change the title
            this.Text = "All Transactions Summary";

            //Show summary
            TotalCashiersBox.Text = TotalCashiers.ToString();
            TotalTicketsBox.Text = TotalTickets.ToString();
            TotalReceiptsBox.Text = $"ˆ{TotalReceipts}";

            //Ternary operator to prevent division by zero
            var totalPrice = TotalTickets != 0 ? (TotalReceipts / TotalTickets) : 0;

            //Floor the price to 2 numbers after decimal point
            AvgTransBox.Text = $"ˆ{Math.Floor(totalPrice * 100) / 100}";
        }
    }
}