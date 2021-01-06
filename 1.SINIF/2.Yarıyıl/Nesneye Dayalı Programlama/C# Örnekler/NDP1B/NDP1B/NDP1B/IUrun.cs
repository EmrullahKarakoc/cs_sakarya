using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NDP1B
{
    interface IUrun
    {
        double turCarpani { get; }
        string turAdi { get; set; }
        int UcretHesap(double tonaj,double agirlik,double km);

    }
}
