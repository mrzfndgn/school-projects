using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_app
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime myVacation1 = new DateTime(2019, 2, 23);
            DateTime myVacation2 = new DateTime(2019, 2, 27);

            monthCalendar1.AddBoldedDate(myVacation1);
            monthCalendar1.AddBoldedDate(myVacation2);
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Tuesday;
            this.monthCalendar1.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 20;
            this.monthCalendar1.ShowToday = true;
            this.monthCalendar1.ShowTodayCircle = true;
            this.monthCalendar1.ShowWeekNumbers = true;

            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
        }
        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            // Show the start and end dates in the text box.
            this.label1.Text = "Date Selected: Start = " +
                e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
