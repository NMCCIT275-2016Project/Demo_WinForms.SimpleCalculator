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
        Topsoil,
        Sand,
        Limestone,
        Concrete,
        Clowns
    }

    public partial class MainForm : Form
    {

        private Dictionary<MaterialName, double> _density = new Dictionary<MaterialName, double>();
        private List<string> _materialNames = new List<string>();

        public MainForm()
        {
            InitializeDensityTable();
            InitializeComponent();
        }

        /// <summary>
        /// initialize the density table, lbs/cubic foot
        /// </summary>
        private void InitializeDensityTable()
        {
            _density.Add(MaterialName.Topsoil, 100);
            _density.Add(MaterialName.Sand, 101.8);
            _density.Add(MaterialName.Limestone, 150);
            _density.Add(MaterialName.Concrete, 145);
            _density.Add(MaterialName.Clowns, 145);
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
