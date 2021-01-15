using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containerschip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Container> containerList = new List<Container>();
            int regularCount = Int32.Parse(textBox1.Text);
            for (int i = 0; i < regularCount; i++)
            {
                int containerWeight = Int32.Parse(textBox4.Text);
                Container container = new Container(Containerschip.Container.ContainerType.Regular ,containerWeight);
                containerList.Add(container);
            }
            int CooledCount = Int32.Parse(textBox2.Text);
            for (int i = 0; i < CooledCount; i++)
            {
                int containerWeight = Int32.Parse(textBox5.Text);
                Container container = new Container(Containerschip.Container.ContainerType.Cooled, containerWeight);
                containerList.Add(container);
            }
            int ValueableCount = Int32.Parse(textBox3.Text);
            for (int i = 0; i < ValueableCount; i++)
            {
                int containerWeight = Int32.Parse(textBox6.Text);
                Container container = new Container(Containerschip.Container.ContainerType.Valueable, containerWeight);
                containerList.Add(container);
            }
             new Dock().PlaceContainer(containerList,10,10);

        }
    }
}
