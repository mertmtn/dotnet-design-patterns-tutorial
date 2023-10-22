using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace AdapterPattern
{
    /// <summary>
    /// Adaptee - Third party library or external API
    /// </summary>
    public class CurrencyExternal
    {
        readonly Tarih_Date result;

        public CurrencyExternal()
        {
            var xmlSerialize = new XmlSerializer(typeof(Tarih_Date), new XmlRootAttribute("Tarih_Date"));

            var client = new WebClient();

            var data = Encoding.Default.GetString(client.DownloadData("https://www.tcmb.gov.tr/kurlar/today.xml"));

            var reader = new MemoryStream(Encoding.Default.GetBytes(data));

            result = (Tarih_Date)xmlSerialize.Deserialize(reader);
        } 

        public List<Currency> GetCurrencyList()
        {
            return result?.Currency;
        }
    }
}
