using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HospitalRegionalIca
{
   public  class clsDashboarConexion
    {
        private String CadenaConexion = @"Data Source=SISGALENPLUSHRI;Initial Catalog=SIGH;User ID=Sisgalen;Password=password;Connect Timeout=50;"; //sin usuario y contraseña


        public void DashboardMostrarByStoredProcedure(clsDashboard objDashboard)
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlCommand cmd = new SqlCommand("dbo.usp_Dashboard",Conexion);
            Conexion.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("@EmerMedicina",SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@EmerPediatria", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@EmerCirugia", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@EmerGineco", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@ObservaAdulto", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@ObservaNino", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@EmerCampCovid", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@EmerModuloMar", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@TotalFua", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            objDashboard.DashboardEmerMedicina = Convert.ToInt32(cmd.Parameters["@EmerMedicina"].Value);
            objDashboard.DashboardEmerPediatria = Convert.ToInt32(cmd.Parameters["@EmerPediatria"].Value);
            objDashboard.DashboardEmerCirugia = Convert.ToInt32(cmd.Parameters["@EmerCirugia"].Value);
            objDashboard.DashboardEmerGineco = Convert.ToInt32(cmd.Parameters["@EmerGineco"].Value);
            objDashboard.DashboardObservAdulto = Convert.ToInt32(cmd.Parameters["@ObservaAdulto"].Value);
            objDashboard.DashboardObserNino = Convert.ToInt32(cmd.Parameters["@ObservaNino"].Value);
            objDashboard.DashboardCampCovid = Convert.ToInt32(cmd.Parameters["@EmerCampCovid"].Value);
            objDashboard.DashboardEmerModuloMar = Convert.ToInt32(cmd.Parameters["@EmerModuloMar"].Value);
            objDashboard.DashboardTotalFua = Convert.ToInt32(cmd.Parameters["@TotalFua"].Value);

            Conexion.Close();            
        }
        
        public void DashboardFuenteFinancimainetoByStoredPreocedure(clsDashboard objDashboard)
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("dbo.usp_DashboardFuenteFinanciamiento", Conexion);
            Conexion.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                objDashboard.DashboardEmerFuentefinanciamiento.Add(dr.GetString(0));
                objDashboard.DashboardEmerFFCant.Add(dr.GetInt32(1));
            }
            dr.Close();
            Conexion.Close();
        }

        public void DashboardGeneroByStoredPreocedure(clsDashboard objDashboard)
        {
            SqlConnection Conexion = new SqlConnection(CadenaConexion);
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("dbo.usp_DashboardGenero", Conexion);
            Conexion.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                objDashboard.DashboardEmerGenero.Add(dr.GetString(0));
                objDashboard.DashboardEmergGeneroCant.Add(dr.GetInt32(1));
            }
            dr.Close();
            Conexion.Close();
        }
    }
}
