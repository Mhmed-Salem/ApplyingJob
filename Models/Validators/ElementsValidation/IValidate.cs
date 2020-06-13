namespace JobApplying.Models.Validators
{
    public interface IValidate<T>
    {
        bool Valid(T element);
    }
}