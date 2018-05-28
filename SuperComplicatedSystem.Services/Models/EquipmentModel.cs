using SuperComplicatedSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperComplicatedSystem.Services.Models
{
    public class EquipmentModel
    {
        public EquipmentModel(Equipment dbList)
        {
            this.Id = dbList.Id;
            this.Name = dbList.name;
            this.EquipmentType = new EquipmentTypeModel(dbList.equipmentType);
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public EquipmentTypeModel EquipmentType { get; set; }
    }
}
