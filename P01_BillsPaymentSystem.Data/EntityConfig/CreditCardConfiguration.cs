﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder
                .HasKey(c => c.CreditCardId);

            builder.Ignore(c => c.LimitLeft);

            builder.Ignore(c => c.PaymentMethodId);
            
        }
    }
}
