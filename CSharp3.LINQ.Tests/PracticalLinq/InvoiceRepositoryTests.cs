using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharp3.LINQ.Tests
{
    [TestFixture]
    class InvoiceRepositoryTests
    {
        [Test]
        public void ShouldCalculateTotalAmountInvoiced()
        {
            var sut = new InvoiceRepository();
            var invoices = sut.Retrieve();
            var total = sut.CalculateTotalAmountInvoiced(invoices);
            Assert.That(total, Is.EqualTo(1333.14M));
        }

        [Test]
        public void ShouldCalculateTotalUnitsSold()
        {
            var sut = new InvoiceRepository();
            var invoices = sut.Retrieve();
            var units = sut.CalculateTotalUnitsSold(invoices);
            Assert.That(units, Is.EqualTo(136));
        }

        [Test]
        public void ShouldCalculteTotalInvoicesPaid()
        {
            var sut = new InvoiceRepository();
            var invoices = sut.Retrieve();
            var paidInvoices = sut.GetInvoiceTotalByIsPaid(invoices);
            foreach (var item in paidInvoices)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void ShouldCalculteIsPaidAndMonth()
        {
            var sut = new InvoiceRepository();
            var invoices = sut.Retrieve();
            var paidInvoices = sut.GetInvoiceTotalIsPaidAndMonth(invoices);
            foreach (var item in paidInvoices)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void ShouldGetInvoiceTotalByCustomerType()
        {
            var customerRepository = new CustomerRepository();
            var customerTypeRepository = new CustomerTypeRepository();
            var customerTypeInvoices = customerRepository.GetInvoiceTotalByCustomerType(customerRepository.Retrieve(), customerTypeRepository.Retrieve() );
            foreach (var item in customerTypeInvoices)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void ShouldCalculateMean()
        {
            var repo = new InvoiceRepository();
            var invoices = repo.Retrieve();
            var mean = repo.CalculateMean(invoices);

            Assert.That(mean, Is.EqualTo(6.875m));
        }

        [Test]
        public void ShouldCalculateMedian()
        {
            var repo = new InvoiceRepository();
            var invoices = repo.Retrieve();
            var median = repo.CalculateMedian(invoices);

            Assert.That(median, Is.EqualTo(10m));
        }

        [Test]
        public void ShouldCalculateMode()
        {
            var repo = new InvoiceRepository();
            var invoices = repo.Retrieve();
            var mode = repo.CalculateMode(invoices);

            Assert.That(mode, Is.EqualTo(10m));
        }
    }
}
