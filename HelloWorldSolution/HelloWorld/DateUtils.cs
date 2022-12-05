namespace HelloWorld
{
    internal class DateUtils
    {
        public DateTime TakeABreak(int minutes)
        {
            return DateTime.Now.AddMinutes(minutes);
        }

        
    }
}
