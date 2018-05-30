using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Module
{
    public class ZapropsyNaZakreplenie
    {
        public DateTime DataSozdaniyaZaprosa { get; set; }
        public DateTime DataObrabotkiZaprosa { get; set; }
        public string Status { get; set; }
        public Pacient Pacien { get; set; }
        public MedOrganization MedOrg { get; set; }

    }
}
