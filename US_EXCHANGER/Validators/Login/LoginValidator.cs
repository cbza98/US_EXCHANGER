using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using US_EXCHANGER.Models.Login;

namespace US_EXCHANGER.Validators.Login
{
    public class LoginValidator : AbstractValidator<OPE_USUARIOBean>
    {
        public LoginValidator()
        {
           //RuleFor(x => x.CODIGO_EMPRESA).NotEmpty().WithMessage("Por favor seleccione una empresa valida");
            RuleFor( x=> x.CODIGO).NotEmpty().WithMessage("Por favor ingrese un usuario valido");
            RuleFor(x => x.CONTRASENA).NotEmpty().WithMessage("Por favor ingrese una contraseña valida");

        }
    }
}
