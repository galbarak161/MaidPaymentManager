namespace MaidPaymentManager
{
    public interface INewWorkValidator
    {
        bool ValidateDate(string dateValue);
        bool ValidateNumberOfHours(string hoursValue);
        bool ValidateComments(string commentsValue);
    }

    public class NewWorkValidator : INewWorkValidator
    {
        public bool ValidateDate(string dateValue)
        {
            if (string.IsNullOrWhiteSpace(dateValue) || !DateTime.TryParse(dateValue, out DateTime date))
                return false;

            // Check if the date is within the current month
            return date.Year == DateTime.Now.Year && date.Month == DateTime.Now.Month;
        }

        public bool ValidateNumberOfHours(string hoursValue)
        {
            if (string.IsNullOrWhiteSpace(hoursValue) || !double.TryParse(hoursValue, out double hours))
                return false;

            return hours > 0 && hours <= 5;
        }

        public bool ValidateComments(string commentsValue)
        {
            return commentsValue.Length <= 50;
        }
    }
}
