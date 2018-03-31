using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web.Services;

namespace WcfServiceLibraryVelib
{
    [ServiceContract]
    interface IVelib
    {
        [OperationContract]
        List<Ville> GetVille(int deltaSeconde);
        [OperationContract]
        List<string> GetNomStationParVille(string ville, int deltaSeconde);
        [OperationContract]
        Station GetInformationStation (string ville, string station, int deltaSeconde);
    }
}
