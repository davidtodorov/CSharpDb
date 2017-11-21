using System;
using P01_BillsPaymentSystem.Data;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BillsPaymentSystemContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
