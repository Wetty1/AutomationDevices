using AutomationDevice.Core.Domain.Entities;
using AutomationDevices.Database.Maps.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDevices.Database.Maps
{
    class DevicesMap: BaseEntityMap<Device>
    {
        public DevicesMap(): base("Devices")
        {

        }

        public override void Configure(EntityTypeBuilder<Device> builder) {
            base.Configure(builder);

            builder.Property(x => x.Name).HasColumnName("Name").IsRequired();
            builder.Property(x => x.Address).HasColumnName("Address").IsRequired();
        }
    }
}
