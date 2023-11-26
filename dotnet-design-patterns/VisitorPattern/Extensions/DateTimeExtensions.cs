namespace VisitorPattern.Extensions
{
    public static class DateTimeExtensions
    { 
        public static int GetQuarter(this DateTime dateTime)=>(dateTime.Month - 1) / 3 + 1;        
    }
}
