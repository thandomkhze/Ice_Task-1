namespace Casting
{
    class Ice_Task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of scripts.");
            int sctripts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of questions.");
            int questions = Convert.ToInt32(Console.ReadLine());

            int questionSubtotal = 0;
            for (int k = 1; k <= questions; k++)
            {
                Console.WriteLine("Enter the susbtotal for  question " + k);
                questionSubtotal += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the number of lecturers.");
            int lecturers = Convert.ToInt32(Console.ReadLine());

            int sec = (sctripts / lecturers) * (questionSubtotal * 2);
            int min = 0;
            int hour = 0;

            if ((sec % 60) > 30)
                min++;

            if (sec > 60)
                min += sec / 60;

            if (min > 60)
                hour += sec / 60;

            Console.WriteLine("Each lecturer will mark " + (sctripts / lecturers) + " scripts");

            if (hour > 1)
                Console.WriteLine("it will take each lecturer " + hour + " hour/s and " + min + " minutes");
            else
            {
                Console.WriteLine("it will take each lecturer " + min + " minutes");
            }

            if ((sctripts % lecturers) != 0)
                Console.WriteLine("The last lecturer will mark " + ((sctripts % lecturers) + (sctripts / lecturers)) + " scripts");
        }
    }
}
