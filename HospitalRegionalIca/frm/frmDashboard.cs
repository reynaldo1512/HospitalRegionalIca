using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HospitalRegionalIca
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            Dashboard();
            DashBoarFuenteFinanciamiento();
            DashBoarGeneroSis();
        }

        private void Dashboard()
        {
            clsDashboarConexion objDashboarConexion = new clsDashboarConexion();
            clsDashboard objDashboard = new clsDashboard();
            objDashboarConexion.DashboardMostrarByStoredProcedure(objDashboard);
            lblEmerMedicina.Text = objDashboard.DashboardEmerMedicina.ToString();
            lblEmerCirugia.Text = objDashboard.DashboardEmerCirugia.ToString();
            lblEmerPediatria.Text = objDashboard.DashboardEmerPediatria.ToString();
            lblEmerGineco.Text = objDashboard.DashboardEmerGineco.ToString();
            lblObservNino.Text = objDashboard.DashboardObserNino.ToString();
            lblObservAdulto.Text = objDashboard.DashboardObservAdulto.ToString();
            lblEmerCampCovid.Text = objDashboard.DashboardCampCovid.ToString();            
            lblEmerModuloMar.Text = objDashboard.DashboardEmerModuloMar.ToString();
            lblTotalFua.Text = objDashboard.DashboardTotalFua.ToString();

            //String CadenaConexion = @"Data Source=SISGALENPLUSHRI;Initial Catalog=SIGH;User ID=Sisgalenplus02;Password=Vannia1419;Connect Timeout=50;"; //sin usuario y contraseña
            //SqlConnection conexion = new SqlConnection(CadenaConexion);
            //SqlCommand cmd = new SqlCommand("dbo.usp_Dashboard", conexion);
            //conexion.Open();
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter total = new SqlParameter("@EmerMedicina", 0);
            //total.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(total);
            //cmd.ExecuteNonQuery();
            //lblEmerMedicina.Text = cmd.Parameters["@EmerMedicina"].Value.ToString();
            //conexion.Close();            
        }
        private void DashBoarFuenteFinanciamiento()
        {
            clsDashboarConexion objDashboarConexion = new clsDashboarConexion();
            clsDashboard objDashboard = new clsDashboard();
            objDashboarConexion.DashboardFuenteFinancimainetoByStoredPreocedure(objDashboard);
            chartFuenteFinanciamiento.Series[0].Points.DataBindXY(objDashboard.DashboardEmerFuentefinanciamiento,objDashboard.DashboardEmerFFCant);
        }
        private void DashBoarGeneroSis()
        {
            clsDashboarConexion objDashboarConexion = new clsDashboarConexion();
            clsDashboard objDashboard = new clsDashboard();
            objDashboarConexion.DashboardGeneroByStoredPreocedure(objDashboard);
            chartGeneros.Series[0].Points.DataBindXY(objDashboard.DashboardEmerGenero, objDashboard.DashboardEmergGeneroCant);
        }



    }
}
