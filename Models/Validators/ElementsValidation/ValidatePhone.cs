namespace JobApplying.Models.Validators
{
    public class ValidatePhone:IValidate<Applier>
    {
        public bool Valid(Applier element) => element.Phone.Length > 10;
    }
}