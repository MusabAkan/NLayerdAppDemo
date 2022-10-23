using FluentValidation;
using Northwind.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    class ProductValidator : AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(i => i.ProductName).NotEmpty();
            RuleFor(i => i.CategoryId).NotEmpty();
            RuleFor(i => i.UnitPrice).NotEmpty();
            RuleFor(i => i.QuantityPerUnit).NotEmpty();
            RuleFor(i => i.UnitsInStock).NotEmpty();
            RuleFor(i => i.UnitPrice).GreaterThan(0);// boş olamaz ve aynı zamanda 0'dan büyük olmalı
            RuleFor(i => i.UnitsInStock).GreaterThanOrEqualTo((short)0);//başlangınç

            RuleFor(i => i.UnitPrice).GreaterThan(10).When(p => p.CategoryId == 2);//başlangınç

            RuleFor(i => i.ProductName).Must(StartWithA).WithMessage("Ürün Adı A ile  başlamalı");


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
