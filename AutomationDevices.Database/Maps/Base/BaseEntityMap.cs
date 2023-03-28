using AutomationDevices.Core.Domain.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDevices.Database.Maps.Base
{
    public class BaseEntityMap<T>: IEntityTypeConfiguration<T> where T:BaseEntity
    {
        private readonly string _tableName;
        public BaseEntityMap(string tableName = "")
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
            {
                builder.ToTable(_tableName);
            }

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedAt).HasColumnName("CreatedAt").IsRequired();
        }
    }
}
