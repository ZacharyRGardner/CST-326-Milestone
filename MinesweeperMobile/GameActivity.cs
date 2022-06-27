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
    [Activity(Label = "GameActivity")]
    public class GameActivity : Activity
    {
        public Button[,] btnGrid = new Button[10, 10];
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_game);

            // Create your application here
            GridView grid = (GridView)FindViewById(Resource.Id.gridView1);

            
            for (int r=0; r<10; r++)
            {
                for (int c = 0; c < 10; c++)
                {
                //    btnGrid[r,c] = new Button()
                //    btnGrid[r, c].Width = buttonSize;
                //    btnGrid[r, c].Height = buttonSize;
                //    btnGrid[r, c].MouseDown += Grid_Button_Click;
                //    panel1.Controls.Add(btnGrid[r, c]);
                //    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c);
                //    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                //    btnGrid[r, c].BackColor = Color.Cornsilk;
                //    btnGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;                
                }
            }

            
        }
    }
}