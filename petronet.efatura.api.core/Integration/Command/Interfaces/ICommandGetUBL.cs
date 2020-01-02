using System;
using System.Threading.Tasks;
using AutoMapper;
using petronet.efatura.api.core.Model.UBL;
using petronet.efatura.api.core.ViewModel;

namespace petronet.efatura.api.core.Integration.Command.Interfaces {

    interface ICommandGetUBL : IDisposable { 
        ServiceInfo ServiceInfo { get; set; }
        Task<ServiceResponse> Result { get; set; }

        Task Execute();
    }
}
