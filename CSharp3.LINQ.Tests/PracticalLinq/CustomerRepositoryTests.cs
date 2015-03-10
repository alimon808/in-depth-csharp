using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp3.LINQ.Tests
{
    [TestFixture]
    public class CustomerRepositoryTests
    {
        [Test]
        public void ShouldFindBilboBagginsInList()
        {
            var sut = new CustomerRepository();

            var customer = sut.Find(sut.Retrieve(), 2);

            Assert.That(customer, Is.Not.Null);
            Assert.That(customer.CustomerId, Is.EqualTo(2));
            Assert.That(customer.FirstName, Is.EqualTo("Bilbo"));
            Assert.That(customer.LastName, Is.EqualTo("Baggins"));
        }

        [Test]
        public void ShouldFindNoCustomer()
        {
            var sut = new CustomerRepository();

            var customer = sut.Find(sut.Retrieve(), 42);

            Assert.That(customer, Is.Null);
        }

        [Test]
        public void ShouldFindBilboBagginsAsTheFirstCustomerInSortedListByName()
        {
            var sut = new CustomerRepository();
            var customerList = sut.SortByName(sut.Retrieve());

            Assert.That(customerList, Is.Not.Null);
            Assert.That(customerList.First().CustomerId, Is.EqualTo(2));
            Assert.That(customerList.First().FirstName, Is.EqualTo("Bilbo"));
            Assert.That(customerList.First().LastName, Is.EqualTo("Baggins"));
        }

        [Test]
        public void ShouldFindBilboBagginsAsTheLastCustomerInReverseSortedListByName()
        {
            var sut = new CustomerRepository();
            var customerList = sut.SortByNameInReverse(sut.Retrieve());

            Assert.That(customerList, Is.Not.Null);
            Assert.That(customerList.Last().CustomerId, Is.EqualTo(2));
            Assert.That(customerList.Last().FirstName, Is.EqualTo("Bilbo"));
            Assert.That(customerList.Last().LastName, Is.EqualTo("Baggins"));
        }
        [Test]
        public void ShouldReturnFirstElementCustomerTypeIsNullInSortedByType()
        {
            var sut = new CustomerRepository();
            var customerList = sut.SortByType(sut.Retrieve());

            Assert.That(customerList, Is.Not.Null);
            Assert.That(customerList.Last().CustomerTypeId, Is.Null);
        }

        [Test]
        public void ShouldReturnGetCustomerNames()
        {
            var sut = new CustomerRepository();
            var query = sut.GetNames(sut.Retrieve());

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Assert.That(query, Is.Not.Null);
        }

        [Test]
        public void ShouldDisplayCustomerNameAndCustomerTypeName()
        {
            var sut = new CustomerRepository();
            var customerTypeRepository = new CustomerTypeRepository();

            var query = sut.GetNamesAndType(sut.Retrieve(), customerTypeRepository.Retrieve());

        }

        [Test]
        public void ShouldGetOverdueCustomers()
        {
            var sut = new CustomerRepository();
            var query = sut.GetOverdueCustomers(sut.Retrieve());

            foreach (var item in query)
            {
                Console.WriteLine(item.LastName + ", " + item.FirstName);
            }

            Assert.That(query, Is.Not.Null);
        }
    }
}
