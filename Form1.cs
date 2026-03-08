namespace TP_Modul3_103022400029;

public partial class Form1 : Form
{
    private int result = 0;

    public Form1()
    {
        InitializeComponent();
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(lblOutput.Text))
        {
            result += int.Parse(lblOutput.Text);
            lblOutput.Text = ""; // Kosongkan layar untuk angka berikutnya
        }
    }

    private void btnEqual_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(lblOutput.Text))
        {
            result += int.Parse(lblOutput.Text);
            lblOutput.Text = result.ToString();
            result = 0; // Reset setelah selesai
        }
    }
}