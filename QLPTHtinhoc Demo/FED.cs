using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPTHtinhoc_Demo
{
    public partial class FED : Form
    {
        public FED()
        {
            InitializeComponent();
        }
          public static int getid;
        public  FED(int _getid)
        {
            getid = _getid;
        }
    }
}
