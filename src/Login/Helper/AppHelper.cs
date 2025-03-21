namespace Login.Helper;

internal class AppHelper
{
    public static void OutgoingError(string message)
    {
        DialogResult result = MessageBox.Show(message, "Erro Interno", MessageBoxButtons.OK, MessageBoxIcon.Error);

        if (result == DialogResult.OK)
            Environment.Exit(1);
    }

    public static void DebugMessageBox(string text)
    {
        MessageBox.Show(text, "Aviso");
    }
}