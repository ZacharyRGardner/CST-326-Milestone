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
        static public int size = 10;
        static public Button[,] btnGrid = new Button[size, size];
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_game);
            
            // Create your application here
            TableLayout tableLayout = (TableLayout)FindViewById(Resource.Id.tableLayout2);
            tableLayout.WeightSum = 10;
            for (int r = 0; r < size; r++)
            {
                TableRow row = new TableRow(this)
                {
                    WeightSum = 10
                };
                TableRow.LayoutParams lp = new TableRow.LayoutParams(TableRow.LayoutParams.MatchParent, TableRow.LayoutParams.WrapContent); row.LayoutParameters = lp;
                for (int c = 0; c < size; c++)
                {
                    var b = new Button(this)
                    {
                        Text = "m"
                    };
                    LinearLayout.LayoutParams paramsBtn = new LinearLayout.LayoutParams(0, LinearLayout.LayoutParams.WrapContent)
                    {
                        Weight = 1
                    };
                    b.LayoutParameters = new TableRow.LayoutParams(TableRow.LayoutParams.MatchParent, TableRow.LayoutParams.WrapContent);
                    row.AddView(b);
                    
                    
                }
                tableLayout.AddView(row);
            }


        }
    }
}