namespace WinFormsApp1;

public partial class Form1 : Form
{
    const string blazorAppUrl = "https://localhost:7231";
    const string customProtocolName = "mycustomprotocol://";
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        webView.NavigationStarting += WebView_NavigationStarting;
        webView.Source = new Uri(blazorAppUrl);

    }

    private void WebView_NavigationStarting(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
    {
        if (e.Uri.StartsWith(customProtocolName))
        {
            e.Cancel = true;
            var data = e.Uri[customProtocolName.Length..];
            tabControl.SelectedIndex = 0;
            label3.Text = data;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 1;
        webView.Source = new Uri($"{blazorAppUrl}/passdata/{textBox1.Text}");
    }
}
