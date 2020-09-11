using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //int[] iPrice;
        //string[] sName;

        List<int> BookPrice;
        List<string> BookName;
        public Form1()
        {
            InitializeComponent();

            Book[] aBook = new Book[] {
                new Book("책1,",5000),
                new Book("책2,",6200),
                new Book("책3,",8300),
                new Book("책4,",10500),
                new Book("책5,",4700),
                new Book("책6,",9900),
                new Book("책7,",3200)};
            foreach(var Temp in aBook)
            {
                BookPrice.Add(Temp.Price);
                BookName.Add(Temp.Name);
            }
            //iPrice = new int[] { 90, 19, 34, 67, 56, 54 };
            //sName = new string[] { "철수", "영희", "영구", "맹구", "짱구", "몽구" };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.DataBindY(iPrice);
            //DataBindXY는 X,Y축 둘 다 바인딩
            chart1.Series[0].Points.DataBindXY(BookName,BookPrice);
        }
    }
}
