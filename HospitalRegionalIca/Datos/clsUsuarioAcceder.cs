using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalRegionalIca
{
    public class clsUsuarioAcceder
    {
        private int mvarIdEmpleado;
        private string mvarApellidoPaterno;
        private string mvarApellidoMaterno;
        private string mvarNombres;
        private int mvarIdTipoEmpleado;
        private int mvarIdDepartamentoPertenece;
        private int mvaridTipoSexo;
        private int mvarIdTipoDocumento;
        private char mvarDni;
        private string mvarCodigoPlanilla;
        private DateTime mvarFechaIngreso;
        private DateTime mvarFechaAlta;
        private string mvarUsuario;
        private string mvarClave;
        private string mvarLoginPc;
        private DateTime mvarFechaNacimiento;

        public int IdEmpleado
        {
            get { return mvarIdEmpleado; }
            set { mvarIdEmpleado = value; }
        }
        public string ApellidoPaterno
        {
            get { return mvarApellidoPaterno; }
            set { mvarApellidoPaterno = value; }
        }
        public string ApellidoMaterno
        {
            get { return mvarApellidoMaterno; }
            set { mvarApellidoMaterno = value; }
        }
        public string Nombres
        {
            get { return mvarNombres; }
            set { mvarNombres = value; }
        }
        public int IdTipoEmpleado
        {
            get { return mvarIdTipoEmpleado; }
            set { mvarIdTipoEmpleado = value; }
        }
        public int IdDepartamentoPertenece
        {
            get { return mvarIdDepartamentoPertenece; }
            set { mvarIdDepartamentoPertenece = value; }
        }
        public int IdTipoSexo
        {
            get { return mvaridTipoSexo; }
            set { mvaridTipoSexo = value; }
        }
        public int IdTipoDocumento
        {
            get { return mvarIdTipoDocumento; }
            set { mvarIdTipoDocumento = value; }
        }
        public char Dni
        {
            get { return mvarDni; }
            set { mvarDni = value; }
        }
        public string Codigoplanilla
        {
            get { return mvarCodigoPlanilla; }
            set { mvarCodigoPlanilla = value; }
        }
        public DateTime FechaIngreso
        {
            get { return mvarFechaIngreso; }
            set { mvarFechaIngreso = value; }
        }
        public DateTime FechaAlta
        {
            get { return mvarFechaAlta; }
            set { mvarFechaAlta = value; }
        }
        public string Usuario
        {
            get { return mvarUsuario; }
            set { mvarUsuario = value; }
        }
        public string contrasena
        {
            get { return mvarClave; }
            set { mvarClave = value; }
        }        
        public string LoginPc
        {
            get { return mvarLoginPc; }
            set { mvarLoginPc = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return mvarFechaNacimiento; }
            set { mvarFechaNacimiento = value; }
        }





    }
}
