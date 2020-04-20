using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.UserControls
{
    public partial class UC_CalendarActivite : UserControl
    {
        public List<FlowLayoutPanel> listFlDay = new List<FlowLayoutPanel>();
        public UC_CalendarActivite()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GenerateDayPanel(int totalDays)
        {
            flDays.Controls.Clear();
            listFlDay.Clear();
            for (int i = 1; i < totalDays; i++)
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

        private void UC_CalendarActivite_Load(object sender, EventArgs e)
        {
            GenerateDayPanel(42);
            AddLabelDayToToFlDay(3,30);
        }
        private void AddLabelDayToToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            for (int i = 1; i <= totalDaysInMonth; i++)
            {
                Label lbl = new Label();
                lbl.Name = @"lblDay(i)";
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Size = new Size(104, 23);
                lbl.Text = i.ToString();
                lbl.Font = new Font("Century Gothic", 12);
                listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);
            }
        }
    }
}
