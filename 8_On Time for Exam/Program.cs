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
            string outPutMinutesdifferenceCount = string.Empty;
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
            else if (difminutesCalc <= 30 && difminutesCalc > 0)
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

                if (difminutesCalc <= 59)
                {                  
                    outPutStatment = $"Late\n{difminutesCalc:D2} minutes after the start";
                }
                else if (difminutesCalc >= 60)
                {
                    difhoursCalc = arrivingTimeH - examtimeH;
                    difminutesCalc -= (arrivingTimeH - examtimeH) * 60;
                    outPutStatment = $"Late\n{difhoursCalc}:{difminutesCalc:D2} minutes after the start";
                }
            }
            Console.WriteLine(outPutStatment);
        }
    }
}
//String.Format("{4:D2}", DateTime.Now.Minute);
//string examtime = examtimeH.ToString() + ":" + examtimeM.ToString();
//DateTime examtimeformat = new DateTime();
//examtimeformat = DateTime.ParseExact(examtime, "H:mm", null);
//string arrivingTime = arrivingTimeH.ToString() + ":" + arrivingTimeM.ToString();
//DateTime arrivetimeformat = new DateTime();
//arrivetimeformat = DateTime.ParseExact(arrivingTime, "HH:mm", null);
//TimeSpan diff = arrivetimeformat - examtimeformat;
//Console.WriteLine(diff.ToString());

//Input
//From the console are read 4 integer values (one per line) entered by the user:
//  V •	The first line contains an exam time – hour - an integer from 0 to 23.
//  V •	The second line contains an exam time – minute - an integer from 0 to 59.
//  V •	The third line contains the time of arrival – hour - an integer from 0 to 23.
//  V •	The fourth line contains the time of arrival – minute - an integer from 0 to 59.

//A student is required to take an exam at a specific time (e.g., at 9:30 a.m.).
//However, he arrives at the exam room at a given time of arrival (e.g., 9:40 a.m.).
//The student is considered to have arrived on time if he arrives at the exam time or up to half an hour before it.
//If they arrive earlier than 30 minutes, he is considered early.
//If he arrives after the exam time, he is considered late.
//Write a program that reads the exam time and the time of arrival,
//and then prints whether the student is on time, early, or late, along with the number of hours or minutes he is early or late.

//Output
//On the first line, print on of the following messages:
//•	"Late" - if the student arrives later than the time of the exam.
//•	"On time" - if the student arrives exactly at the time of the exam or up to 30 minutes in advance.
//•	"Early" - if the student arrives more than 30 minutes before the exam time.
//On the second line, print a message, considering the following conditions:
//•	If the student arrives with at least a minute difference from the exam time, print on the next line:
//o For being late under an hour: "{mm} minutes after the start"
//o For a delay of 1 hour or more: "{hh:mm} hours after the start".
//	Always print the minutes with 2 digits, such as "1:03".
