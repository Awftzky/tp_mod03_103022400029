namespace TP_Modul3_103022400029;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label lblOutput;
    private Button[] btnNumbers = new Button[10];
    private Button btnPlus;
    private Button btnEqual;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.lblOutput = new Label();
        this.btnPlus = new Button();
        this.btnEqual = new Button();

        // Label Output
        this.lblOutput.BorderStyle = BorderStyle.FixedSingle;
        this.lblOutput.Font = new Font("Segoe UI", 16F);
        this.lblOutput.Location = new Point(20, 20);
        this.lblOutput.Size = new Size(230, 40);
        this.lblOutput.TextAlign = ContentAlignment.MiddleRight;
        this.lblOutput.Text = "";

        // Buat Tombol Angka 1-9
        int btnSize = 70;
        for (int i = 1; i <= 9; i++)
        {
            btnNumbers[i] = new Button();
            btnNumbers[i].Text = i.ToString();
            btnNumbers[i].Size = new Size(btnSize, btnSize);
            int row = (i - 1) / 3;
            int col = (i - 1) % 3;
            btnNumbers[i].Location = new Point(20 + (col * 80), 80 + (row * 80));
            int num = i; // Closure
            btnNumbers[i].Click += (s, e) => { lblOutput.Text += num.ToString(); };
            this.Controls.Add(btnNumbers[i]);
        }

        // Tombol 0, +, =
        btnPlus.Text = "+";
        btnPlus.Size = new Size(btnSize, btnSize);
        btnPlus.Location = new Point(20, 320);
        btnPlus.Click += new EventHandler(this.btnPlus_Click);

        btnNumbers[0] = new Button();
        btnNumbers[0].Text = "0";
        btnNumbers[0].Size = new Size(btnSize, btnSize);
        btnNumbers[0].Location = new Point(100, 320);
        btnNumbers[0].Click += (s, e) => { lblOutput.Text += "0"; };

        btnEqual.Text = "=";
        btnEqual.Size = new Size(btnSize, btnSize);
        btnEqual.Location = new Point(180, 320);
        btnEqual.Click += new EventHandler(this.btnEqual_Click);

        // Form Settings
        this.ClientSize = new Size(275, 420);
        this.Controls.Add(this.lblOutput);
        this.Controls.Add(this.btnPlus);
        this.Controls.Add(this.btnEqual);
        this.Controls.Add(btnNumbers[0]);
        this.Text = "Kalkulator TP3";
    }
}