using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Forms
{
    public partial class FrmCalendar : Form
    {
        private List<FlowLayoutPanel> listFlDay = new List<FlowLayoutPanel>();
        private DateTime currentDate = DateTime.Today;
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            GenerateDayPanel(42);
            DisplayCurrentDate();
        }
        private void DisplayCurrentDate()
        {
            lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy");
            AddLabelDayToToFlDay(GetFirstDayOfWeekOfCurrentDate(), GetTotalDaysOfCurrentDate());
        }
        private void PrevMonth()
        {
            currentDate = currentDate.AddMonths(-1);
            DisplayCurrentDate();
        }
        private void NextMonth()
        {
            currentDate = currentDate.AddMonths(+1);
            DisplayCurrentDate();
        }
        private void Today()
        {
            currentDate = DateTime.Today;
            DisplayCurrentDate();
        }
        private int GetFirstDayOfWeekOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return Convert.ToInt32(firstDayOfMonth.DayOfWeek + 1);
        }
        private int GetTotalDaysOfCurrentDate()
        {
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            return firstDayOfMonth.AddMonths(1).AddDays(-1).Day;
        }
        private void GenerateDayPanel(int totalDays)
        {
            flDays.Controls.Clear();
            listFlDay.Clear();
            for (int i = 1; i <= totalDays; i++)
            {
                FlowLayoutPanel fl = new FlowLayoutPanel();
                fl.Name = @"flDays(i)";
                fl.Size = new Size(112, 73);
                fl.BackColor = Color.White;
                fl.BorderStyle = BorderStyle.FixedSingle;
                flDays.Controls.Add(fl);
                listFlDay.Add(fl);
            }
        }
        private void AddLabelDayToToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            foreach (FlowLayoutPanel fl in listFlDay)
            {
                fl.Controls.Clear();
            }
            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                Label lbl = new Label();
                lbl.Name = @"lblDay(i)";
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(104, 23);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Century Gothic", 12);
                //listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Clear();
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrevMonth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NextMonth();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Today();
        }
    }
}
