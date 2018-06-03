using SuperComplicatedSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperComplicatedSystem.Models;
using ToDoList.Data.UnitOfWork;
using SuperComplicatedSystem.Data.EFRepository;
using Bytes2you.Validation;
using SuperComplicatedSystem.Services.Models;
using System.IO;

namespace SuperComplicatedSystem.Services
{
    public class EquipmentService : IEquipmentService
    {

        private readonly IEFGenericRepository<PC> equipmentRepository;

        public EquipmentService(IEFGenericRepository<PC> equipmentRepository)
        {
            Guard.WhenArgument(equipmentRepository, "Equipment Repository").IsNull().Throw();

            this.equipmentRepository = equipmentRepository;
        }
        public IEnumerable<PC> GetAll()
        {
            return this.equipmentRepository.All.ToList<PC>();
        }
    }
}
