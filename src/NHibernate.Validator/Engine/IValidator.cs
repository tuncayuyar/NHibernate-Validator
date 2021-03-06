namespace NHibernate.Validator.Engine
{
	/// <summary>
	/// A validator for a particular attribute
	/// </summary>
	public interface IValidator
	{
		/// <summary>
		/// does the object/element pass the constraints
		/// </summary>
		/// <param name="value">Object to be validated</param>
		/// <param name="constraintValidatorContext">Context for the validator constraint</param>
		/// <returns>if the instance is valid</returns>
		bool IsValid(object value, IConstraintValidatorContext constraintValidatorContext);
	}
}