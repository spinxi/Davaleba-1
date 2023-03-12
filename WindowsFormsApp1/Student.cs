using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        private string _gvari;
        private string _saxeli;
        private int _asaki;

        public void Minicheba(string gvari, string saxeli, int asaki)
        {
            _gvari = gvari;
            _saxeli = saxeli;
            _asaki = asaki;  
        }

        public string Gamotana()
        {
            //Console.WriteLine($"Gvari: {_gvari}, Saxeli: {_saxeli}, Asaki: {_asaki}");

            return ($"Gvari: {_gvari}, Saxeli: {_saxeli}, Asaki: {_asaki}");
        }

        private void MinichebaPrivate(string gvari, string saxeli, int asaki)
        {
            _gvari = gvari;
            _saxeli = saxeli;
            _asaki = asaki;
        }

        public void GamodzaxebaMinicheba(string gvari, string saxeli, int asaki)
        {
            MinichebaPrivate(gvari, saxeli, asaki);
        }

    }
}
