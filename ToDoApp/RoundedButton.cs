using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public class RoundedButton: Button
    {
        // Радиус закругления углов
        private int _cornerRadius = 30;

        // Свойство для изменения радиуса углов
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Очищаем фон для перерисовки
            pevent.Graphics.Clear(Parent.BackColor);

            // Включаем сглаживание
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Создаем путь для рисования с закругленными углами
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, _cornerRadius, _cornerRadius), 180, 90);
                path.AddArc(new Rectangle(Width - _cornerRadius, 0, _cornerRadius, _cornerRadius), -90, 90);
                path.AddArc(new Rectangle(Width - _cornerRadius, Height - _cornerRadius, _cornerRadius, _cornerRadius), 0, 90);
                path.AddArc(new Rectangle(0, Height - _cornerRadius, _cornerRadius, _cornerRadius), 90, 90);
                path.CloseFigure();

                // Заливаем кнопку цветом фона
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                // Рисуем границу кнопки
                using (Pen pen = new Pen(ForeColor, 2))
                {
                    pevent.Graphics.DrawPath(pen, path);
                }

                // Рисуем текст на кнопке
                TextRenderer.DrawText(pevent.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
    
}
