﻿using System;
using System.Threading.Tasks;
using petronet.efatura.api.core.Model.UBL;
using petronet.efatura.api.core.ViewModel;

namespace petronet.efatura.api.core.Integration.Command.Interfaces {
    interface ICommandSendUBL : IDisposable { //where TService: ICommunicationObject
        InvoiceType Invoice { get; set; }
        ServiceInfo ServiceInfo { get; set; }
        Task<ServiceResponse> Result { get; set; }

        Task Execute();
    }
}
