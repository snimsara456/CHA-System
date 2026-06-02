using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeHotspotSystem.Forms.Dashboard_items
{
    public partial class frmDashboard : Form

    {
        [DllImport("Gdi32.DLL", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
               (
                   int nLeftRect,
                   int nTopRect,
                   int nRightRect,
                   int nBottomRect,
                   int nWidthEllipse,
                   int nHeightEllipse
               );
        public frmDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlTotCrime.Region = Region.FromHrgn(CreateRoundRectRgn
       (
           0,
           0,
           pnlTotCrime.Width,
           pnlTotCrime.Height,
           30,
           30
       ));

            pnlMDA.Region = Region.FromHrgn(CreateRoundRectRgn
     (
         0,
         0,
        pnlMDA.Width,
        pnlMDA.Height,
         30,
         30
     ));

            pnlCrimeMonth.Region = Region.FromHrgn(CreateRoundRectRgn
     (
         0,
         0,
       pnlCrimeMonth.Width,
        pnlCrimeMonth.Height,
         30,
         30
     ));
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
