using System.Runtime.InteropServices;

namespace Management.Components;

public class RoundedTextBox : TextBox
{
    public RoundedTextBox()
    {
        this.BorderStyle = BorderStyle.None;
    }

    [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int height, int width);

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Region = Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
    }
}