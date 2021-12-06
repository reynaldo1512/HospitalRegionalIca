using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HospitalRegionalIca
{
    public class clsDashboard
    {
        private int mvarGenero;
        private int mvarEmerMedicina;
        private int mvarEmerPediatria;
        private int mvarEmerCirugia;
        private int mvarEmerGineco;
        private int mvarObservNino;
        private int mvarObservAdulto;
        private int mvarCampCovid;
        private int mvarEmerModuloMar;
        private int mvarTotalFua;
        ArrayList mvarEmerFuenteFinanciamiento = new ArrayList();
        ArrayList mvarEmerFFCant = new ArrayList();
        ArrayList mvarEmerGenero = new ArrayList();
        ArrayList mvarEmerGeneroCant = new ArrayList();

        public ArrayList DashboardEmerGenero
        {
            get { return mvarEmerGenero; }
            set { mvarEmerGenero = value; }
        }

        public ArrayList DashboardEmergGeneroCant
        {
            get { return mvarEmerGeneroCant; }
            set { mvarEmerGeneroCant = value; }
        }

        public ArrayList DashboardEmerFuentefinanciamiento
        {
            get { return mvarEmerFuenteFinanciamiento; }
            set { mvarEmerFuenteFinanciamiento = value; }
        }

        public ArrayList DashboardEmerFFCant
        {
            get { return mvarEmerFFCant; }
            set { mvarEmerFFCant = value; }
        }

        public int Genero
        {
            get { return mvarGenero; }
            set { mvarGenero = value; }
        }

        public int DashboardEmerMedicina
        {
            get { return mvarEmerMedicina; }
            set { mvarEmerMedicina = value; }
        }

        public int DashboardEmerPediatria
        {
            get { return mvarEmerPediatria; }
            set { mvarEmerPediatria = value; }
        }

        public int DashboardEmerCirugia
        {
            get { return mvarEmerCirugia; }
            set { mvarEmerCirugia = value; }
        }

        public int DashboardEmerGineco
        {
            get { return mvarEmerGineco; }
            set { mvarEmerGineco = value; }
        }

        public int DashboardObserNino
        {
            get { return mvarObservNino; }
            set { mvarObservNino = value; }
        }

        public int DashboardObservAdulto
        {
            get { return mvarObservAdulto; }
            set { mvarObservAdulto = value; }
        }

    public int DashboardCampCovid
        {
            get { return mvarCampCovid; }
            set { mvarCampCovid = value; }
        }

        public int DashboardEmerModuloMar
        {
            get { return mvarEmerModuloMar; }
            set { mvarEmerModuloMar = value; }
        }

        public int DashboardTotalFua
        {
            get { return mvarTotalFua; }
            set { mvarTotalFua = value; }
        }





    }
}
