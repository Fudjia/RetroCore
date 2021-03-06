﻿using System;

namespace RetroCore.Helpers
{
    public class Constants
    {
        public static string AuthAddress = "172.65.206.193"; //  is there 2 differents auth serv ??
        public static int AuthPort = 5555; // there is also a 443 port
        public static string GameVersion = "1.34.0";
        public static string MapsPath;
        public static string LangsPath;
        public static string OthersPath => AppDomain.CurrentDomain.BaseDirectory + @"others\statistics.json";
    }
}