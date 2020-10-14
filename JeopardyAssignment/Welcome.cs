﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JeopardyAssignment
{
    public class WelcomeMessage
    {
        public static void Welcome()
        {
            Console.WriteLine(@" .----------------.  .----------------.  .----------------.  .----------------. ");
            Console.WriteLine(@"| .--------------. || .--------------. || .--------------. || .--------------. |");
            Console.WriteLine(@"| |     _____    | || |  _________   | || |     ____     | || |   ______     | |");
            Console.WriteLine(@"| |    |_   _|   | || | |_   ___  |  | || |   .'    `.   | || |  |_   __ \   | |");
            Console.WriteLine(@"| |      | |     | || |   | |_  \_|  | || |  /  .--.  \  | || |    | |__) |  | |");
            Console.WriteLine(@"| |   _  | |     | || |   |  _|  _   | || |  | |    | |  | || |    |  ___/   | |");
            Console.WriteLine(@"| |  | |_' |     | || |  _| |___/ |  | || |  \  `--'  /  | || |   _| |_      | |");
            Console.WriteLine(@"| |  `.___.'     | || | |_________|  | || |   `.____.'   | || |  |_____|     | |");
            Console.WriteLine(@"| |              | || |              | || |              | || |              | |");
            Console.WriteLine(@"| '--------------' || '--------------' || '--------------' || '--------------' |");
            Console.WriteLine(@" '----------------'  '----------------'  '----------------'  '----------------' ");
            Console.WriteLine(@" .----------------.  .----------------.  .----------------.  .----------------. ");
            Console.WriteLine(@"| .--------------. || .--------------. || .--------------. || .--------------. |");
            Console.WriteLine(@"| |      __      | || |  _______     | || |  ________    | || |  ____  ____  | |");
            Console.WriteLine(@"| |     /  \     | || | |_   __ \    | || | |_   ___ `.  | || | |_  _||_  _| | |");
            Console.WriteLine(@"| |    / /\ \    | || |   | |__) |   | || |   | |   `. \ | || |   \ \  / /   | |");
            Console.WriteLine(@"| |   / ____ \   | || |   |  __ /    | || |   | |    | | | || |    \ \/ /    | |");
            Console.WriteLine(@"| | _/ /    \ \_ | || |  _| |  \ \_  | || |  _| |___.' / | || |    _|  |_    | |");
            Console.WriteLine(@"| ||____|  |____|| || | |____| |___| | || | |________.'  | || |   |______|   | |");
            Console.WriteLine(@"| |              | || |              | || |              | || |              | |");
            Console.WriteLine(@"| '--------------' || '--------------' || '--------------' || '--------------' |");
            Console.WriteLine(@" '----------------'  '----------------'  '----------------'  '----------------' ");


            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
