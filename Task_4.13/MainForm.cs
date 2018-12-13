using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Attestation_2.Task_4._13;
using Task_4._13;


namespace Task_4._13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Attestation_2.Task_4._13.BlastFurnace furnace;
        Attestation_2.Task_4._13.SmallLoader loader;
        private void startBTN_Click(object sender, EventArgs e)
        {
           // furnace = new BlastFurnace();
           // loader = new Attestation_2.Task_4._13.SmallLoader();
           // Thread loaderthread = new Thread(new ThreadStart(LoaderCycle));
           // loaderthread.Start();
           // int i = 15;
           ////
           //     furnace.WorkFurnace();
           //     textBox1.Lines[0] = "количество железа" + furnace.IronAmount + " Температура" + furnace.Temparature;
           //     //Thread.Sleep(10);
           //     //furnace.EndOfIron += new EventHandler(EndOfIron);
           //   //  i--;
           //// }
        }
        public void LoaderCycle()
        {
            //loader.AddCargo(10);
            ////Thread.Sleep(100);
            //furnace.IronAmount = loader.Carring_Amount;
            ////textBox1.Text = "Загружен металл";
            //loader.ShipCargo();
            ////Thread.Sleep(1000);
        }
        public void EndOfIron(Object senser,EventArgs args)
        {
            //BlastFurnace fur = (BlastFurnace)sender;
            //textBox1.Text += "Iron is end!";
        }
    }
}
