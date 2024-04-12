using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgAndStruct
{
    internal class MyTree
    {
        Node top;
        public Node SelectedNode;
        public Bitmap bitmap;
        public class Node
        {
            const int step = 30;
            const int Geom = 1;
            Graphics g;
            Pen MyPen;
            SolidBrush MyBrush;
            Font MyFont;
            public virtual void Search(int val) { }
            public virtual Node FindNode(int x, int y) { }

        }
    }
}
