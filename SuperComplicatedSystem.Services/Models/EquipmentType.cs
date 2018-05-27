using SuperComplicatedSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperComplicatedSystem.Services.Models
{
    public class EquipmentTypeModel
    {
        public EquipmentTypeModel(equipmentType eqType)
        {
            this.Id = eqType.id;
            this.Name = eqType.name;

        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
