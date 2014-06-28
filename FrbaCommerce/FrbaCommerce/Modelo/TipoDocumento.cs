using System;
using FrbaCommerce.DAO;
namespace FrbaCommerce.Modelo
{
    class TipoDocumento
    {
        public Int32 idTipoDocumento { get; set; }
        public String descTipoDocumento { get; set; }


        public TipoDocumento() { }

        public TipoDocumento(Int32 id_TipoDocumento)
        {
            TipoDocumento tipo = DaoTipoDocumento.getTipoDocumento(id_TipoDocumento);
            this.idTipoDocumento = id_TipoDocumento;
            this.descTipoDocumento = tipo.descTipoDocumento;
        }

    }
}