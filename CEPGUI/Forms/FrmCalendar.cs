using CEPGUI.Class;
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
        private void AddNewAppointement(object sender,EventArgs e)
        {
            try
            {
                int day = (int)((FlowLayoutPanel)sender).Tag;
                if (day != 0)
                {
                    FrmActivites fr = new FrmActivites();
                    fr.id = 0;
                    fr.descTxt.Text = "";
                    fr.activCombo.Text = "";
                    fr.heureTxt.Text = "";
                    fr.departTxt.Text = "";
                    fr.dateTxt.Value = new DateTime(currentDate.Year, currentDate.Month, day);
                    fr.dateTxt.Enabled = false;
                    fr.ShowDialog();
                    DisplayCurrentDate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivante est survenue lors de l'ajout de l'activité  : " + ex.Message);
            }
           
        }
        private void ShowAppointmentDetail(object sender,EventArgs e)
        {
            try
            {
                int appId = (int)((LinkLabel)sender).Tag;
                string sql = @"SELECT * FROM Affichage_Details_Activite WHERE Id=" + appId + "";
                DataTable dt = DynamicClasses.GetInstance().QueryAsDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    FrmActivites fr = new FrmActivites();
                    fr.id = Convert.ToInt32(row["Id"]);
                    fr.descTxt.Text = row["Description"].ToString();
                    fr.activCombo.Text = row["Activite"].ToString();
                    fr.heureTxt.Text = row["HeureActivite"].ToString();
                    fr.dgDepart.Rows.Add(DynamicClasses.GetInstance().retourId(row["Departement"].ToString(), "@design", "GET_ID_DEPART"), row["Departement"].ToString());
                    fr.dateTxt.Value = Convert.ToDateTime(row["DateActivite"]);
                    //fr.dateTxt.Enabled = false;
                    fr.ShowDialog();
                    DisplayCurrentDate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivante est survenue lors du chargement des données de l'activité : " + ex.Message);
            }
        }
        private void AddAppointmentToFlDay(int startDayAtFlNumber)
        {
            try
            {
                DateTime startDate = new DateTime(currentDate.Year, currentDate.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                string sql = @"SELECT * FROM Affichage_Details_Activite WHERE DateActivite BETWEEN '" + (startDate.ToString("yyyy-MM-dd")) + "' AND '" + (endDate.ToString("yyyy-MM-dd")) + "'";
                DataTable dt = DynamicClasses.GetInstance().QueryAsDataTable(sql);

                foreach (DataRow row in dt.Rows)
                {
                    DateTime appDay = Convert.ToDateTime(row["DateActivite"]);
                    LinkLabel link = new LinkLabel();
                    link.Name = @"link" + row["Id"];
                    link.Text = row["Activite"].ToString();
                    link.Tag = row["Id"];
                    link.Click += (EventHandler)ShowAppointmentDetail;
                    link.AutoSize = false;
                    link.TextAlign = ContentAlignment.MiddleLeft;
                    link.Size = new Size(104, 23);
                    link.Font = new Font("Century Gothic", 8);
                    listFlDay[(appDay.Day - 1) + (startDayAtFlNumber - 1)].Controls.Add(link);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue lors de l'affectation des événements aux dates : " + ex.Message);
            }
        }

        private void DisplayCurrentDate()
        {
            try
            {
                lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy");
                int firstDayAtFlNumber = GetFirstDayOfWeekOfCurrentDate();
                int totalDay = GetTotalDaysOfCurrentDate();
                AddLabelDayToToFlDay(firstDayAtFlNumber, totalDay);
                AddAppointmentToFlDay(firstDayAtFlNumber);
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue lors du chargement de la current date : " + ex.Message);
            }
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
            try
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
                    fl.Cursor = Cursors.Hand;
                    fl.Click += (EventHandler)AddNewAppointement;
                    flDays.Controls.Add(fl);
                    listFlDay.Add(fl);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue lors de la génération des panel days : " + ex.Message);
            }
        }
        private void AddLabelDayToToFlDay(int startDayAtFlNumber, int totalDaysInMonth)
        {
            try
            {
                foreach (FlowLayoutPanel fl in listFlDay)
                {
                    fl.Controls.Clear();
                    fl.Tag = 0;
                    fl.BackColor = Color.White;
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
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Tag = i;
                    listFlDay[(i - 1) + (startDayAtFlNumber - 1)].Controls.Add(lbl);

                    if (new DateTime(currentDate.Year, currentDate.Month, i) == DateTime.Today)
                    {
                        listFlDay[(i - 1) + (startDayAtFlNumber - 1)].BackColor = Color.Aqua;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("L'erreur suivant est survenue lors de l'ajout de label au Panel day : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PrevMonth();
            }
            catch (Exception ex)
            {

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NextMonth();
            }
            catch (Exception ex)
            {

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Today();
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
