using AutomationDevices.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutomationDevice.Core.Domain.Entities
{
    public class Device : BaseEntity
    {
        public string Name { get; set; }
        public int Address { get; set; }

        public List<Event> Events { get; }

        public Device(): base()
        {

        }
    }
}
