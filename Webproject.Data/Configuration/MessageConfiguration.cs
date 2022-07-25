﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.EntityModel;

namespace Webproject.Data.Configuration
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages");

            builder.HasKey(m => m.MessageId);

            builder.HasOne(m => m.Sender).WithMany(m => m.SendMessage).HasForeignKey(m => m.SenderId);
            builder.HasOne(m => m.Receiver).WithMany(m => m.ReceiveMessage).HasForeignKey(m => m.ReceiverId);

            builder.Property(m => m.Content).IsRequired();
            builder.Property(m => m.Created).IsRequired();
        }
    }
}
