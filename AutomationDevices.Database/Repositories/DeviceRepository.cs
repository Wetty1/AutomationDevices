using AutomationDevice.Core.Domain.Entities;
using AutomationDevices.Database.Repositories.Base;
using AutomationDevices.Database.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDevices.Database.Repositories
{
    public class DeviceRepository: BaseRepository<Device>, IDeviceRepository
    {
       
    }
}
