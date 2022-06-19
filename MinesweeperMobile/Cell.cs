using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinesweeperMobile
{
    class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int LiveNeighbors { get; set; }
        public Boolean Visited { get; set; }
        public Boolean Live { get; set; }
        public Boolean Flagged { get; set; }

        public Cell(int Row, int Column, int LiveNeighbors, Boolean Visited, Boolean Live, Boolean Flagged)
        {
            this.Row = Row;
            this.Column = Column;
            this.LiveNeighbors = 0;
            this.Visited = false;
            this.Live = false;
            this.Flagged = false;
        }
    }
}