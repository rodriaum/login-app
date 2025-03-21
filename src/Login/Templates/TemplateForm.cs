namespace Login.Login.Templates;

public class TemplateForm : Form
{
    private Size _originalFormSize;
    private Dictionary<Control, Rectangle> _originalControlData = new Dictionary<Control, Rectangle>();

    private bool _isLoaded = false;

    public TemplateForm() : base()
    {
        if (this.DesignMode) return;

        this.Load += this.Form_Load;
        this.Resize += this.Form_Resize;
    }

    private void Form_Load(object? sender, EventArgs e)
    {
        if (this.Controls.Count == 0) return;

        _originalFormSize = this.Size;

        foreach (Control control in this.Controls)
        {
            _originalControlData.Add(control, new Rectangle(control.Location, control.Size));

            if (control is Label label && label.AutoSize)
            {
                label.Tag = label.Font.Size;
            }
        }

        this._isLoaded = true;
    }

    private void Form_Resize(object? sender, EventArgs e)
    {
        if (this._isLoaded)
            ResizeAllControls();
    }

    private void ResizeAllControls()
    {
        try
        {
            float widthRatio = (float)this.Width / _originalFormSize.Width;
            float heightRatio = (float)this.Height / _originalFormSize.Height;

            foreach (Control control in this.Controls)
            {
                if (_originalControlData.TryGetValue(control, out Rectangle originalRect))
                {
                    int newX = (int)(originalRect.X * widthRatio);
                    int newY = (int)(originalRect.Y * heightRatio);
                    int newWidth = (int)(originalRect.Width * widthRatio);
                    int newHeight = (int)(originalRect.Height * heightRatio);

                    control.Location = new Point(newX, newY);
                    control.Size = new Size(newWidth, newHeight);

                    if (control is Label label && label.Tag != null)
                    {
                        float originalFontSize = (float)label.Tag;
                        float scaleFactor = Math.Min(widthRatio, heightRatio);
                        label.Font = new Font(label.Font.FontFamily, originalFontSize * scaleFactor, label.Font.Style);
                    }

                    if (control is TextBox textBox)
                    {
                        if (textBox.Tag == null)
                            textBox.Tag = textBox.Font.Size;

                        float originalFontSize = (float)textBox.Tag;
                        float scaleFactor = Math.Min(widthRatio, heightRatio);
                        textBox.Font = new Font(textBox.Font.FontFamily, originalFontSize * scaleFactor, textBox.Font.Style);
                    }

                    if (control is Button button)
                    {
                        if (button.Tag == null)
                            button.Tag = button.Font.Size;

                        float originalFontSize = (float)button.Tag;
                        float scaleFactor = Math.Min(widthRatio, heightRatio);
                        button.Font = new Font(button.Font.FontFamily, originalFontSize * scaleFactor, button.Font.Style);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro ao Redimensionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}