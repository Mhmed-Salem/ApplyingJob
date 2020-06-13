using System;

namespace JobApplying.Models.Validators
{
    public class ValidateDates:IValidate<Applier>
    {

        public bool Valid(Applier applier)
        {
            return ValidateBirthDate(applier.BirthDate)
                   && ValidateGraduationDate(applier.GraduatingYear);
        }

        private bool ValidateBirthDate(DateTime birthDate)
        {
            return birthDate.Year > 1930;
        }

        private bool ValidateGraduationDate(int graduationYear)
        {
            return graduationYear > 19;
        }
    }
}