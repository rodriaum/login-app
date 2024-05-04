namespace Login.util
{
    internal class Util
    {
        public static void OutgoingError(string message)
        {
            MessageBox.Show(message, "Erro",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static async void DebugLabel(Label label, string text)
        {
            label.Text = text;
            await Task.Delay(1500);
            label.Text = "";
        }
    }
}
