namespace DataProtectionApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSetKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSetKey = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtKey
            //
            this.txtKey.Location = new System.Drawing.Point(20, 30);
            this.txtKey.Size = new System.Drawing.Size(300, 20);
            //
            // txtInput
            //
            this.txtInput.Location = new System.Drawing.Point(20, 80);
            this.txtInput.Multiline = true;
            this.txtInput.Size = new System.Drawing.Size(300, 60);
            //
            // txtResult
            //
            this.txtResult.Location = new System.Drawing.Point(20, 200);
            this.txtResult.Multiline = true;
            this.txtResult.Size = new System.Drawing.Size(300, 60);
            //
            // btnSetKey
            //
            this.btnSetKey.Location = new System.Drawing.Point(340, 28);
            this.btnSetKey.Size = new System.Drawing.Size(120, 23);
            this.btnSetKey.Text = "Установить ключ";
            this.btnSetKey.Click += new System.EventHandler(this.btnSetKey_Click);
            //
            // btnEncrypt
            //
            this.btnEncrypt.Location = new System.Drawing.Point(20, 150);
            this.btnEncrypt.Size = new System.Drawing.Size(120, 30);
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            //
            // btnDecrypt
            //
            this.btnDecrypt.Location = new System.Drawing.Point(160, 150);
            this.btnDecrypt.Size = new System.Drawing.Size(120, 30);
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            //
            // lblKey
            //
            this.lblKey.Location = new System.Drawing.Point(20, 10);
            this.lblKey.Text = "Ключ:";
            //
            // lblInput
            //
            this.lblInput.Location = new System.Drawing.Point(20, 60);
            this.lblInput.Text = "Введите текст:";
            //
            // lblResult
            //
            this.lblResult.Location = new System.Drawing.Point(20, 180);
            this.lblResult.Text = "Результат:";
            //
            // MainForm
            //
            this.ClientSize = new System.Drawing.Size(480, 280);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSetKey);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblKey);
