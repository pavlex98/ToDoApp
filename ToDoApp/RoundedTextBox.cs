using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public class RoundedTextBox : TextBox
    {
        // Свойство для установки радиуса углов
        private int _cornerRadius = 25;
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                Invalidate(); // Перерисовываем кнопку при изменении радиуса
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Включаем сглаживание для графики
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Создаем графический путь для закругленных углов
            using (GraphicsPath path = new GraphicsPath())
            {
                // Прямоугольники для закругленных углов
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, _cornerRadius, _cornerRadius), 180, 90);
                path.AddArc(new Rectangle(Width - _cornerRadius, 0, _cornerRadius, _cornerRadius), -90, 90);
                path.AddArc(new Rectangle(Width - _cornerRadius, Height - _cornerRadius, _cornerRadius, _cornerRadius), 0, 90);
                path.AddArc(new Rectangle(0, Height - _cornerRadius, _cornerRadius, _cornerRadius), 90, 90);
                path.CloseFigure();

                // Устанавливаем округленную область кнопки
                this.Region = new Region(path);

                // Заполняем кнопку стандартным фоном и обрабатываем текст
                pevent.Graphics.FillPath(new SolidBrush(this.BackColor), path);
                pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.ClientRectangle, new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });

                // Опционально: рисуем границу кнопки
                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    pevent.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
