using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDatamanager;


namespace formulario_parcial
{
    namespace formulario_parcial
    {
        internal class ExcepcionPropiaNueva : Exception
        {
            public ExcepcionPropiaNueva(string mensaje)
                : base(mensaje)
            {
                
                if (mensaje.Contains("Error al generar PDF"))
                {
                    
                    int numeroPedido = ObtenerNumeroPedidoDesdeMensaje(mensaje);

                    try
                    {
                        var pedidosForm = new Pedidos_Form(); 
                        pedidosForm.GenerarPdf(numeroPedido);
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show($"Error en segundo intento de generación del PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private int ObtenerNumeroPedidoDesdeMensaje(string mensaje)
            {
                
                return 0; 
            }
        }
    }
}
