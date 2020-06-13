namespace JobApplying.Models.Validators
{
    public class ValidateName:IValidate<Applier>
    {
        public bool Valid(Applier element) => element.Name.Length > 10
                                              && element.Name.Split().Length >= 2;
    }
}