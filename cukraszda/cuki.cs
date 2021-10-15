using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cukraszda
{
  class cuki
  {
    private string neve;

    public string Neve
    {
      get { return neve; }
      set { neve = value; }
    }

    private string tipus;

    public string Tipus
    {
      get { return tipus; }
      set { tipus = value; }
    }

    private bool dijazott;

    public bool Dijazott
    {
      get { return dijazott; }
      set { dijazott = value; }
    }

    private int ar;

    public int Ar
    {
      get { return ar; }
      set { ar = value; }
    }

    private string ertekesites;
      
    public string Ertekesites
    {
      get { return ertekesites; }
      set { ertekesites = value; }
    }

    public cuki(string neve, string tipus, bool dijazott, int ar, string ertekesites)
    {
      this.neve = neve;
      this.tipus = tipus;
      this.dijazott = dijazott;
      this.ar = ar;
      this.ertekesites = ertekesites;
    }
  }
}
