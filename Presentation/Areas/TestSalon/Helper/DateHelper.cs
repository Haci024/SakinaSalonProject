using System.Globalization;

namespace Presentation.Areas.TestSalon.Helper
{
	public static class DateHelper
	{
		public static string ToAzerbaijanFormat(this DateTime date)
		{
			CultureInfo azCulture = new CultureInfo("az-Latn-AZ");
			return date.ToString("d MMMM", azCulture);
		}
	}
}
