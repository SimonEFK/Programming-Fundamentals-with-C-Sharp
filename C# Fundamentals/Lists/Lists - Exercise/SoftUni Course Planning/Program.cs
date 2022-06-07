using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] cmdArg = input.Split(":");
                if (cmdArg[0] == "Add")
                {
                    string lesson = cmdArg[1];
                    if (!(schedule.Contains(lesson)))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (cmdArg[0] == "Insert")
                {
                    string lesson = cmdArg[1];
                    int index = int.Parse(cmdArg[2]);
                    if (!(schedule.Contains(lesson)))
                    {
                        schedule.Insert(index, lesson);
                    }

                }
                else if (cmdArg[0] == "Remove")
                {
                    string lesson = cmdArg[1];
                    string excercise = lesson + "-Exercise";
                    if (schedule.Contains(lesson) && schedule.Contains(excercise))
                    {
                        schedule.Remove(lesson);
                        schedule.Remove(excercise);
                    }
                    else
                    {
                        schedule.Remove(lesson);
                    }

                }
                else if (cmdArg[0] == "Swap")
                {
                    string fLesson = cmdArg[1];
                    string sLesson = cmdArg[2];

                    int indexOfFLesson = schedule.IndexOf(fLesson);
                    int indexOfSLesson = schedule.IndexOf(sLesson);

                    string fLessonExcercise = fLesson + "-Exercise";
                    string sLessonExcercise = sLesson + "-Exercise";

                    if (schedule.Contains(fLesson) && schedule.Contains(sLesson))
                    {
                        if (schedule.Contains(fLessonExcercise) && (!(schedule.Contains(sLessonExcercise))))
                        {
                            int fLessonExcerciseIndex = schedule.IndexOf(fLessonExcercise);
                            schedule.RemoveAt(fLessonExcerciseIndex);
                            schedule[indexOfFLesson] = sLesson;
                            schedule.Insert(indexOfFLesson + 1, fLessonExcercise);
                        }
                        else if (schedule.Contains(sLessonExcercise) && (!(schedule.Contains(fLessonExcercise))))
                        {
                            int sLessonExcerciseIndex = schedule.IndexOf(sLessonExcercise);
                            schedule.RemoveAt(sLessonExcerciseIndex);
                            schedule[indexOfSLesson] = fLesson;
                            schedule[indexOfFLesson] = sLesson;
                            schedule.Insert(indexOfFLesson + 1, sLessonExcercise);
                        }
                        else if (schedule.Contains(fLessonExcercise) && schedule.Contains(sLessonExcercise))
                        {

                        }
                        else
                        {
                            schedule[indexOfFLesson] = sLesson;
                            schedule[indexOfSLesson] = fLesson;
                        }

                    }


                }
                else if (cmdArg[0] == "Exercise")
                {
                    string lesson = cmdArg[1];
                    string excercise = lesson + "-Exercise";
                    if (schedule.Contains(lesson))
                    {
                        if (!(schedule.Contains(excercise)))
                        {
                            int indexOfLesson = schedule.IndexOf(lesson);
                            schedule.Insert(indexOfLesson + 1, excercise);
                        }

                    }
                    else if (!(schedule.Contains(lesson)))
                    {
                        schedule.Add(lesson);
                        schedule.Add(excercise);
                    }
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
            //Console.WriteLine(string.Join(Environment.NewLine, schedule));
        }
    }
}
