using System.Globalization;
using CultureExplorer.Properties;

namespace CultureExplorer
{
    public class CalendarNameWrapper
    {
        private readonly Calendar _internalCalendar;

        public CalendarNameWrapper(Calendar calendar)
        {
            _internalCalendar = calendar;
        }

        public Calendar Calendar
        {
            get { return _internalCalendar; }
        }

        public override string ToString()
        {
            string displayName;

            if (_internalCalendar is ChineseLunisolarCalendar)
                return Resources.ChineseLunisolarCalendar;

            if (_internalCalendar is EastAsianLunisolarCalendar)
                return Resources.EastAsianLunisolarCalendar;

            if (_internalCalendar is GregorianCalendar)
            {
                var gc = _internalCalendar as GregorianCalendar;
                var gregorianTypeName = string.Empty;
                switch (gc.CalendarType)
                {
                    case GregorianCalendarTypes.Arabic:
                        gregorianTypeName = Resources.GregorianTypeArabic;
                        break;

                    case GregorianCalendarTypes.Localized:
                        gregorianTypeName = Resources.GregorianTypeLocalized;
                        break;

                    case GregorianCalendarTypes.MiddleEastFrench:
                        gregorianTypeName = Resources.GregorianTypeMiddleEastFrench;
                        break;

                    case GregorianCalendarTypes.TransliteratedEnglish:
                        gregorianTypeName = Resources.GregorianTypeTransliteratedEnglish;
                        break;

                    case GregorianCalendarTypes.TransliteratedFrench:
                        gregorianTypeName = Resources.GregorianTypeTransliteratedFrench;
                        break;

                    case GregorianCalendarTypes.USEnglish:
                        gregorianTypeName = Resources.GregorianTypeUSEnglish;
                        break;
                }
                return string.Format(Resources.GregorianNameFormat, Resources.GregorianCalendar, gregorianTypeName);
            }

            if (_internalCalendar is HebrewCalendar)
                return Resources.HebrewCalendar;

            if (_internalCalendar is HijriCalendar)
                return Resources.HijriCalendar;

            if (_internalCalendar is JapaneseCalendar)
                return Resources.JapaneseCalendar;

            if (_internalCalendar is JapaneseLunisolarCalendar)
                return Resources.JapaneseLunisolarCalendar;

            if (_internalCalendar is JulianCalendar)
                return Resources.JulianCalendar;

            if (_internalCalendar is KoreanCalendar)
                return Resources.KoreanCalendar;

            if (_internalCalendar is KoreanLunisolarCalendar)
                return Resources.KoreanLunisolarCalendar;

            if (_internalCalendar is PersianCalendar)
                return Resources.PersianCalendar;

            if (_internalCalendar is TaiwanCalendar)
                return Resources.TaiwanCalendar;

            if (_internalCalendar is TaiwanLunisolarCalendar)
                return Resources.TaiwanLunisolarCalendar;

            if (_internalCalendar is ThaiBuddhistCalendar)
                return Resources.ThaiBuddhistCalendar;

            if (_internalCalendar is UmAlQuraCalendar)
                return Resources.UmAlQuraCalendar;

            displayName = Calendar.ToString();

            return displayName;
        }
    }
}