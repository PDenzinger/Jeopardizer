using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

public class GrowLabel : Label
{
    private bool mGrowing;
    public bool AllowResize = true;

    public GrowLabel()
    {
        this.AutoSize = false;
    }

    private void resizeLabel()
    {
        if (AllowResize)
        {
            if (mGrowing) return;
            try
            {
                mGrowing = true;
                Size sz = new Size(this.ClientSize.Width, Int32.MaxValue);
                sz = TextRenderer.MeasureText(this.Text, this.Font, sz, TextFormatFlags.WordBreak);
                this.ClientSize = new Size(this.ClientSize.Width, sz.Height + this.Padding.Vertical);
            }
            finally
            {
                mGrowing = false;
            }
        }
    }

    protected override void OnPaddingChanged(EventArgs e)
    {
        base.OnPaddingChanged(e);
        resizeLabel();
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        resizeLabel();
    }

    protected override void OnFontChanged(EventArgs e)
    {
        base.OnFontChanged(e);
        resizeLabel();
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        resizeLabel();
    }
}