﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryVelib
{
    [ServiceContract]
    interface IEvent
    {
        [OperationContract(IsOneWay = true)]
        void StationUpdate(Station station);
    }
}