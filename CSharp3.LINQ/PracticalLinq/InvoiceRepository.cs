﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3.LINQ
{
    public class InvoiceRepository
    {
        public List<Invoice> Retrieve()
        {
            List<Invoice> invoiceList = new List<Invoice>() 
            {
                new Invoice
                {
                    InvoiceId = 1, 
                    CustomerId = 1, 
                    InvoiceDate = new DateTime(2013, 6, 20), 
                    DueDate = new DateTime(2013, 8, 29), 
                    IsPaid = null,
                    Amount = 199.99M,
                    NumberOfUnits = 20,
                    DiscountPercent = 0M
                },
                new Invoice
                {
                    InvoiceId = 2, 
                    CustomerId = 1, 
                    InvoiceDate = new DateTime(2013, 7, 20), 
                    DueDate = new DateTime(2013, 8, 20), 
                    IsPaid = null,
                    Amount = 98.50M,
                    NumberOfUnits = 10,
                    DiscountPercent = 10M
                },
                new Invoice
                {
                    InvoiceId = 3, 
                    CustomerId = 2, 
                    InvoiceDate = new DateTime(2013, 7, 25), 
                    DueDate = new DateTime(2013, 8, 25), 
                    IsPaid = null,
                    Amount = 250M,
                    NumberOfUnits = 25,
                    DiscountPercent = 10M
                },
                new Invoice
                {
                    InvoiceId = 4, 
                    CustomerId = 3, 
                    InvoiceDate = new DateTime(2013, 7, 1), 
                    DueDate = new DateTime(2013, 9, 1), 
                    IsPaid = true,
                    Amount = 20M,
                    NumberOfUnits = 2,
                    DiscountPercent = 15M
                },
                new Invoice
                {
                    InvoiceId = 5, 
                    CustomerId = 1, 
                    InvoiceDate = new DateTime(2013, 8, 2), 
                    DueDate = new DateTime(2013, 9, 29), 
                    IsPaid = true,
                    Amount = 225M,
                    NumberOfUnits = 22,
                    DiscountPercent = 10M
                },
                new Invoice
                {
                    InvoiceId = 6, 
                    CustomerId = 2, 
                    InvoiceDate = new DateTime(2013, 8, 20), 
                    DueDate = new DateTime(2013, 8, 20), 
                    IsPaid = false,
                    Amount = 75M,
                    NumberOfUnits = 8,
                    DiscountPercent = 0M
                },
                new Invoice
                {
                    InvoiceId = 7, 
                    CustomerId = 3, 
                    InvoiceDate = new DateTime(2013, 8, 25), 
                    DueDate = new DateTime(2013, 9, 25), 
                    IsPaid = null,
                    Amount = 500M,
                    NumberOfUnits = 42,
                    DiscountPercent = 10M
                },
                new Invoice
                {
                    InvoiceId = 8, 
                    CustomerId = 4, 
                    InvoiceDate = new DateTime(2013, 8, 25), 
                    DueDate = new DateTime(2013, 9, 1), 
                    IsPaid = true,
                    Amount = 75M,
                    NumberOfUnits = 7,
                    DiscountPercent = 0M
                }
            };

            return invoiceList;
        }

        public List<Invoice> Retrieve(int customerId)
        {
            var invoiceList = this.Retrieve();
            List<Invoice> filteredList = invoiceList.Where(i => i.CustomerId == customerId)
                                                    .ToList();

            return filteredList;
        }

        public decimal CalculateTotalAmountInvoiced(List<Invoice> invoiceList)
        {
            return invoiceList.Sum(i => i.TotalAmount);
        }

        public int CalculateTotalUnitsSold(List<Invoice> invoiceList)
        {
            return invoiceList.Sum(i => i.NumberOfUnits);
        }

        public dynamic GetInvoiceTotalByIsPaid(List<Invoice> invoiceList)
        {
            var query = invoiceList.GroupBy(i => i.IsPaid ?? false,
                                            i => i.TotalAmount,
                                            (groupKey, invTotal) => new
                                            {
                                                Key = groupKey,
                                                InvoicedAmount = invTotal.Sum()
                                            });
            return query.ToList();
        }

        public dynamic GetInvoiceTotalIsPaidAndMonth(List<Invoice> invoiceList)
        {
            var query = invoiceList.GroupBy(i => new { IsPaid = i.IsPaid ?? false, InvoiceMonth = i.InvoiceDate.ToString("MMM") },
                                i => i.TotalAmount,
                                (groupKey, invTotal) => new
                                {
                                    Key = groupKey,
                                    InvoicedAmount = invTotal.Sum()
                                });
            return query.ToList();
        }

        public decimal CalculateMean(List<Invoice> invoiceList)
        {
            return invoiceList.Average(i => i.DiscountPercent);
        }

        public decimal CalculateMedian(List<Invoice> invoiceList)
        {
            var sortedList = invoiceList.OrderBy(i => i.DiscountPercent);
            int count = invoiceList.Count();
            int position = count / 2;
            decimal median;
            if ((count % 2) == 0)
            {
                median = (sortedList.ElementAt(position).DiscountPercent +
                            sortedList.ElementAt(position - 1).DiscountPercent) / 2;
            }
            else
            {
                median = sortedList.ElementAt(position).DiscountPercent;
            }

            return median;
        }

        public decimal CalculateMode(List<Invoice> invoiceList)
        {
            var mode = invoiceList.GroupBy(i => i.DiscountPercent)
                                  .OrderByDescending(group => group.Count())
                                  .Select(group => group.Key)
                                  .FirstOrDefault();
            return mode;
        }
    }
}