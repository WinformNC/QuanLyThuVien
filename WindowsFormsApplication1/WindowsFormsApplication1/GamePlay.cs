using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class GamePlay
    {
        public bool isEndGame(List<List<Button>> arr, Button b, int w, int h) 
        {
            return endHorizontal(arr, b, w) || endVertical(arr, b, h) || endPrimary(arr, b, w, h) || endSub(arr, b, w, h);
        }

        private bool endHorizontal(List<List<Button>> arr, Button b, int w)
        {
            Point point = GetChessPoint(arr, b);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (arr[point.Y][i].Text == b.Text)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < w; i++)
            {
                if (arr[point.Y][i].Text == b.Text)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
        }

        private bool endVertical(List<List<Button>> arr, Button b, int h)
        {
            Point point = GetChessPoint(arr, b);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (arr[i][point.X].Text == b.Text)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < h; i++)
            {
                if (arr[i][point.X].Text == b.Text)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        private bool endPrimary(List<List<Button>> arr, Button b, int w, int h)
        {
            Point point = GetChessPoint(arr, b);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (arr[point.Y - i][point.X - i].Text == b.Text)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= w - point.X; i++)
            {
                if (point.Y + i >= h || point.X + i >= w)
                    break;

                if (arr[point.Y + i][point.X + i].Text == b.Text)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool endSub(List<List<Button>> arr, Button b, int w, int h)
        {
            Point point = GetChessPoint(arr, b);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > w || point.Y - i < 0)
                    break;

                if (arr[point.Y - i][point.X + i].Text == b.Text)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= w - point.X; i++)
            {
                if (point.Y + i >= h || point.X - i < 0)
                    break;

                if (arr[point.Y + i][point.X - i].Text == b.Text)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        private Point GetChessPoint(List<List<Button>> arr, Button b)
        {
            int vertical = Convert.ToInt32(b.Tag);
            int horizontal = arr[vertical].IndexOf(b);

            Point point = new Point(horizontal, vertical);

            return point;
        }

    }
}
