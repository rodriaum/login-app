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
    }
}
