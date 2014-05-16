using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.FrbaCommerce.Modelo
{
    class Cliente
    {
        UInt32 numeroDocumento;
        String tipoDocumento;
        String nombre;
        String apellido;
        String mail;
        
        String calle;
        UInt32 numero;
        String piso;
        String depto;

        UInt32 codigoPostal;
        DateTime fechaNacimiento;
        String username;
        UInt32 cuil;

        Telefono[] telefonos;
               

        public Cliente(String nombre, String apellido, UInt32 numeroDocumento) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.numeroDocumento = numeroDocumento;
        }

        public UInt32 getNumeroDocumento() {
            return this.numeroDocumento;
        }
        
        public String getTipoDocumento() {
            return this.tipoDocumento;
        }

        public String getNombre(){
            return this.nombre;
        }

        public String getApellido(){
            return this.apellido;
        }

        public String getMail(){
            return this.mail;
        }

        public String getCalle(){
            return this.calle;
        }

        public UInt32 getNumero(){
            return this.numero;
        }

        public String getPiso(){
            return this.piso;
        }

        public String getDepto(){
            return this.depto;
        }

        public UInt32 getCodigoPostal(){
            return this.codigoPostal;
        }

        public DateTime getFechaNacimiento(){
            return this.fechaNacimiento;
        }

        public String getUsername(){
            return this.username;
        }

        public UInt32 getCuil(){
            return this.cuil;
        }

        public Telefono[] getTelefonos()
        {
            return this.telefonos;
        }

        public void setNumeroDocumento(UInt32 numeroDocumento){
            this.numeroDocumento = numeroDocumento;
        }

        public void setTipoDocumento(String tipoDocumento){
            this.tipoDocumento = tipoDocumento;
        }

        public void setNombre(String nombre){
            this.nombre = nombre;
        }

        public void setApellido(String apellido){
            this.apellido = apellido;
        }

        public void setMail(String mail){
            this.mail = mail;
        }

        public void setCalle(String calle){
            this.calle = calle;
        }

        public void setNumero(UInt32 numero){
            this.numero = numero;
        }

        public void setPiso(String piso){
            this.piso = piso;
        }

        public void setDepto(String depto){
            this.depto = depto;
        }

        public void setCodigoPostal(UInt32 codigoPostal){
            this.codigoPostal = codigoPostal;
        }

        public void setFechaNacimiento(DateTime fechaNacimiento){
            this.fechaNacimiento = fechaNacimiento;
        }

        public void setUsername(String username){
            this.username = username;
        }

        public void setCuil(UInt32 cuil){
            this.cuil = cuil;
        }

        public void setTelefonos(Telefono[] telefonos)
        {
            this.telefonos = telefonos;
        }
    }
}
