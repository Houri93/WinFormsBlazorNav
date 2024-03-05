namespace WinFormsApp1;

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
        tabControl = new TabControl();
        tabPage1 = new TabPage();
        button1 = new Button();
        label1 = new Label();
        textBox1 = new TextBox();
        tabPage2 = new TabPage();
        webView = new Microsoft.Web.WebView2.WinForms.WebView2();
        label2 = new Label();
        label3 = new Label();
        tabControl.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
        SuspendLayout();
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabPage1);
        tabControl.Controls.Add(tabPage2);
        tabControl.Dock = DockStyle.Fill;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(800, 450);
        tabControl.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(label2);
        tabPage1.Controls.Add(button1);
        tabPage1.Controls.Add(label1);
        tabPage1.Controls.Add(textBox1);
        tabPage1.Location = new Point(4, 34);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(792, 412);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Forms";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(12, 185);
        button1.Name = "button1";
        button1.Size = new Size(774, 34);
        button1.TabIndex = 2;
        button1.Text = "Send";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(10, 120);
        label1.Name = "label1";
        label1.Size = new Size(114, 25);
        label1.TabIndex = 1;
        label1.Text = "Data to send";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(10, 148);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(776, 31);
        textBox1.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(webView);
        tabPage2.Location = new Point(4, 34);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(792, 412);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "WebView";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // webView
        // 
        webView.AllowExternalDrop = true;
        webView.CreationProperties = null;
        webView.DefaultBackgroundColor = Color.White;
        webView.Dock = DockStyle.Fill;
        webView.Location = new Point(3, 3);
        webView.Name = "webView";
        webView.Size = new Size(786, 406);
        webView.TabIndex = 0;
        webView.ZoomFactor = 1D;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 3);
        label2.Name = "label2";
        label2.Size = new Size(131, 25);
        label2.TabIndex = 3;
        label2.Text = "Data passed is:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(149, 3);
        label3.Name = "label3";
        label3.Size = new Size(0, 25);
        label3.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        tabControl.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabPage2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)webView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    private Button button1;
    private Label label1;
    private TextBox textBox1;
    private Label label2;
    private Label label3;
}
