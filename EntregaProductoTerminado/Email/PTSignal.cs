using System;
using System.Text;
using System.Net.Mail;
using System.Net;
using EntregaProductoTerminado.Models;

namespace EntregaProductoTerminado.Email
{
    public class PTSignal : IEmail<OrdenDeProduccion>
    {
        private const string _correoFuente = "reportesgv@grupovargas.com";
        private readonly string _correoDestino;
        private const string _host = "smtp.office365.com";
        private const short _puerto = 587;
        private const string _credencialesUserName = "reportesgv@grupovargas.com";
        private const string _credencialesPassword = "Vargas2015";

        public PTSignal(string correoDestino)
        {
            // TODO for several emails, use ,
            this._correoDestino = correoDestino;
        }
        public StringBuilder BuildMessage(OrdenDeProduccion orden)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<h2>Se hizo un ingreso a producto terminado</h2> " +
            "<p>Detalles abajo: </p> " +
            "<table style=\"border: 1px solid #000000\"> " +
                "<thead style=\"background-color: #a6fcf4\"> " +
                "<tr style=\"border-bottom: 1px solid #222222\"> " +
                    "<th style=\"padding-right:10px; border-right: 1px solid #000000\">OP</th> " +
                    "<th style=\"padding-right:10px; border-right: 1px solid #000000\">Cliente</th> " +
                    "<th style=\"padding-right:10px; border-right: 1px solid #000000\">Bultos</th> " +
                    "<th style=\"padding-right:10px; border-right: 1px solid #000000\">Unidades por bulto</th> " +
                    "<th style=\"padding-right:10px; border-right: 1px solid #000000\">Fracción</th> " +
                    "<th style=\"padding-right:10px; border-right: 1px solid #000000\">Total Ingresado</th> " +
                    "<th style=\"padding-right:10px; border-right: 1px solid #000000\">Excedente</th> " +
                "</tr></thead><tbody style=\"background-color: #ffffff\"><tr>");
            builder.Append(String.Format("<td style=\"padding: 5px\">{0}</td> " +
                "<td style=\"padding:5px\">{1}</td> " +
                "<td style=\"padding:5px\">{2:n}</td> " +
                "<td style=\"padding:5px\">{3:n}</td> " +
                "<td style=\"padding:5px\">{4:n}</td> " +
                "<td style=\"padding:5px\">{5:n}</td> " +
                "<td style=\"padding:5px\">{6:n}</td> ", orden.NumeroOrdenProduccion, orden.Cliente, orden.Bultos,
                orden.UnidadesPorBulto, orden.Fraccion, orden.TotalCalculado, orden.Excedente));
            builder.Append("</tr></tbody></table><br/> " +
        "Nota: <i>Este correo fue generado automáticamente, si presenta errores favor contactar a los administradores de la aplicación</i> ");
            return builder;
        }

        public void SendEmail(OrdenDeProduccion orden)
        {
            SmtpClient smtpClient = new SmtpClient(_host, _puerto);
            MailMessage mailMessage = new MailMessage(_correoFuente, _correoDestino, "Aviso de Ingreso a PT",BuildMessage(orden).ToString());
            mailMessage.IsBodyHtml = true;
            smtpClient.Credentials = new NetworkCredential(_credencialesUserName, _credencialesPassword);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage); // Sends Email
            smtpClient.Dispose();
            mailMessage.Dispose();
        }
    }
}