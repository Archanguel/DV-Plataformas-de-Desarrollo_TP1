using System;

namespace AgenciaDeViajes
{
    class Usuario
    {
        public int dni;
        public String nombre;
        public String mail;
        public String password;
        public bool esAdmin;
        public bool bloqueado;

        public Usuario(int dni, String nombre, String mail, String password, bool esAdmin, bool bloqueado){
            this.dni = dni;
            this.nombre = nombre;
            this.mail = mail;
            this.password = password;
            this.esAdmin = esAdmin;
            this.bloqueado = bloqueado;
        }
    }
}