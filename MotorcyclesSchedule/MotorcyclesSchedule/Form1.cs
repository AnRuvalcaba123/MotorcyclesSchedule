using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorcyclesSchedule
{
    public partial class Form1 : Form
    {
        public List<Schedule> list = new List<Schedule>();

        public Form1()
        {
            InitializeComponent();
        }

        private void cB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schedule obj = cB1.SelectedItem as Schedule;
            lbl1.Text = obj.Rides.ToString();
            if (obj.Rides == 8)
            {
                btmPlus.Enabled = false;
            }
            if (obj.Rides >= 8)
            {
                lbl1.BackColor = Color.Green;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            list.Add(new Schedule(8,"08:00-08:30"));
            list.Add(new Schedule(8,"08:30-09:00"));
            list.Add(new Schedule(8,"09:00-09:30"));
            list.Add(new Schedule(8,"09:30-10:00"));
            list.Add(new Schedule(8,"10:00-10:30"));
            list.Add(new Schedule(8,"10:30-11:00"));
            list.Add(new Schedule(8,"11:00-11:30"));
            list.Add(new Schedule(8,"11:30-12:00"));
            list.Add(new Schedule(8,"12:00-12:30"));
            list.Add(new Schedule(8,"12:30-13:00"));
            list.Add(new Schedule(8,"13:00-13:30"));
            list.Add(new Schedule(8,"13:30-14:00"));
            list.Add(new Schedule(8,"14:00-14:30"));
            list.Add(new Schedule(8,"14:30-15:00"));
            list.Add(new Schedule(8,"15:00-15:30"));
            list.Add(new Schedule(8,"15:30-16:00"));
            list.Add(new Schedule(8,"16:00-16:30"));
            list.Add(new Schedule(8,"16:30-17:00"));
            list.Add(new Schedule(8,"17:00-17:30"));
            list.Add(new Schedule(8,"17:30-18:00"));
            list.Add(new Schedule(8,"18:00-18:30"));
            list.Add(new Schedule(8,"18:30-19:00"));
            list.Add(new Schedule(8,"19:00-19:30"));
            list.Add(new Schedule(8,"19:30-20:00"));
            cB1.DataSource = list;
            cB1.DisplayMember = "Time";
            cB1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
