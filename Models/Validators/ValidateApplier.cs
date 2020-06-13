using System.Collections.Generic;
using System.Linq;
using ASP;

namespace JobApplying.Models.Validators
{
    public  class ValidateApplier
    {
        private IList<IValidate<Applier>> _validators;
        private Applier _applier;

        public ValidateApplier(IList<IValidate<Applier>> validates,Applier applier)
        {
            _validators = validates;
            _applier = applier;

        }

        public void AddValidator(IValidate<Applier> validate)
        {
            _validators.Add(validate);
        }

        public bool Validate() => _validators.All(validate => validate.Valid(_applier));

    }
}