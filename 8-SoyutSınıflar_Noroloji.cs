using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SoyutSınıflar
{
    class Noroloji:Hasta//ctrl+. bize ne gerekiyosa söyler.
    {

        public override float boykiloHesabi(float boy, float kilo)//kesinlikle gövdeli metodun gövdesiz hale gelmesi.burada bvirtual demeden override edebildik.
        {
            stFnc();
            calis();
            return this.boy / this.kilo;
        }
        //farklı özellik
        public void calis() {
            System.Windows.Forms.MessageBox.Show("nörolojik çalıştı.");
        }

        public override int boyOran(int boy)
        {
            throw new NotImplementedException();
        }
    }
}
