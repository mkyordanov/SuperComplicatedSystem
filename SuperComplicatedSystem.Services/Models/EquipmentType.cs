using SuperComplicatedSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperComplicatedSystem.Services.Models
{
    public class ComponentModel
    {
        public ComponentModel(Components eqType)
        {
            this.Id = eqType.Id;
            this.Name = eqType.Model;

        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
