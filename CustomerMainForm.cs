//------------------------------------------------------------------
// CustomerMainForm.cs (Modified for UserControls)
//------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using SedapMakanSystem;

public class CustomerMainForm : Form
{
    private Label lblWelcome;
    private FlowLayoutPanel buttonPanel;
    private Button btnBrowseOrder;
    private Button btnOrderStatusRefunds;
    private Button btnCancelOrder;
    private Button btnSendFeedback;
    private Button btnUpdateProfile;

    private Panel contentPanel; // Panel to host UserControls

    private string loggedInCustomerName = "Guest";

    public CustomerMainForm(string customerName = "Guest")
    {
        this.loggedInCustomerName = customerName;
        InitializeComponents();
        this.Text = "SedapMakan Customer Dashboard";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new Size(900, 700); // May need a larger main form
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
    }

    private void InitializeComponents()
    {
        // Welcome Label
        lblWelcome = new Label();
        lblWelcome.Text = $"Welcome, {loggedInCustomerName}!";
        lblWelcome.Font = new Font("Arial", 14, FontStyle.Bold);
        lblWelcome.AutoSize = true;
        lblWelcome.Location = new Point(20, 20);
        this.Controls.Add(lblWelcome);

        // Button Panel (as a sidebar or top bar)
        buttonPanel = new FlowLayoutPanel();
        buttonPanel.FlowDirection = FlowDirection.TopDown; // Or FlowDirection.LeftToRight for a top bar
        buttonPanel.WrapContents = false;
        buttonPanel.Size = new Size(220, this.ClientSize.Height - lblWelcome.Bottom - 40); // Example size for a sidebar
        buttonPanel.Location = new Point(20, lblWelcome.Bottom + 20);
        buttonPanel.Padding = new Padding(10);
        buttonPanel.BorderStyle = BorderStyle.FixedSingle;


        // Buttons (adjust size and margin as needed for the buttonPanel)
        btnBrowseOrder = CreateNavButton("Browse Menu & Order", BtnBrowseOrder_Click);
        btnOrderStatusRefunds = CreateNavButton("View Order Status & Refunds", BtnOrderStatusRefunds_Click);
        btnCancelOrder = CreateNavButton("Cancel Order / Request Refund", BtnCancelOrder_Click);
        btnSendFeedback = CreateNavButton("Send Feedback", BtnSendFeedback_Click);
        btnUpdateProfile = CreateNavButton("Update Profile", BtnUpdateProfile_Click);

        buttonPanel.Controls.AddRange(new Control[] {
            btnBrowseOrder, btnOrderStatusRefunds, btnCancelOrder, btnSendFeedback, btnUpdateProfile
        });
        this.Controls.Add(buttonPanel);

        // Content Panel (to display UserControls)
        contentPanel = new Panel();
        contentPanel.Location = new Point(buttonPanel.Right + 10, lblWelcome.Bottom + 20);
        contentPanel.Size = new Size(
            this.ClientSize.Width - buttonPanel.Right - 30,
            this.ClientSize.Height - lblWelcome.Bottom - 40
        );
        contentPanel.BorderStyle = BorderStyle.FixedSingle;
        contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.Controls.Add(contentPanel);

        // Load default control if needed
        LoadUserControl(new BrowseOrderControl()); // Example: Load browse/order by default
    }

    private Button CreateNavButton(string text, EventHandler clickEvent)
    {
        Button btn = new Button();
        btn.Text = text;
        btn.Size = new Size(180, 40); // Adjust size
        btn.Margin = new Padding(5, 10, 5, 10); // Add more vertical margin
        btn.Font = new Font("Arial", 10);
        btn.Click += clickEvent;
        return btn;
    }

    private void LoadUserControl(UserControl userControl)
    {
        contentPanel.Controls.Clear(); // Clear previous control
        userControl.Dock = DockStyle.Fill; // Make the UserControl fill the panel
        contentPanel.Controls.Add(userControl);
    }

    private void BtnBrowseOrder_Click(object sender, EventArgs e)
    {
        LoadUserControl(new BrowseOrderControl());
    }

    private void BtnOrderStatusRefunds_Click(object sender, EventArgs e)
    {
        LoadUserControl(new OrderStatusControl());
    }

    private void BtnCancelOrder_Click(object sender, EventArgs e)
    {
        LoadUserControl(new CancelOrderControl());
    }

    private void BtnSendFeedback_Click(object sender, EventArgs e)
    {
        LoadUserControl(new SendFeedbackControl());
    }

    private void BtnUpdateProfile_Click(object sender, EventArgs e)
    {
        LoadUserControl(new UpdateProfileControl());
    }

    // Main entry point if testing directly
    // [STAThread]
    // static void Main()
    // {
    //     Application.EnableVisualStyles();
    //     Application.SetCompatibleTextRenderingDefault(false);
    //     Application.Run(new CustomerMainForm("John Doe"));
    // }
}

// REMEMBER: You still need to create the UserControl files themselves
// (BrowseOrderControl.cs, OrderStatusControl.cs, etc.) and design their UI.

/*
// Example: BrowseOrderControl.cs (Simplified structure)
using System.Windows.Forms;
using System.Drawing;

public class BrowseOrderControl : UserControl
{
    public BrowseOrderControl()
    {
        this.Name = "BrowseOrderControl";
        this.Size = new Size(600, 500); // Example size, will be docked anyway
        InitializeComponents();
    }

    private void InitializeComponents()
    {
        Label lblTitle = new Label { Text = "Browse Menu & Place Order (UserControl)", Location = new Point(10,10), Font = new Font("Arial", 12, FontStyle.Bold), AutoSize=true };
        this.Controls.Add(lblTitle);

        // --- Add all your other UI elements here as designed before ---
        // ComboBox for categories, DataGridViews, Buttons, etc.
        // Example:
        Label placeholderLabel = new Label { Text = "Menu Browse controls appear here...", Location = new Point(10,40), Size = new Size(500,100) };
        this.Controls.Add(placeholderLabel);
    }
}
*/