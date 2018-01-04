using System;
using EntregaProductoTerminado.Models;
using EntregaProductoTerminado.ViewModels;
using EntregaProductoTerminado.Repositories;
using System.Web.Mvc;
using EntregaProductoTerminado.Email;
using System.Net.Mail;

namespace EntregaProductoTerminado.Controllers
{
    public class ProductoTerminadoController : Controller
    {
        // GET: Productos Terminados
        [HttpGet]
        public ActionResult Entrega(string opnumber)
        {
            if (opnumber != null)
            {
                MetricsRepository metrics = new MetricsRepository();
                DiboRepository dibo = new DiboRepository();
                OrdenDeProduccionViewModel viewModel = new OrdenDeProduccionViewModel();
                try
                {
                    OrdenDeProduccion ordenDeProduccion = metrics.GetByOp(opnumber);
                    viewModel.transactionMessage = ordenDeProduccion == null ? 
                        "No existe una orden de producción con el valor "
                        + opnumber.ToString().Trim() : "";
                    viewModel.ordenDeProduccion = ordenDeProduccion ?? new OrdenDeProduccion();
                    viewModel.OPHistorial = dibo.Consult(opnumber);
                }
                catch (Exception e)
                {
                    viewModel.transactionMessage = "Se ha presentado un error en la búsqueda" +
                        " de la orden de producción, favor contactar a los administradores de la página";
                }
                finally
                {
                    metrics.Dispose();
                    dibo.Dispose();
                }
                return View(viewModel);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Entrega(OrdenDeProduccionViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.ordenDeProduccion.FechaIngreso = DateTime.Now;
                DiboRepository dibo = new DiboRepository();
                OrdenDeProduccionViewModel ordenDeProduccionViewModel =
                    new OrdenDeProduccionViewModel();
                try
                {
                    if (viewModel != null 
                        && !String.IsNullOrEmpty(viewModel.ordenDeProduccion.NumeroOrdenProduccion))
                    {
                        //TODO in this part, change the insert in update should insert a new line por entrada a PT
                        if (dibo.Exists(viewModel.ordenDeProduccion.NumeroOrdenProduccion))
                        {
                            dibo.Update(viewModel.ordenDeProduccion);
                            ordenDeProduccionViewModel.transactionMessage = 
                                "Ingreso de entrega parcial exitosa, " +
                                "ha sido enviado un correo a los encargados" +
                                " de producto terminado";
                        }
                        else
                        {
                            viewModel.ordenDeProduccion.Entregas = 1;
                            if (viewModel.ordenDeProduccion.TotalCalculado > 
                                viewModel.ordenDeProduccion.MaximoAceptadoPorCliente)
                            {
                                viewModel.ordenDeProduccion.Excedente =
                                    viewModel.ordenDeProduccion.TotalCalculado - 
                                    viewModel.ordenDeProduccion.MaximoAceptadoPorCliente;
                            }
                            dibo.Add(viewModel.ordenDeProduccion);
                            ordenDeProduccionViewModel.transactionMessage = 
                                "Los valores han sido ingresados en el sistema de " +
                                "forma correcta, ha sido enviado un correo a los " + 
                                "encargados de producto terminado";
                        }
                        /*
                        PTSignal pT = new PTSignal("jchavarria@grupovargas.com, " +
                            "msanchez@grupovargas.com,focampo@grupovargas.com, " +
                            "dbarquero@grupovargas.com, mfonseca@grupovargas.com, " +
                            "cacuña@grupovargas.com, gvargas@grupovargas.com," +
                            "rrojas@grupovargas.com, fsanabria@grupovargas.com," +
                            "dramirez@grupovargas.com");
                        */
                        PTSignal pT = new PTSignal("lsanchez@grupovargas.com");
                        pT.SendEmail(viewModel.ordenDeProduccion);
                        dibo.Save();
                    }
                }
                catch (SmtpException exc)
                {
                    ordenDeProduccionViewModel.transactionMessage = 
                        "Ocurrió un error en el envío del correo a los encargados de " +
                        "producto terminado, favor contactar al administrador de la página";
                }
                catch (Exception e)
                {
                    ordenDeProduccionViewModel.transactionMessage = 
                        "Error en ingreso de datos al sistema, favor volver a intentar";
                }
                finally
                {
                    dibo.Dispose();
                }
                return View(ordenDeProduccionViewModel);
            }
            // In the return, lets send a message with the state of the transaction
            return View();
        }

        // GET: Historial
        [HttpGet]
        public ActionResult Historial(HistorialProductoTerminadoViewModel historialProducto)
        {
            if (ModelState.IsValid)
            {
                DiboRepository dibo = new DiboRepository();
                historialProducto.OPHistorial = dibo.OrdenList(historialProducto);
                dibo.Dispose();
                return View(historialProducto);
            }
            //En esta parte vamos a hacer la consulta a la tabla de OrdenDeProduccion
            return View();
        }
    }
}