using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "CompanyService" no arquivo de código e configuração ao mesmo tempo.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetConfidentialInformation()
        {
            return "This is public information and available over HTTP to all general public outside the Firewall!";
        }


        public string GetPublicInformation()
        {
            return "This is confidential information and only available over TCP behind the company Firewall!";
        }
    }
}
