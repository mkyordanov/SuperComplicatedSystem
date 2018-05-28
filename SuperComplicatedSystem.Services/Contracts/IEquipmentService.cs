using System;
using System.Collections.Generic;
using SuperComplicatedSystem.Models;

namespace SuperComplicatedSystem.Services.Contracts
{
    public interface IEquipmentService
    {
        IEnumerable<Equipment> GetAll();
    }
}
