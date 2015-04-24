using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;
using System.Threading;
using System.Timers;

namespace Project_Life
{
    public partial class Form1 : Form
    {
        #region Service
        int numOfCells = 120;
        int cellSize = 12;
        int diameter = 8;
        int selectStep = 0;
        int firstCreature = 0;
        static bool modeRun = false;

        public static List<Creature> tribe = new List<Creature>();         // Список всех существ
        public static List<Creature> newGeneration = new List<Creature>(); // Список родившихся существ
        public static Map map = new Map();

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void pField_MouseUp(object sender, MouseEventArgs e)
        {
            pField.Refresh();
        }
        #endregion

        #region Work modes
        private void pField_MouseDown(object sender, MouseEventArgs e)
        {
            #region Adding creature
            if (rbAddCreature.Checked == true)
            {
                if (selectStep == 0)
                {
                    selectStep = 1;
                }

                int currentX = 0;
                int currentY = 0;

                for (int i = 0; i < e.X; i = i + 12)
                {
                    currentX++;
                }

                for (int i = 0; i < e.Y; i = i + 12)
                {
                    currentY++;
                }
                lbCurrentX.Text = currentX.ToString();
                lbCurrentY.Text = currentY.ToString();

                Creature tmpCreature = new Creature();
                tmpCreature.x = currentX - 1;
                tmpCreature.y = currentY - 1;
                tmpCreature.dead = false;
                tribe.Add(tmpCreature);
                map.NewCreature(tmpCreature);
            }
            else
            {
                selectStep = 0;
            }
            #endregion
            #region Deleting creature
            if (rbDeleteCreature.Checked == true)
            {
                int currentX = 0;
                int currentY = 0;

                for (int i = 0; i < e.X; i = i + 12)
                {
                    currentX++;
                }

                for (int i = 0; i < e.Y; i = i + 12)
                {
                    currentY++;
                }
                
                lbCurrentX.Text = currentX.ToString();
                lbCurrentY.Text = currentY.ToString();

                currentX--;
                currentY--;

                for (int i = 0; i < tribe.Count; ++i)
                {
                    if (tribe[i].x == currentX && tribe[i].y == currentY)
                    {
                        tribe.RemoveAt(i);
                        map.map[currentX, currentY] = 0;
                    }
                }
            }
            #endregion
            #region TODO
            /*if (rbMoveCreature.Checked == true)
            {
                if (selectStep == 0)
                {
                    selectStep = 1;
                }

                for (int i = 0; i < tribe.Count; ++i)
                {
                    if (e.X < tribe[i].x + diameter / 2 && e.X > tribe[i].x - diameter / 2 &&
                        e.Y < tribe[i].y + diameter / 2 && e.Y > tribe[i].y - diameter / 2)
                    {
                        if (selectStep == 2)
                        {
                            int currentX = 0;
                            int currentY = 0;

                            for (int c = 0; c < e.X; c = c + 12)
                            {
                                currentX++;
                            }

                            for (int c = 0; c < e.Y; c = c + 12)
                            {
                                currentY++;
                            }


                        }
                        if (selectStep == 2)
                        {
                            selectStep = 0;
                        }

                        if (selectStep == 1)
                        {
                            selectStep = 2;
                        }
                        break;
                    }
                }
            }*/
            #endregion
        }
        #endregion

        #region Drawing on panel
        private void pField_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen line = new Pen(SystemColors.ControlDarkDark);
            Brush fill = new SolidBrush(SystemColors.InactiveCaption);
            Brush fillSelect = new SolidBrush(Color.Tomato);

            Pen creatureDraw = new Pen(SystemColors.ControlDarkDark);
            creatureDraw.Width = 2;

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(line, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(line, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }

            for (int i = 0; i < tribe.Count; ++i)
            {
                g.DrawEllipse(creatureDraw, ((tribe[i].x) * 12) + 2, ((tribe[i].y) * 12) + 2, diameter, diameter);

                if (selectStep == 2 && i == firstCreature)
                {
                    g.FillEllipse(fillSelect, ((tribe[i].x)* 12) + 2, ((tribe[i].y) * 12) + 2, diameter, diameter);
                }
                else
                {
                    g.FillEllipse(fill, ((tribe[i].x) * 12) + 2, ((tribe[i].y) * 12) + 2, diameter, diameter);
                }
            }
        }
        #endregion

        #region Coordinates
        private void pField_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordinates.Text = "(" + e.X + "," + e.Y + ")";
        }
        #endregion

        #region New simulation
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectStep = 0;
            firstCreature = 0;
            tribe.Clear();
            map.Clear();
            pField.Refresh();
            lbCurrentX.Text = "0";
            lbCurrentY.Text = "0";
        }
        #endregion

        #region Heroic stuff
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.H)
            {
                MessageBox.Show("My message");
            }
        }
        #endregion

        #region One step of simulation
        private void btnNextStep_Click(object sender, EventArgs e)
        {
            lookForCreature(ref tribe, ref map);
            pField.Refresh();
        }
        #endregion

        #region Checking creatures
        // Функция обхода списка существ
        public static void lookForCreature(ref List<Creature> tribe, ref Map map)
        {
            // Лист, используемый при удалении существ
            List<Creature> checkedCreature = new List<Creature>(); 

            for (int i = 0; i < tribe.Count; ++i) // Основной обход по списку существ
            {
                Coordinates coords = new Coordinates();
                coords.getCoordinates(tribe[i]); // Получение окрестностей для текущей клетки
                tribe[i].dead = lookIfDead(coords, ref map);
                searchingNeighborhood(coords, ref map, checkedCreature);
            }

            map.ClearChecked(checkedCreature); // Очищаем карту от меток проверенных клеток

            // Очистка основого списка от мёртвых существ
            for (int i = 0; i < tribe.Count; ++i)
            {
                if (tribe[i].dead == true)
                {
                    map.map[tribe[i].x, tribe[i].y] = 0;
                    tribe.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < newGeneration.Count; ++i)
            {
                // Добавление нового поколения в главный список и на карту
                tribe.Add(newGeneration[i]);
                map.NewCreature(newGeneration[i]);
            }

            // Очистка временных списков
            newGeneration.Clear();
            checkedCreature.Clear();
        }
        #endregion

        #region Looking for dead
        // Проверка, переживёт существо текущий ход или нет
        public static bool lookIfDead(Coordinates c, ref Map map)
        {
            short count = 0; // Количество окружающих существ

            for (int i = c.startx; i <= c.endx; ++i)
            {
                for (int j = c.starty; j <= c.endy; ++j)
                {
                    if (map.map[i, j] == 1)
                    {
                        count++;
                    }
                }
            }
            if (count == 3 || count == 4) // Если существо окружает 2 или 3 (+ оно само),
                return false;             // то оно выживает                
            else return true;
        }
        #endregion

        #region Searching neighborhood
        public static void searchingNeighborhood(Coordinates c, ref Map map, List<Creature> checkedCreature)
        {            
            for (int x = c.startx; x <= c.endx; ++x)
            {
                for (int y = c.starty; y <= c.endy; ++y)
                {
                    if (map.map[x, y] == 3 || map.map[x, y] == 1)
                        continue;

                    // Координаты окрестности соседа текущей клетки
                    Coordinates cn = new Coordinates();
                    cn.startx = x - 1;
                    cn.starty = y - 1;
                    cn.endx = x + 1;
                    cn.endy = y + 1;

                    if (x == 0)
                        cn.startx++;
                    if (y == 0)
                        cn.starty++;
                    if (x == 49)
                        cn.endx--;
                    if (y == 32)
                        cn.endy--;

                    Creature temporary = new Creature();
                    temporary.dead = false;
                    temporary.x = x;
                    temporary.y = y;

                    if (neighborsOfNeighbors(cn, ref map))
                    {
                        newGeneration.Add(temporary); 
                        // Если вокруг проверяемой клетки достаточно 
                        // существ, то родится новое существо
                    }

                    map.map[x, y] = 3; // 3 - проверенная клетка
                    checkedCreature.Add(temporary);                    
                }
            }
        }
        #endregion

        #region Looking for neighbors of neighbors
        public static bool neighborsOfNeighbors(Coordinates c, ref Map map)
            // Проверяет окрестности соседние клетки текущего существа
            // и определяет, родится ли там новое существо
        {
            int creatures = 0; // Количество существ вокруг текущего
            for (int x = c.startx; x <= c.endx; x++)
            {
                for (int y = c.starty; y <= c.endy; y++)
                {
                    if (map.map[x, y] == 1)
                        creatures++;
                }
            }
            if (creatures == 3)
                return true;
            else return false;
        }
        #endregion

        #region Endless cycle
        private void btnRunAndStop_Click(object sender, EventArgs e)
        {
            btnRunAndStop.Enabled = false;
            btnStop.Enabled = true;
            endlessCycleTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnRunAndStop.Enabled = true;
            btnStop.Enabled = false;
            endlessCycleTimer.Stop();
        }

        private void endlessCycleTimer_Tick(object sender, EventArgs e)
        {
            lookForCreature(ref tribe, ref map);
            pField.Refresh();
        }
        #endregion

        #region Saving to image
        private void saveAsImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save in PNG";
            saveDialog.InitialDirectory = Application.StartupPath;
            saveDialog.Filter = "PNG files (*.png)|*.png";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pField.Width, pField.Height);
                pField.DrawToBitmap(bmp, new Rectangle(0, 0, pField.Width, pField.Height));
                bmp.Save(saveDialog.FileName, ImageFormat.Bmp);
            }
        }
        #endregion

        #region Saving to file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save simulation";
            saveDialog.InitialDirectory = Application.StartupPath;
            saveDialog.Filter = "Simulation files (*.sim)|*.sim";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveDialog.FileName != "")
                {
                    try
                    {
                        using (Stream stream = File.Open(saveDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, tribe);
                            bin.Serialize(stream, map);
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Can't save!", "Error");
                    }
                }
            }
        }
        #endregion

        #region Opening file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectStep = 0;
            firstCreature = 0;
            tribe.Clear();
            map.Clear();
            pField.Refresh();
            lbCurrentX.Text = "0";
            lbCurrentY.Text = "0";

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open simulation";
            openDialog.InitialDirectory = Application.StartupPath;
            openDialog.Filter = "Simulation files (*.sim)|*.sim";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (openDialog.FileName != "")
                {
                    try
                    {
                        using (Stream stream = File.Open(openDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            tribe = (List<Creature>)bin.Deserialize(stream);
                            map = (Map)bin.Deserialize(stream);
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Can't open!", "Error");
                    }
                }
            }

        }
        #endregion
    }
}