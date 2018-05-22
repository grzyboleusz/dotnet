using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form1 : Form
    {
        private void Preview()
        {
            Bitmap buffer = (Bitmap)bitmap.Clone();
            pictureBox1.Image = buffer;
        }

        private void Draw(Graphics graph, int X, int Y, MouseEventArgs e = null)
        {
            if (text_mode)
            {
                if (font == null)
                    return;

                graph.DrawString(textBox1.Text, font, new SolidBrush(color), X, Y);
            }


            if (e == null)
                return;

            Color color1, color2;
            if (e.Button == MouseButtons.Left)
            {
                color1 = color;
                color2 = color_secondary;
            }
            else if (e.Button == MouseButtons.Right)
            {
                color1 = color_secondary;
                color2 = color;
            }
            else
                return;

            if (text_mode)
            {
                graph.DrawString(textBox1.Text, font, new SolidBrush(color1), X, Y);
                return;
            }

            switch (current_tool)
            {
                case Tools.LINE:
                    if (Control.ModifierKeys == Keys.Shift)
                    {
                        int delta_x = Math.Abs(X - mouse_click_x);
                        int delta_y = Math.Abs(Y - mouse_click_y);
                        if (delta_x > delta_y)
                            Y = mouse_click_y;
                        else
                            X = mouse_click_x;
                    }

                    graph.DrawLine(new Pen(color1, pen_width), mouse_click_x, mouse_click_y, X, Y);
                    break;
                case Tools.RECT:
                    int x1, x2, y1, y2;

                    if (Control.ModifierKeys == Keys.Shift)
                        X = mouse_click_x + (Y - mouse_click_y);

                    if (X > mouse_click_x)
                    {
                        x1 = mouse_click_x;
                        x2 = X - mouse_click_x;
                    }
                    else
                    {
                        x1 = X;
                        x2 = mouse_click_x - X;
                    }

                    if (Y > mouse_click_y)
                    {
                        y1 = mouse_click_y;
                        y2 = Y - mouse_click_y;
                    }
                    else
                    {
                        y1 = Y;
                        y2 = mouse_click_y - Y;
                    }

                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            graph.DrawRectangle(new Pen(color1, pen_width), x1, y1, x2, y2);
                            break;
                        case 1:
                            graph.FillRectangle(new SolidBrush(color1), x1, y1, x2, y2);
                            graph.DrawRectangle(new Pen(color1, pen_width), x1, y1, x2, y2);
                            break;
                        case 2:
                            graph.FillRectangle(new SolidBrush(color2), x1, y1, x2, y2);
                            graph.DrawRectangle(new Pen(color1, pen_width), x1, y1, x2, y2);
                            break;
                    }
                    break;
                case Tools.ELLIPSE:
                    if (Control.ModifierKeys == Keys.Shift)
                        X = mouse_click_x + (Y - mouse_click_y);

                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            graph.DrawEllipse(new Pen(color1, pen_width), mouse_click_x, mouse_click_y, X - mouse_click_x, Y - mouse_click_y);
                            break;
                        case 1:
                            graph.FillEllipse(new SolidBrush(color1), mouse_click_x, mouse_click_y, X - mouse_click_x, Y - mouse_click_y);
                            graph.DrawEllipse(new Pen(color1, pen_width), mouse_click_x, mouse_click_y, X - mouse_click_x, Y - mouse_click_y);
                            break;
                        case 2:
                            graph.FillEllipse(new SolidBrush(color2), mouse_click_x, mouse_click_y, X - mouse_click_x, Y - mouse_click_y);
                            graph.DrawEllipse(new Pen(color1, pen_width), mouse_click_x, mouse_click_y, X - mouse_click_x, Y - mouse_click_y);
                            break;
                    }
                    break;
                case Tools.FREEHAND:
                    graph = Graphics.FromImage(bitmap);
                    graph.DrawLine(new Pen(color1), last_mouse_x, last_mouse_y, X, Y);
                    break;
                case Tools.FLOOD_FILL:
                    FloodFill(X, Y, color1);
                    mouse_down = false;
                    break;
                case Tools.AERO:
                    Random n = new Random();
                    for (int i = 0; i < pen_width; i++)
                    {
                        double ang = n.NextDouble() * Math.PI * 2;
                        double dist = n.NextDouble() * pen_width;
                        DrawPixel(ref bitmap, X - (int)(Math.Cos(ang) * dist), Y - (int)(Math.Sin(ang) * dist), color1);
                    }
                    break;
            }
        }

        private void DrawPixel(ref Bitmap bmp, int X, int Y, Color c)
        {
            if (X < 0 || X >= bmp.Width || Y < 0 || Y >= bmp.Height)
                return;
            bitmap.SetPixel(X, Y, c);
        }

        private void NewFile(bool dialog = true)
        {
            history = null;

            if (dialog)
                if (ShowNewFileDialog() != DialogResult.OK)
                    return;

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(bitmap);
            graph.Clear(Color.White);
            CenterImage();
            Preview();

            AddToHistory(bitmap);

            file_changed = true;

            labelOPENED_FILE.Text = "niezapisany obraz";
        }

        private bool SaveFile()
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ValidateNames && result == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
                file_changed = false;
                labelOPENED_FILE.Text = saveFileDialog1.FileName;
                return true;
            }
            return false;
        }

        private DialogResult ShowNewFileDialog()
        {
            string text = "Podaj wymiary:";
            string caption = "Nowy obraz";
            Form prompt = new Form();
            prompt.Width = 155;
            prompt.Height = 170;
            prompt.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 10, Top = 10, Text = text };
            NumericUpDown width = new NumericUpDown() { Left = 10, Top = 40, Minimum = 1, Maximum = 9999, Value = 640 };
            NumericUpDown height = new NumericUpDown() { Left = 10, Top = 70, Minimum = 1, Maximum = 9999, Value = 480 };
            Button confirmation = new Button() { Text = "Ok", Left = 10, Width = 120, Top = 100, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) =>
            {
                prompt.Close();
                pictureBox1.Width = (int)width.Value;
                pictureBox1.Height = (int)height.Value;
            };
            prompt.Controls.Add(width);
            prompt.Controls.Add(height);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog();
        }

        private void OpenFile()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Size = bitmap.Size;
                Graphics graph = Graphics.FromImage(bitmap);
                AddToHistory(bitmap);
                CenterImage();
                Preview();
                file_changed = false;
                labelOPENED_FILE.Text = openFileDialog1.FileName;
            }
        }

        private void FloodFill(int x, int y, Color color)
        {
            if ((x < 0) || (y < 0) || (x >= bitmap.Width) || (y >= bitmap.Height))
            {
                return;
            }
            Color cl = bitmap.GetPixel(x, y);
            if ((cl.R == color.R) && (cl.G == color.G) || (cl.B == color.B))
            {
                return;
            }

            DrawPixel(ref bitmap, x, y, color);
            pictureBox1.Refresh();
            FloodFill(x, y - 1, color);
            FloodFill(x + 1, y, color);
            FloodFill(x, y + 1, color);
            FloodFill(x - 1, y, color);
        }

        private void RefreshImage()
        {
            if (bitmap == null)
                return;
            Preview();
            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            Draw(graph, mouse_x, mouse_y, null);
            pictureBox1.Refresh();
        }

        private void SetFont()
        {
            FontFamily family = new FontFamily((string)comboBoxFONT_LIST.Items[comboBoxFONT_LIST.SelectedIndex]);

            checkBoxTEXT_BOLD.Enabled = true;
            checkBoxTEXT_ITALIC.Enabled = true;

            if (!family.IsStyleAvailable(FontStyle.Bold))
                checkBoxTEXT_BOLD.Enabled = false;
            if (!family.IsStyleAvailable(FontStyle.Italic))
                checkBoxTEXT_ITALIC.Enabled = false;

            if (!family.IsStyleAvailable(FontStyle.Regular))
            {
                if (checkBoxTEXT_BOLD.Enabled)
                {
                    checkBoxTEXT_BOLD.Checked = true;
                    font_style = font_style ^ FontStyle.Regular | FontStyle.Bold;
                }
                else if (checkBoxTEXT_ITALIC.Enabled)
                {
                    checkBoxTEXT_ITALIC.Checked = true;
                    font_style = font_style ^ FontStyle.Regular | FontStyle.Italic;
                }
            }

            font = new Font(family, (float)numericUpDown2.Value, font_style, GraphicsUnit.Pixel);

            RefreshImage();
        }

        private void CenterImage()
        {
            pictureBox1.Location = new Point(panel1.Width / 2 - pictureBox1.Width / 2, panel1.Height / 2 - pictureBox1.Height / 2);
        }

        private void Undo()
        {
            if (history != null)
            {
                Bitmap tmp = (Bitmap)bitmap.Clone();
                bitmap = (Bitmap)history.Clone();
                history = tmp;
                pictureBox1.Image = bitmap;
            }
                
        }

        private void AddToHistory(Bitmap bmp)
        {
            history = (Bitmap)bmp.Clone();
            toolStripUNDO.Enabled = true;
        }

    }
}
