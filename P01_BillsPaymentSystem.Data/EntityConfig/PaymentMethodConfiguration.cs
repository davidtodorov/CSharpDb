using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BillsPaymentSystem.Data.Models;

namespace P01_BillsPaymentSystem.Data.EntityConfig
{
    class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder
                .HasIndex(pm => new
                {
                    pm.UserId,
                    pm.BankAccountId,
                    pm.CreditCardId
                }).IsUnique();

            builder
                .HasOne(pm => pm.User)
                .WithMany(pm => pm.PaymentMethods)
                .HasForeignKey(pm => pm.UserId);

            builder
                .HasOne(pm => pm.BankAccount)
                .WithOne(pm => pm.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);

            builder
                .HasOne(pm => pm.CreditCard)
                .WithOne(pm => pm.PaymentMethod)
                .HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);
        }
    }
}
