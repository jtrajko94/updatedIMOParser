using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToAccess
{
    class fhir2sql
    {
        public static sqlPatient prepareImportPatient(Patient patient, string consentDate,string population)
        {
            var sqlP = new sqlPatient();
            sqlP.FIRST_NAME = patient.Name.ElementAt(0).Given.First();
            sqlP.LAST_NAME = patient.Name.ElementAt(0).Given.Last();
            sqlP.GENDER = patient.Gender.Value.ToString();
            sqlP.ADDRESS = patient.Address.ElementAt(0).Text;
            sqlP.STATE_OR_PROVINCE_CODE = patient.Address.ElementAt(0).State;
            sqlP.POSTAL_CODE = patient.Address.ElementAt(0).PostalCode;
            sqlP.CITY = patient.Address.ElementAt(0).City;
            sqlP.CONSENT_DATE = consentDate;
            sqlP.POPULATION = population;
            return sqlP;
        }
        /*
        public string[] prepareCreatePopulation(string population, string IRB_approve, string IRB_expire, string min_trigger, string max_trigger,string no_connect_trigger)
        {
            return new string[6] { population, IRB_approve, IRB_expire, min_trigger, max_trigger, no_connect_trigger };
        }
        public string[] prepareAssignPatientPopulation(string patientID, string SiteID,string populationID,string consentdate)
        {
            return new string[4] { patientID, SiteID, populationID, consentdate};
        }

        public string[] prepareImportPrescription(MedicationOrder mo, string population, )
        {
            ResourceReference medRef = (ResourceReference) mo.Medication;
            string reference = medRef.Reference;
        }
    }
    */
    }

}
