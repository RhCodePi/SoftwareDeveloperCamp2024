using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync
                (
                    new TCKimlikNoDogrulaRequest
                    (
                      new TCKimlikNoDogrulaRequestBody(
                          person.NationalIdentity,
                          person.FirstName.ToUpper(),
                          person.LastName.ToUpper(),
                          person.DateOfBirthYear
                          )
                     )
                ).Result.Body.TCKimlikNoDogrulaResult;
        }

        public List<Person> GetPeople()
        {
            return null;
        }
    }
}
