
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace US_EXCHANGER.connection
{
    public class Connection
    {
        private string FILE_CONFIG = "connection.xml";
        private static readonly Lazy<Connection> mConnection = new Lazy<Connection>(() => new Connection());

        private Connection()
        {
            initialize();
        }

        public static Connection Instance
        {
            get
            {
                return mConnection.Value;
            }
        }

        private void initialize()
        {
            try
            {
                XDocument connectionXML = XDocument.Load(File.OpenRead(AppDomain.CurrentDomain.BaseDirectory + FILE_CONFIG));

                var xmlURLs = (from op in connectionXML.Descendants("UNOSOFT")
                               select new
                               {

                                   urlConsultaDocIden = op.Element("UrlConsultaDocIden").Value,
                                   tokenGetDocIdent = op.Element("TokenGetDocIdent").Value
                               }).Single();


                this.urlConsultaDocIden = xmlURLs.urlConsultaDocIden;

                this.tokenGetDocIdent = xmlURLs.tokenGetDocIdent;
                this.datosValidos = true;
            }
            catch (Exception ex)
            {
                this.datosValidos = false;
                //MainProcess.log.Error("Error en archivo de conexión", ex);
            }
        }

        public bool datosValidos { get; set; }
        public string urlConsultaDocIden { get; set; }
        public string tokenGetDocIdent { get; set; }

    }
}
