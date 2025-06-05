using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace game_hub
{
    public class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 30;
        public Color HoverColor { get; set; } = Color.FromArgb(169, 255, 169);
        private Color _normalColor;
        private bool _isImageButton = false;

        public Color NormalColor
        {
            get => _normalColor;
            set
            {
                _normalColor = value;
                if (!_isImageButton && !this.Focused && !this.Capture)
                    this.BackColor = value;
            }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.SetStyle(ControlStyles.Selectable, false);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);

            this.MouseEnter += (sender, e) => {
                if (!_isImageButton) this.BackColor = HoverColor;
            };

            this.MouseLeave += (sender, e) => {
                if (!_isImageButton) this.BackColor = NormalColor;
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_isImageButton)
            {
                // Special handling for image buttons
                if (Image != null)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    var path = GetRoundedPath();
                    e.Graphics.SetClip(path);
                    e.Graphics.DrawImage(Image, ClientRectangle);
                    e.Graphics.ResetClip();
                }
            }
            else
            {
                // Normal rounded button
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var path = GetRoundedPath();
                this.Region = new Region(path);

                using (var brush = new SolidBrush(BackColor))
                    e.Graphics.FillPath(brush, path);

                TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath GetRoundedPath()
        {
            var path = new GraphicsPath();
            int radius = CornerRadius;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            _isImageButton = this.BackgroundImage != null;
            if (!_isImageButton) NormalColor = this.BackColor;
        }

        protected override bool ShowFocusCues => false;
    }
}