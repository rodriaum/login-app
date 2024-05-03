namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Button button = loginButton;

            if (button != null)
            {
                if (string.IsNullOrEmpty(userTextBox.Text))
                {
                    DebugLabel(userDebugLabel, "Insira um e-mail válido.");
                  
                }

                if (string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    DebugLabel(passwordDebugLabel, "Insira uma password válida.");
                }

                // DebugLabel(loginDebugLabel, "Os parâmetros de login estão incorreto ou não existe registro.");


            }
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            userTextBox.Focus();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.Focus();
        }

        private async void DebugLabel(Label label, string text) {
            label.Text = text;
            await Task.Delay(1500);
            label.Text = "";
        }

    }
}
