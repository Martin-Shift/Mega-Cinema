namespace Mega_Cinema
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CashierNameLabel = new Label();
            CashierNameBox = new TextBox();
            TicketsGroupBox = new GroupBox();
            ChildTicketBox = new TextBox();
            StudentTicketBox = new TextBox();
            AdultTicketBox = new TextBox();
            ChildLabel = new Label();
            StudentLabel = new Label();
            AdultLabel = new Label();
            panel1 = new Panel();
            ExitButton = new Button();
            SummaryButton = new Button();
            ClearButton = new Button();
            CalculateButton = new Button();
            CompanyGroupBox = new GroupBox();
            AvgTransBox = new TextBox();
            TotalReceiptsBox = new TextBox();
            TotalTicketsBox = new TextBox();
            AvgTransPriceLabel = new Label();
            TotalCashiersBox = new TextBox();
            TotalReceiptsLabel = new Label();
            TotalTicketsLabel = new Label();
            TotalCashisersLabel = new Label();
            CashierGroupBox = new GroupBox();
            CashierReceiptsBox = new TextBox();
            CashierTicketsBox = new TextBox();
            CashierName = new TextBox();
            label2 = new Label();
            TotalTicketsSoldLabel = new Label();
            CashierLabel = new Label();
            ToolTip = new ToolTip(components);
            CinemaLogo = new PictureBox();
            CashierPanel = new Panel();
            TicketsGroupBox.SuspendLayout();
            panel1.SuspendLayout();
            CompanyGroupBox.SuspendLayout();
            CashierGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CinemaLogo).BeginInit();
            CashierPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CashierNameLabel
            // 
            CashierNameLabel.AutoSize = true;
            CashierNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            CashierNameLabel.Location = new Point(33, 15);
            CashierNameLabel.Name = "CashierNameLabel";
            CashierNameLabel.Size = new Size(133, 25);
            CashierNameLabel.TabIndex = 2;
            CashierNameLabel.Text = "Cashier Name";
            // 
            // CashierNameBox
            // 
            CashierNameBox.BorderStyle = BorderStyle.FixedSingle;
            CashierNameBox.Location = new Point(230, 15);
            CashierNameBox.Name = "CashierNameBox";
            CashierNameBox.Size = new Size(155, 27);
            CashierNameBox.TabIndex = 3;
            CashierNameBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TicketsGroupBox
            // 
            TicketsGroupBox.Controls.Add(ChildTicketBox);
            TicketsGroupBox.Controls.Add(StudentTicketBox);
            TicketsGroupBox.Controls.Add(AdultTicketBox);
            TicketsGroupBox.Controls.Add(ChildLabel);
            TicketsGroupBox.Controls.Add(StudentLabel);
            TicketsGroupBox.Controls.Add(AdultLabel);
            TicketsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TicketsGroupBox.Location = new Point(15, 66);
            TicketsGroupBox.Name = "TicketsGroupBox";
            TicketsGroupBox.Size = new Size(415, 154);
            TicketsGroupBox.TabIndex = 4;
            TicketsGroupBox.TabStop = false;
            TicketsGroupBox.Text = "Tickets";
            // 
            // ChildTicketBox
            // 
            ChildTicketBox.BorderStyle = BorderStyle.FixedSingle;
            ChildTicketBox.Location = new Point(257, 111);
            ChildTicketBox.Name = "ChildTicketBox";
            ChildTicketBox.Size = new Size(65, 27);
            ChildTicketBox.TabIndex = 9;
            ChildTicketBox.Text = "0";
            ChildTicketBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StudentTicketBox
            // 
            StudentTicketBox.BorderStyle = BorderStyle.FixedSingle;
            StudentTicketBox.Location = new Point(257, 72);
            StudentTicketBox.Name = "StudentTicketBox";
            StudentTicketBox.Size = new Size(65, 27);
            StudentTicketBox.TabIndex = 8;
            StudentTicketBox.Text = "0";
            StudentTicketBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AdultTicketBox
            // 
            AdultTicketBox.BorderStyle = BorderStyle.FixedSingle;
            AdultTicketBox.Location = new Point(257, 33);
            AdultTicketBox.Name = "AdultTicketBox";
            AdultTicketBox.Size = new Size(65, 27);
            AdultTicketBox.TabIndex = 5;
            AdultTicketBox.Text = "0";
            AdultTicketBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ChildLabel
            // 
            ChildLabel.AutoSize = true;
            ChildLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ChildLabel.Location = new Point(91, 110);
            ChildLabel.Name = "ChildLabel";
            ChildLabel.Size = new Size(57, 25);
            ChildLabel.TabIndex = 7;
            ChildLabel.Text = "Child";
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            StudentLabel.Location = new Point(65, 71);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(83, 25);
            StudentLabel.TabIndex = 6;
            StudentLabel.Text = "Student";
            // 
            // AdultLabel
            // 
            AdultLabel.AutoSize = true;
            AdultLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AdultLabel.Location = new Point(87, 32);
            AdultLabel.Name = "AdultLabel";
            AdultLabel.Size = new Size(61, 25);
            AdultLabel.TabIndex = 5;
            AdultLabel.Text = "Adult";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(SummaryButton);
            panel1.Controls.Add(ClearButton);
            panel1.Controls.Add(CalculateButton);
            panel1.Location = new Point(22, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 83);
            panel1.TabIndex = 5;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(41, 15, 81);
            ExitButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 225);
            ExitButton.Font = new Font("Tahoma", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = SystemColors.ButtonFace;
            ExitButton.Location = new Point(321, 21);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(95, 40);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "&Exit";
            ToolTip.SetToolTip(ExitButton, "Press to exit Application");
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += Exit;
            // 
            // SummaryButton
            // 
            SummaryButton.BackColor = Color.FromArgb(41, 15, 81);
            SummaryButton.Enabled = false;
            SummaryButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 225);
            SummaryButton.Font = new Font("Tahoma", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            SummaryButton.ForeColor = SystemColors.ButtonFace;
            SummaryButton.Location = new Point(219, 21);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(95, 40);
            SummaryButton.TabIndex = 8;
            SummaryButton.Text = "&Summary";
            ToolTip.SetToolTip(SummaryButton, "Press to view Summary");
            SummaryButton.UseVisualStyleBackColor = false;
            SummaryButton.Click += LoadSummary;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.FromArgb(41, 15, 81);
            ClearButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 225);
            ClearButton.Font = new Font("Tahoma", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.ForeColor = SystemColors.ButtonFace;
            ClearButton.Location = new Point(118, 21);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(95, 40);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "&Clear";
            ToolTip.SetToolTip(ClearButton, "Press to clear the form");
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearForm;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.FromArgb(41, 15, 81);
            CalculateButton.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 225);
            CalculateButton.Font = new Font("Tahoma", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.ForeColor = SystemColors.ButtonFace;
            CalculateButton.Location = new Point(14, 21);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(95, 40);
            CalculateButton.TabIndex = 6;
            CalculateButton.Text = "C&alculate";
            ToolTip.SetToolTip(CalculateButton, "Press to Calculate the Receipt");
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateReceipt;
            // 
            // CompanyGroupBox
            // 
            CompanyGroupBox.Controls.Add(AvgTransBox);
            CompanyGroupBox.Controls.Add(TotalReceiptsBox);
            CompanyGroupBox.Controls.Add(TotalTicketsBox);
            CompanyGroupBox.Controls.Add(AvgTransPriceLabel);
            CompanyGroupBox.Controls.Add(TotalCashiersBox);
            CompanyGroupBox.Controls.Add(TotalReceiptsLabel);
            CompanyGroupBox.Controls.Add(TotalTicketsLabel);
            CompanyGroupBox.Controls.Add(TotalCashisersLabel);
            CompanyGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CompanyGroupBox.Location = new Point(22, 357);
            CompanyGroupBox.Name = "CompanyGroupBox";
            CompanyGroupBox.Size = new Size(433, 187);
            CompanyGroupBox.TabIndex = 10;
            CompanyGroupBox.TabStop = false;
            CompanyGroupBox.Text = "Company Summary Data";
            // 
            // AvgTransBox
            // 
            AvgTransBox.BorderStyle = BorderStyle.FixedSingle;
            AvgTransBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AvgTransBox.Location = new Point(237, 142);
            AvgTransBox.Name = "AvgTransBox";
            AvgTransBox.ReadOnly = true;
            AvgTransBox.Size = new Size(122, 27);
            AvgTransBox.TabIndex = 13;
            AvgTransBox.Text = "0";
            AvgTransBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TotalReceiptsBox
            // 
            TotalReceiptsBox.BorderStyle = BorderStyle.FixedSingle;
            TotalReceiptsBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TotalReceiptsBox.Location = new Point(237, 106);
            TotalReceiptsBox.Name = "TotalReceiptsBox";
            TotalReceiptsBox.ReadOnly = true;
            TotalReceiptsBox.Size = new Size(122, 27);
            TotalReceiptsBox.TabIndex = 12;
            TotalReceiptsBox.Text = "0";
            TotalReceiptsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TotalTicketsBox
            // 
            TotalTicketsBox.BorderStyle = BorderStyle.FixedSingle;
            TotalTicketsBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TotalTicketsBox.Location = new Point(237, 69);
            TotalTicketsBox.Name = "TotalTicketsBox";
            TotalTicketsBox.ReadOnly = true;
            TotalTicketsBox.Size = new Size(122, 27);
            TotalTicketsBox.TabIndex = 11;
            TotalTicketsBox.Text = "0";
            TotalTicketsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AvgTransPriceLabel
            // 
            AvgTransPriceLabel.AutoSize = true;
            AvgTransPriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AvgTransPriceLabel.Location = new Point(33, 142);
            AvgTransPriceLabel.Name = "AvgTransPriceLabel";
            AvgTransPriceLabel.Size = new Size(133, 23);
            AvgTransPriceLabel.TabIndex = 10;
            AvgTransPriceLabel.Text = "Avg Trans Price";
            // 
            // TotalCashiersBox
            // 
            TotalCashiersBox.BorderStyle = BorderStyle.FixedSingle;
            TotalCashiersBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TotalCashiersBox.Location = new Point(237, 33);
            TotalCashiersBox.Name = "TotalCashiersBox";
            TotalCashiersBox.ReadOnly = true;
            TotalCashiersBox.Size = new Size(122, 27);
            TotalCashiersBox.TabIndex = 5;
            TotalCashiersBox.Text = "0";
            TotalCashiersBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TotalReceiptsLabel
            // 
            TotalReceiptsLabel.AutoSize = true;
            TotalReceiptsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TotalReceiptsLabel.Location = new Point(33, 106);
            TotalReceiptsLabel.Name = "TotalReceiptsLabel";
            TotalReceiptsLabel.Size = new Size(121, 23);
            TotalReceiptsLabel.TabIndex = 7;
            TotalReceiptsLabel.Text = "Total Receipts";
            // 
            // TotalTicketsLabel
            // 
            TotalTicketsLabel.AutoSize = true;
            TotalTicketsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TotalTicketsLabel.Location = new Point(33, 69);
            TotalTicketsLabel.Name = "TotalTicketsLabel";
            TotalTicketsLabel.Size = new Size(110, 23);
            TotalTicketsLabel.TabIndex = 6;
            TotalTicketsLabel.Text = "Total Tickets";
            // 
            // TotalCashisersLabel
            // 
            TotalCashisersLabel.AutoSize = true;
            TotalCashisersLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCashisersLabel.Location = new Point(33, 35);
            TotalCashisersLabel.Name = "TotalCashisersLabel";
            TotalCashisersLabel.Size = new Size(119, 23);
            TotalCashisersLabel.TabIndex = 5;
            TotalCashisersLabel.Text = "Total Cashiers";
            // 
            // CashierGroupBox
            // 
            CashierGroupBox.Controls.Add(CashierReceiptsBox);
            CashierGroupBox.Controls.Add(CashierTicketsBox);
            CashierGroupBox.Controls.Add(CashierName);
            CashierGroupBox.Controls.Add(label2);
            CashierGroupBox.Controls.Add(TotalTicketsSoldLabel);
            CashierGroupBox.Controls.Add(CashierLabel);
            CashierGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CashierGroupBox.Location = new Point(22, 357);
            CashierGroupBox.Name = "CashierGroupBox";
            CashierGroupBox.Size = new Size(433, 187);
            CashierGroupBox.TabIndex = 14;
            CashierGroupBox.TabStop = false;
            CashierGroupBox.Text = "Cashier Summary Data";
            // 
            // CashierReceiptsBox
            // 
            CashierReceiptsBox.BorderStyle = BorderStyle.FixedSingle;
            CashierReceiptsBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CashierReceiptsBox.Location = new Point(237, 106);
            CashierReceiptsBox.Name = "CashierReceiptsBox";
            CashierReceiptsBox.ReadOnly = true;
            CashierReceiptsBox.Size = new Size(122, 27);
            CashierReceiptsBox.TabIndex = 12;
            CashierReceiptsBox.Text = "0";
            CashierReceiptsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CashierTicketsBox
            // 
            CashierTicketsBox.BorderStyle = BorderStyle.FixedSingle;
            CashierTicketsBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CashierTicketsBox.Location = new Point(237, 69);
            CashierTicketsBox.Name = "CashierTicketsBox";
            CashierTicketsBox.ReadOnly = true;
            CashierTicketsBox.Size = new Size(122, 27);
            CashierTicketsBox.TabIndex = 11;
            CashierTicketsBox.Text = "0";
            CashierTicketsBox.TextAlign = HorizontalAlignment.Center;
            // 
            // CashierName
            // 
            CashierName.BorderStyle = BorderStyle.FixedSingle;
            CashierName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CashierName.Location = new Point(237, 33);
            CashierName.Name = "CashierName";
            CashierName.ReadOnly = true;
            CashierName.Size = new Size(122, 27);
            CashierName.TabIndex = 5;
            CashierName.Text = "0";
            CashierName.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 106);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 7;
            label2.Text = "Total Receipts";
            // 
            // TotalTicketsSoldLabel
            // 
            TotalTicketsSoldLabel.AutoSize = true;
            TotalTicketsSoldLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TotalTicketsSoldLabel.Location = new Point(33, 69);
            TotalTicketsSoldLabel.Name = "TotalTicketsSoldLabel";
            TotalTicketsSoldLabel.Size = new Size(151, 23);
            TotalTicketsSoldLabel.TabIndex = 6;
            TotalTicketsSoldLabel.Text = "Total Tickets Sold";
            // 
            // CashierLabel
            // 
            CashierLabel.AutoSize = true;
            CashierLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CashierLabel.Location = new Point(33, 35);
            CashierLabel.Name = "CashierLabel";
            CashierLabel.Size = new Size(120, 23);
            CashierLabel.TabIndex = 5;
            CashierLabel.Text = "Cashier Name";
            // 
            // CinemaLogo
            // 
            CinemaLogo.Image = (Image)resources.GetObject("CinemaLogo.Image");
            CinemaLogo.ImageLocation = "";
            CinemaLogo.Location = new Point(22, 568);
            CinemaLogo.Name = "CinemaLogo";
            CinemaLogo.Size = new Size(433, 113);
            CinemaLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            CinemaLogo.TabIndex = 11;
            CinemaLogo.TabStop = false;
            // 
            // CashierPanel
            // 
            CashierPanel.Controls.Add(CashierNameLabel);
            CashierPanel.Controls.Add(CashierNameBox);
            CashierPanel.Controls.Add(TicketsGroupBox);
            CashierPanel.Location = new Point(22, 12);
            CashierPanel.Name = "CashierPanel";
            CashierPanel.Size = new Size(448, 234);
            CashierPanel.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 693);
            Controls.Add(CashierPanel);
            Controls.Add(CashierGroupBox);
            Controls.Add(CinemaLogo);
            Controls.Add(CompanyGroupBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Purchase Tickets";
            TicketsGroupBox.ResumeLayout(false);
            TicketsGroupBox.PerformLayout();
            panel1.ResumeLayout(false);
            CompanyGroupBox.ResumeLayout(false);
            CompanyGroupBox.PerformLayout();
            CashierGroupBox.ResumeLayout(false);
            CashierGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CinemaLogo).EndInit();
            CashierPanel.ResumeLayout(false);
            CashierPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label CashierNameLabel;
        private TextBox CashierNameBox;
        private GroupBox TicketsGroupBox;
        private Label ChildLabel;
        private Label StudentLabel;
        private Label AdultLabel;
        private TextBox ChildTicketBox;
        private TextBox StudentTicketBox;
        private TextBox AdultTicketBox;
        private Panel panel1;
        private Button CalculateButton;
        private Button ExitButton;
        private Button SummaryButton;
        private Button ClearButton;
        private GroupBox CompanyGroupBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox TotalCashiersBox;
        private Label TotalReceiptsLabel;
        private Label TotalTicketsLabel;
        private Label TotalCashisersLabel;
        private Label AvgTransPriceLabel;
        private TextBox AvgTransBox;
        private TextBox TotalReceiptsBox;
        private TextBox TotalTicketsBox;
        private ToolTip ToolTip;
        private PictureBox CinemaLogo;
        private GroupBox CashierGroupBox;
        private TextBox CashierReceiptsBox;
        private TextBox CashierTicketsBox;
        private TextBox CashierName;
        private Label label2;
        private Label TotalTicketsSoldLabel;
        private Label CashierLabel;
        private Panel CashierPanel;
    }
}