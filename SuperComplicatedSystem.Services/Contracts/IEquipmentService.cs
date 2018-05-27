using System;
using System.Collections.Generic;
using SuperComplicatedSystem.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperComplicatedSystem.Services.Contracts
{
    public interface IEquipmentService
    {
        IEnumerable<Equipment> GetAll();
    }
}
