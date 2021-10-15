using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace cukraszda
{
  public partial class Form1 : Form
  {
    List<cuki> Cukik = new List<cuki>();
    public Form1()
    {
      InitializeComponent();
      beolvas();
      masodikfeladat();
    }

    private void masodikfeladat()
    {
  
    }

    private void beolvas()
    {
      StreamReader be = new StreamReader("cuki.txt");



      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');

        Cukik.Add(new cuki(a[0],a[1],Convert.ToBoolean(a[2]),int.Parse(a[3]),a[4]));
      }


      be.Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    
  }
}
