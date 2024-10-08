﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public void agregar(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("insert into IMAGENES(IdArticulo, ImagenUrl) values(@IdArticulo, @ImagenUrl)");
                datos.setParametro("@IdArticulo", nuevo.Id);
                datos.setParametro("@ImagenUrl", nuevo.imgUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo img)
        {
            AccesoDatos datos = new AccesoDatos();
            Imagen art = new Imagen();
            try
            {
                datos.setConsulta("update IMAGENES set ImagenUrl = @URL where IdArticulo = @Id");
                datos.setParametro("@URL", img.Imagen);
                datos.setParametro("@Id", img.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
