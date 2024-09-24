using Microsoft.VisualBasic.ApplicationServices;
using System.Net;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClassicModels;

public partial class EntryForm : Form
{

    public EntryForm()
    {
        InitializeComponent();
        Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
    }

    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
    );

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    private static extern bool ReleaseCapture();

    private void ActionBar_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void lblClose_Click(object sender, EventArgs e) => Application.Exit();
    private void btnAction_Click(object sender, EventArgs e)
    {
        var result = ValidateLogin();

        if (!string.IsNullOrEmpty(result))
        {
            MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ShowDashboard();
    }

    private string ValidateLogin()
    {
        var errorMsg = new StringBuilder();

        if (boxUsername.Text.Length < 5)
            errorMsg.Append("\u2717 Username must be at least 5 characters long.\n");

        if (boxUsername.Text.Length < 8)
            errorMsg.Append("\u2717 Password must be at least 8 characters long.\n");

        if (errorMsg.Length != 0) return errorMsg.ToString();


        // TODO: Implement login logic here

        return errorMsg.ToString();
    }

    private void ShowDashboard()
    {
        Hide();


    }

    private void boxPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar != (char)Keys.Return) return;

    }

}
