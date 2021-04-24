using System;

namespace AgenciaDeViajes
{
    class Reserva
    {

        public int id;
        public datetime fDesde;
        public datetime fHasta;
        public Alojamiento propiedad;
        public Usuario persona;
        public float precio;

        public Reserva(int id, datetime fDesde, datetime fHasta, Alojamiento propiedad, Usuario persona, float precio){
            this.id = id;
            this.fDesde = fDesde;
            this.fHasta = fHasta;
            this.propiedad = propiedad;
            this.persona = persona;
            this.precio = precio;
        }
    }
}