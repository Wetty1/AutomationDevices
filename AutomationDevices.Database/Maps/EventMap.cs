using AutomationDevice.Core.Domain.Entities;
using AutomationDevices.Database.Maps.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationEvent.Database.Maps
{
    class EventMap: BaseEntityMap<Event>
    {
        public EventMap(): base("Event")
        {

        }

        public override void Configure(EntityTypeBuilder<Event> builder) {
            base.Configure(builder);

            builder.Property(x => x.DeviceId).HasColumnName("DeviceId").IsRequired();
            builder.Property(x => x.EventType).HasColumnName("EventType").IsRequired();

            builder.HasOne(x => x.Device).WithMany(x => x.Events).HasForeignKey(x => x.DeviceId);
        }
    }
}
