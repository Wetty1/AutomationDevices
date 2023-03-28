using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomationDevice.Core.Domain.Entities.Enuns;
using AutomationDevices.Core.Domain.Base;

namespace AutomationDevice.Core.Domain.Entities
{
    public class Event: BaseEntity
    {
        public int DeviceId { get; set; }
        public EventType EventType { get; set; }
        public Device Device { get; }

        public Event(): base()
        {

        }
    }
}
