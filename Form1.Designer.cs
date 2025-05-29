using System;
using System.Windows.Forms;

namespace DataProtectionApp
{
    public partial class MainForm : Form
    {
        private Encryptor encryptor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Введите ключ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            encryptor = new Encryptor(key);
            MessageBox.Show("Ключ установлен успешно.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (encryptor == null)
            {
                MessageBox.Show("Сначала установите ключ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string input = txtInput.Text;
            txtResult.Text = encryptor.Encrypt(input);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (encryptor == null)
            {
                MessageBox.Show("Сначала установите ключ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string input = txtInput.Text;
                txtResult.Text = encryptor.Decrypt(input);
            }
            catch
            {
                MessageBox.Show("Ошибка при расшифровке. Проверьте ключ и формат строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
