using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Udemy_Ex4
{
    class Program
    {
        /*
        Your job is to write a program for a speed camera. 
        For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
        Write a program that asks the user to enter the speed limit. 
        Once set, the program asks for the speed of a car. 
        If the user enters a value less than the speed limit, program should display Ok on the console. 
        
        If the value is above the speed limit, the program should calculate the number of demerit points. 
        For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
        If the number of demerit points is above 12, the program should display License Suspended.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the car speed");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var demeritPoints = calcDemetricPoints(speedLimit, carSpeed);
                Console.WriteLine(demeritPoints < 12 ? demeritPoints.ToString() : "License Suspended");
            }
        }

        public static int calcDemetricPoints(int speedLimit, int carSpeed)
        {
            int demetricPoints = 0;
            demetricPoints = (carSpeed - speedLimit) / 5;
            return demetricPoints;
        }

    }
}
