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
        public ActionResult Entrega(int? opnumber)
        {
            if (opnumber != null)
            {
                SapRepository sap = new SapRepository();
                MetricsRepository metrics = new MetricsRepository();
                OrdenDeProduccionViewModel viewModel = new OrdenDeProduccionViewModel();
                OrdenDeProduccion ordenDeProduccion = sap.GetByOp(opnumber);
                ordenDeProduccion.Cliente = metrics.GetByOp(opnumber).NomeCliente;
                viewModel.ordenDeProduccion = ordenDeProduccion;
                sap.Dispose();
                metrics.Dispose();
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
                OrdenDeProduccionViewModel ordenDeProduccionViewModel = new OrdenDeProduccionViewModel();
                try
                {
                    if (viewModel != null && viewModel.ordenDeProduccion.NumeroOrdenProduccion != 0)
                    {
                        //Save the ViewModel
                        if (dibo.Exists(viewModel.ordenDeProduccion.NumeroOrdenProduccion))
                        {
                            ordenDeProduccionViewModel.transactionMessage = dibo.Update(viewModel.ordenDeProduccion, 
                                viewModel.ordenDeProduccion.NumeroOrdenProduccion);
                        }
                        else
                        {
                            dibo.Add(viewModel.ordenDeProduccion);
                            ordenDeProduccionViewModel.transactionMessage = "Los valores han sido ingresados en el sistema de " +
                                "forma correcta, ha sido enviado un correo a los encargados de producto terminado";
                        }
                        PTSignal pT = new PTSignal("jchavarria@grupovargas.com,msanchez@grupovargas.com,focampo@grupovargas.com");
                        pT.SendEmail(viewModel.ordenDeProduccion);
                        dibo.Save();
                    }
                }
                catch (SmtpException exc)
                {
                    ordenDeProduccionViewModel.transactionMessage = "Ocurrió un error en el envío del correo a los encargados de " +
                        "producto terminado, favor contactar al administrador de la página";
                }
                catch (Exception e)
                {
                    ordenDeProduccionViewModel.transactionMessage = "Error en ingreso de datos al sistema, favor volver a intentar";
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
        public ActionResult Historial()
        {
            return View();
        }
    }
}