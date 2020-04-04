using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForms.SimpleCalculator
{
    public enum MaterialName
    {
        TopSoil,
        Sand,
        CrushedStone,
        MediumFieldStone
    }

    public partial class MainForm : Form
    {

        private Dictionary<MaterialName, double> _density = new Dictionary<MaterialName, double>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {

        }

        private double volume()
        {
            return
                Convert.ToDouble(txtbox_Length) *
                Convert.ToDouble(txtbox_Width) *
                Convert.ToDouble(txtbox_Height);
        }
    }
}
