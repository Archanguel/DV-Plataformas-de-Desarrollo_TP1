using System;

namespace AgenciaDeViajes
{
    class AgenciaManager
    {
        public Agencia miAgencia;
        List<Usuario> misUsuarios = new List<Usuario>();
        List<Reserva> misReserva = new List<Reserva>();

        public List<List<string>> buscarAlojamientos(){}
        public bool agregarAlojamiento(){} //public bool agregarAlojamiento(Datos del Alojamiento)
        public bool modificarAlojamiento(){} //public bool modificarAlojamiento(Datos del Alojamiento)
        public bool quitarAlojamiento(int código){}
        public List<List<string>> buscarReservas(int dniUsuario){}
        public bool reserva(int codAloj, int dniUsuario, datetime fDesde, datetime fHasta){}
        public bool modificarReserva(){} //public bool modificarReserva(Datos de Reserva)
        public bool eliminarReserva(int código){}
        public bool autenticarUsuario(int dni, string password){}
        public bool desbloquearUsuario(int dni){}
        public bool agregarUsuario(){} //public bool agregarUsuario(Datos del Usuario)
        public bool modificarUsuario(){} //public bool modificarUsuario(Datos del Usuario)
        public bool eliminarUsuario(int dni){}
    }
}