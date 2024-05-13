using System.Security.Cryptography;
using System.Text;

namespace Login.util
{
    internal class Util
    {
        public static void OutgoingError(string message)
        {
            DialogResult result = MessageBox.Show(message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (result == DialogResult.OK)
                Environment.Exit(1);
        }

        public static async void DebugLabel(Label label, string text)
        {
            label.Text = text;
            await Task.Delay(1500);
            label.Text = "";
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
