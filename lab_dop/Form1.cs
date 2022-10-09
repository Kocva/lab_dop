using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_dop
{
    public partial class Form1 : Form
    {
        List<Transport> TransportList = new List<Transport>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void BtnRefill_Click(object sender, EventArgs e)
        {
            this.TransportList.Clear();
            for(var i =0; i<10;++i)
            {
                this.TransportList.Add(new Bike());

            }
            ShowInfo();
        }

        private void ShowInfo()
        {
            int bikeCount = 0;
            int carCount = 0;
            int planeCount = 0;

            foreach(var transport in this.TransportList)
            {
                if (transport is Bike)
                {
                    bikeCount += 1;
                }
                else if (transport is Car)
                {
                    carCount += 1;
                }
                else if (transport is Plane)
                {
                    planeCount += 1;
                }
            }

            txtInfo.Text = "Велосипед\tМашина\tСамолет";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", bikeCount, carCount, planeCount);
        }
    }
}
