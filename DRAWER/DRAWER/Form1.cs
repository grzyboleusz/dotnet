using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap history;
        InstalledFontCollection fonts;
        Font font;
        FontStyle font_style = FontStyle.Regular;

        bool mouse_down = false;
        bool file_changed = false;
        bool text_mode = false;
        bool no_preview = false;

        int mouse_click_x = 0;
        int mouse_click_y = 0;
        int mouse_x = 0;
        int mouse_y = 0;
        int last_mouse_x = 0;
        int last_mouse_y = 0;
        int pen_width = 1;

        Color color = Color.Black;
        Color color_secondary = Color.White;
        
        enum Tools { LINE, RECT, ELLIPSE, FREEHAND, FLOOD_FILL, AERO };
        Tools current_tool = Tools.LINE;

        public Form1()
        {
            InitializeComponent();
            
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = false;

            FontFamily fontFamily = new FontFamily("Arial");

            fonts = new InstalledFontCollection();
            foreach (FontFamily f in fonts.Families)
                comboBoxFONT_LIST.Items.Add(f.Name);

            font = new Font(fontFamily, 8, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFONT_LIST.SelectedIndex = comboBoxFONT_LIST.Items.IndexOf("Arial");

            NewFile(false);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouse_down)
            {
                Graphics graph = Graphics.FromImage(bitmap);

                if (!no_preview)
                    AddToHistory(bitmap);
                Draw(graph, e.X, e.Y, e);
                file_changed = true;
                Preview();
            }
            
            mouse_down = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            last_mouse_x = mouse_x;
            last_mouse_y = mouse_y;
            mouse_x = e.X;
            mouse_y = e.Y;
            if (mouse_down || text_mode)
            {
                Preview();

                Graphics graph = Graphics.FromImage(pictureBox1.Image);
                Draw(graph, e.X, e.Y, e);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (no_preview)
                AddToHistory(bitmap);

            mouse_down = true;
            mouse_click_x = e.X;
            mouse_click_y = e.Y;
        }

        private void radioButtonRECT_CheckedChanged(object sender, EventArgs e)
        {
            current_tool = Tools.RECT;
            comboBox1.Enabled = true;
            no_preview = false;
        }

        private void radioButtonLINE_CheckedChanged(object sender, EventArgs e)
        {
            current_tool = Tools.LINE;
            comboBox1.Enabled = false;
            no_preview = false;
        }

        private void radioButtonELIPSE_CheckedChanged(object sender, EventArgs e)
        {
            current_tool = Tools.ELLIPSE;
            comboBox1.Enabled = true;
            no_preview = false;
        }

        private void radioButtonPOINT_CheckedChanged(object sender, EventArgs e)
        {
            current_tool = Tools.FREEHAND;
            comboBox1.Enabled = false;
            no_preview = true;
        }

        private void radioButtonFLOOD_FILL_CheckedChanged(object sender, EventArgs e)
        {
            current_tool = Tools.FLOOD_FILL;
            comboBox1.Enabled = false;
            no_preview = false;
        }

        private void radioButtonAERO_CheckedChanged(object sender, EventArgs e)
        {
            current_tool = Tools.AERO;
            comboBox1.Enabled = false;
            no_preview = true;
        }

        private void labelCOLOR_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                labelCOLOR_MAIN.BackColor = color;
            }
        }

        private void labelCOLOR_SECONDARY_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color_secondary = colorDialog1.Color;
                labelCOLOR_SECONDARY.BackColor = color_secondary;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pen_width = (int)numericUpDown1.Value;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void toolStripMenuItemNEW_FILE_Click(object sender, EventArgs e)
        {
            if (file_changed)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać plik przed otworzeniem nowego?", "Zapisać zmiany?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dialogResult == DialogResult.No)
                {
                    NewFile();
                    return;
                }
                else
                    return;
            }

            NewFile();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (file_changed)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać plik przed otworzeniem nowego?", "Zapisać zmiany?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dialogResult == DialogResult.No)
                {
                    OpenFile();
                    return;
                }
            }

            OpenFile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (file_changed)
            {
                DialogResult dialogResult = MessageBox.Show("Czy chcesz zapisać plik przed wyjściem z programu?", "Zapisać zmiany?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = !SaveFile();
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (text_mode)
            {
                if (!comboBoxFONT_LIST.Focused)
                    textBox1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text_mode)
                RefreshImage();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                text_mode = true;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            else
            {
                text_mode = false;
                textBox1.Enabled = false;
            }
                
            Preview();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void comboBoxFONT_LIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void checkBoxTEXT_BOLD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTEXT_BOLD.Checked)
                font_style = font_style | FontStyle.Bold;
            else
                font_style = font_style ^ FontStyle.Bold;
            SetFont();
        }

        private void checkBoxTEXT_ITALIC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTEXT_ITALIC.Checked)
                font_style = font_style | FontStyle.Italic;
            else
                font_style = font_style ^ FontStyle.Italic;
            SetFont();
        }

        private void checkBoxTEXT_UNDERLINE_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTEXT_UNDERLINE.Checked)
                font_style = font_style | FontStyle.Underline;
            else
                font_style = font_style ^ FontStyle.Underline;
            SetFont();
        }

        private void checkBoxTEXT_STRIKEOUT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTEXT_STRIKEOUT.Checked)
                font_style = font_style | FontStyle.Strikeout;
            else
                font_style = font_style ^ FontStyle.Strikeout;
            SetFont();
        }

        private void COLORS_clicked(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            Label o = (Label)sender;

            if (ev.Button == MouseButtons.Left)
            {
                color = o.BackColor;
                labelCOLOR_MAIN.BackColor = color;
            }
            else if (ev.Button == MouseButtons.Right)
            {
                color_secondary = o.BackColor;
                labelCOLOR_SECONDARY.BackColor = color_secondary;
            }
                
        }

        private void zmieńRozmiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowNewFileDialog() != DialogResult.OK)
                return;

            Bitmap buffer = (Bitmap)bitmap.Clone();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Size = bitmap.Size;
            Graphics graph = Graphics.FromImage(bitmap);
            graph.Clear(Color.White);
            graph.DrawImage(buffer, 0, 0);
            CenterImage();
            Preview();

            file_changed = true;
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics grap = Graphics.FromImage(bitmap);
            grap.Clear(color_secondary);
            file_changed = true;
            Preview();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Undo();
        }
    }
}
