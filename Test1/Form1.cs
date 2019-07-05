using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CTest1 test1 = new CTest1();
            test1.Id = 1;
            test1.Name = 999;

            //PropertyInfo[] fields = test1.GetType().GetProperties(); //typeof(test1.).GetFields();

            //Type a = test1.GetType();
            //foreach (var item in fields)
            //{

            //   int tmp =  (int)item.GetValue(test1, null);
            //}

            test1.GetLength(test1.name);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CMakeDataTable<C1101A> mkDT = new CMakeDataTable<C1101A>();

            C1101A c1101a = new C1101A();

            c1101a.ID = "000001";
            c1101a.NAME = "조성준";
            c1101a.SEQ = 12345;

            mkDT.AddData(c1101a);

            c1101a.ID = "000002";
            c1101a.NAME = "김창성";
            c1101a.SEQ = 22222;

            mkDT.AddData(c1101a);

            DataTable dt = mkDT.DATATABLE;

           int n =  dt.Rows.Count;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CPLH plh = new CPLH();
            plh.ID = "cjooni";
            plh.NAME = "DATA";
            plh.SEQ = 5;

            byte[] aaa = plh.GetBuffer();
            string str = Encoding.Default.GetString(aaa).TrimEnd('\0');
           MessageBox.Show(str );

            
        }
    }
}
