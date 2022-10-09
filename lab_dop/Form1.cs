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
            ShowQueue();
        }

        private void BtnRefill_Click(object sender, EventArgs e)
        {
            this.TransportList.Clear();
            var rnd = new Random();
            for (var i =0; i<10;++i)
            {
                switch (rnd.Next() % 3)
                {
                    case 0:
                        this.TransportList.Add(Bike.Generate());
                        break;
                    case 1:
                        this.TransportList.Add(Car.Generate());
                        break;
                    case 2:
                        this.TransportList.Add(Plane.Generate());
                        break;
                }
            }
            ShowInfo();
            ShowQueue();
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

            txtInfo.Text = "Велосипед\tавто\tСамолет";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t{2}", bikeCount, carCount, planeCount);
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            if (this.TransportList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            var transport = this.TransportList[0];
            this.TransportList.RemoveAt(0);

            txtOut.Text = transport.GetInfo();
            ShowInfo();
            ShowQueue();
        }

        private void ShowQueue()
        {
            txtQueue.Text = "";
            if (this.TransportList.Count == 0)
            {
                txtQueue.Text = "Пусто Q_Q";
                return;
            }
            foreach (var transport in this.TransportList)
            {

                if (transport is Bike)
                {
                    txtQueue.Text += "велосипед\n";
                }
                else if (transport is Car)
                {
                    txtQueue.Text += "автомобиль\n";
                }
                else if (transport is Plane)
                {
                    txtQueue.Text += "самолет\n";
                }
            }
        }

    }
}
