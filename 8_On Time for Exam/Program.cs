namespace _8_On_Time_for_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examtimeH = int.Parse(Console.ReadLine());
            int examtimeM = int.Parse(Console.ReadLine());
            int arrivingTimeH = int.Parse(Console.ReadLine());
            int arrivingTimeM = int.Parse(Console.ReadLine());

            string outPutStatment = string.Empty;       
            int difminutesCalc = 0;
            int difhoursCalc = 0;
            
            int housInMinutesEx = examtimeH * 60;
            int hoursPlusMinutesExTogeInMinutes = housInMinutesEx + examtimeM;
            int housInMinutesArr = arrivingTimeH * 60;
            int hoursPlusMinutesArrTogeInMinutes = housInMinutesArr + arrivingTimeM;
            difminutesCalc = hoursPlusMinutesExTogeInMinutes - hoursPlusMinutesArrTogeInMinutes;

            //OnTime
            if (difminutesCalc == 0)
            {
                outPutStatment = "On time";
            }
            else if (difminutesCalc <=30 && difminutesCalc > 0)
            {
                outPutStatment = $"On time\n{difminutesCalc} minutes before the start";
            }
            //Earlier
            else if (difminutesCalc > 30)
            {
                if (difminutesCalc <= 59)
                {
                    outPutStatment = $"Early\n{difminutesCalc:D2} minutes before the start";
                }
                else if(difminutesCalc >= 60)
                {
                    difminutesCalc -= (examtimeH - arrivingTimeH) * 60;
                    outPutStatment = $"Early\n{examtimeH - arrivingTimeH}:{difminutesCalc:D2} hours before the start";
                }
            }

            //Late
            else if (difminutesCalc < 0)
            {
                difminutesCalc = difminutesCalc * -1;

                if (difminutesCalc < 60)
                {                  
                    outPutStatment = $"Late\n{difminutesCalc:D2} minutes after the start";
                }
                else if (difminutesCalc == 60)
                {
                    difhoursCalc = arrivingTimeH - examtimeH;
                    difminutesCalc -= (arrivingTimeH - examtimeH) * 60;
                    outPutStatment = $"Late\n{difhoursCalc}:{difminutesCalc:D2} hours after the start";
                }
                else if (difminutesCalc > 60)
                {
                    difhoursCalc = arrivingTimeH - examtimeH;
                    difminutesCalc -= (arrivingTimeH - examtimeH) * 60;
                    outPutStatment = $"Late\n{difhoursCalc}:{difminutesCalc:D2} hours after the start";
                }
            }
            Console.WriteLine(outPutStatment);
        }
    }
}

