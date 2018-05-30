using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedOrganization.Module
{
    public class MedOrganization
    {
        public MedOrganization():this("","","")
        {

        }
        public MedOrganization(string nameOrgan, string adres, string telNumber)
        {
            NameOrgan = nameOrgan;
            Adress = adres;
            TelNumber = telNumber;
            PacientList = new List<Pacient>();
        }

        //2.	Мед Организация(Наименование, Адрес, Телефон)
        public int Id { get; set; }
        public string NameOrgan { get; set; }
        public string Adress { get; set; }
        public string TelNumber { get; set; }
        public List<Pacient> PacientList { get; set; }


        public void MedOrganizationInfo()
        {
            Console.WriteLine($"Название орагнизации: {NameOrgan} \n"+
                              $"Адрес организации: {Adress} \n"+
                              $"Телефонный номер организации: {TelNumber} \n"+
                              $"Айди организации: {Id} \n");
            foreach (var pacient in PacientList)
            {
                Console.WriteLine($"Пациент: {pacient.Familiya} {pacient.Imya} {pacient.IIN}");
            }
        }

        //PacientServise p = new PacientServise();
        
    }
}
