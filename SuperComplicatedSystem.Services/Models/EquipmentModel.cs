using SuperComplicatedSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperComplicatedSystem.Services.Models
{
    public class PCModel
    {
        public PCModel(PC dbList)
        {
            this.Id = dbList.Id;
            this.Name = dbList.name;
           // this.EquipmentType = new ComponentModel(dbList.components);
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        //public List<ComponentModel> EquipmentType { get; set; }
    }
}
