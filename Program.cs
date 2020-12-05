﻿using RetroCore.Helpers;
using RetroCore.Helpers.MapsReader;
using RetroCore.Network.Dispatcher;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace RetroCore
{
    internal class Program
    {
        /*
        https://google.github.io/styleguide/csharp-style.html
         */

        private static void Main(string[] args)
        {
            if (!Debugger.IsAttached)
            {
                //
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            StringHelper.WriteLine("Initializing..", ConsoleColor.Blue);
            DataManager.Initialize();
            PacketsReceiver.Initialize();
            StringHelper.WriteLine("Initialization done, starting..", ConsoleColor.Magenta);
            Client bot1 = null;
            var task = Task.Factory.StartNew(() => { bot1 = new Client("msaliraso1", "sfn198622"); });
            //var task2 = Task.Factory.StartNew(async () => { Client bot1 = new Client("mrchriistoo77", "EliasetMathieu77"); });
            //mrchriistoo77: EliasetMathieu77
            while (true)
            {
                Thread.Sleep(300);
            }
        }
    }
}