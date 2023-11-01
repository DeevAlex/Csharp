using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // o MonthCalendar não da a possiblidade de pegar uma data selecionada

            // monthCalendar1.MaxDate; // retorna o maximo que o calendario consegue ir
            // monthCalendar1.MinDate; // retorna o minimo que o calendario consegue ir

            // monthCalendar1.TodayDate; // retorna o dia atual;

            DateTime data = monthCalendar1.TodayDate;

            MessageBox.Show(data.Day + " / " + data.Month + " / " + data.Year);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            MessageBox.Show(monthCalendar1.TodayDate.ToString());

        }
    }
}
