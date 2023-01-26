using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("You cannot leave the product name blank");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Please enter at least two characters");
            RuleFor(x => x.ProductName).MaximumLength(20).WithMessage("Please do not enter more than 20 characters");
            RuleFor(x => x.Barcode).MaximumLength(13).WithMessage("Please do not enter more than 13 characters");
            RuleFor(x => x.UnitPrice).NotEqual(0).WithMessage("Please do not enter zero");
            
        }
    }
}
