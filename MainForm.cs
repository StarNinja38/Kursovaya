// MainForm.cs
using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private TextBox txtInputMessage = new TextBox { Multiline = true, Width = 300, Height = 60 };
    private TextBox txtPassword = new TextBox { Width = 300, UseSystemPasswordChar = true };
    private TextBox txtOutputMessage = new TextBox { Multiline = true, Width = 300, Height = 60, ReadOnly = true };
    private Button btnEncrypt = new Button { Text = "Зашифровать" };
    private Button btnDecrypt = new Button { Text = "Расшифровать" };
    private Label lblStatus = new Label { Width = 300 };

    public MainForm()
    {
        this.Text = "Шифрование сообщений";
        this.Size = new System.Drawing.Size(350, 300);

        var layout = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown };
        layout.Controls.Add(new Label { Text = "Сообщение:" });
        layout.Controls.Add(txtInputMessage);
        layout.Controls.Add(new Label { Text = "Пароль:" });
        layout.Controls.Add(txtPassword);
        layout.Controls.Add(btnEncrypt);
        layout.Controls.Add(btnDecrypt);
        layout.Controls.Add(new Label { Text = "Результат:" });
        layout.Controls.Add(txtOutputMessage);
        layout.Controls.Add(lblStatus);

        btnEncrypt.Click += BtnEncrypt_Click;
        btnDecrypt.Click += BtnDecrypt_Click;

        this.Controls.Add(layout);
    }

    private void BtnEncrypt_Click(object sender, EventArgs e)
    {
        try
        {
            string encrypted = CryptoService.Encrypt(txtInputMessage.Text, txtPassword.Text);
            txtOutputMessage.Text = encrypted;
            lblStatus.Text = "Успешно зашифровано.";
        }
        catch
        {
            lblStatus.Text = "Ошибка при шифровании.";
        }
    }

    private void BtnDecrypt_Click(object sender, EventArgs e)
    {
        try
        {
            string decrypted = CryptoService.Decrypt(txtInputMessage.Text, txtPassword.Text);
            txtOutputMessage.Text = decrypted;
            lblStatus.Text = "Успешно расшифровано.";
        }
        catch
        {
            lblStatus.Text = "Ошибка при расшифровке. Возможно, неверный пароль.";
        }
    }
}
