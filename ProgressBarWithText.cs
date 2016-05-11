using System;
using System.Drawing;
using System.Windows.Forms;

namespace EyeshotWcfClientWinForms
{
    /// <summary>
    /// The display type.
    /// </summary>
    public enum ProgressBarDisplayType
    {
        Percentage,
        Text,
        TextAndPercentage
    }

    /// <summary>
    /// The text location.
    /// </summary>
    public enum ProgressBarTextLocation
    {
        Left,
        Center,
        Right
    }

    /// <summary>
    /// A ProgressBar that shows a custom text.
    /// </summary>
    public class ProgressBarWithText : ProgressBar
    {
        public ProgressBarWithText()
        {
            // Modify the ControlStyles flags
            //http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx
            SetStyle(/*ControlStyles.UserPaint |*/ ControlStyles.AllPaintingInWmPaint, true);
            // Modify the ControlStyles flags to prevent the flickering.                        
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        
        private ProgressBarDisplayType _displayMode;
        public ProgressBarDisplayType DisplayMode
        {
            get { return _displayMode; }
            set
            {
                _displayMode = value;
                Invalidate();
            }
        }

        private ProgressBarTextLocation _textLocation;
        private TextFormatFlags _textFormatFlags;

        public ProgressBarTextLocation TextLocation
        {
            get { return _textLocation; }
            set
            {
                _textLocation = value;
                switch (value)
                {
                    case ProgressBarTextLocation.Left:
                        _textFormatFlags = TextFormatFlags.Left;
                        break;
                    case ProgressBarTextLocation.Center:
                        _textFormatFlags = TextFormatFlags.HorizontalCenter;
                        break;
                    case ProgressBarTextLocation.Right:
                        _textFormatFlags = TextFormatFlags.Right;
                        break;                    
                }

                Invalidate();
            }
        }
        
        private string _customText;
        public string CustomText
        {
            get { return _customText; }
            set
            {
                _customText = value;
                Invalidate();
            }
        }

        private const int WM_PAINT = 0x000F;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_PAINT:
                    int percent = Convert.ToInt32((Convert.ToDouble(Value)/Convert.ToDouble(Maximum))*100);
                    dynamic flags = TextFormatFlags.VerticalCenter | _textFormatFlags | TextFormatFlags.SingleLine | TextFormatFlags.WordEllipsis;

                    using (Graphics g = Graphics.FromHwnd(Handle))
                    {

                        string txt = String.Empty;
                        switch (DisplayMode)
                        {
                            case ProgressBarDisplayType.Percentage:
                                if (percent > 0)
                                    txt = percent + "%";
                                break;
                            case ProgressBarDisplayType.Text:
                                txt = CustomText;
                                break;
                            case ProgressBarDisplayType.TextAndPercentage:
                                if (percent > 0)
                                    txt = String.Format("{0} {1}%", CustomText, percent);
                                else
                                    txt = CustomText;
                                break;
                        }
                        
                        TextRenderer.DrawText(g, txt, Font, new Rectangle(0, 0, this.Width, this.Height), Color.Black, flags);
                    }

                    break;
            }
        }
    }
}


