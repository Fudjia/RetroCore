﻿using RetroCore.Others;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetroCore.Manager.MapManager.WorldPathFinder.Helper
{
    public class Teleporters
    {
        // public PathFinder PathFinderManager;
        private static readonly int[] TeleportersCellIds = new int[] {
        44,73,102,131,160,189,218,247,276,305,334,363,392,421, //Left
        57,86,115,144,173,202,231,260,289,318,347,376,405,434, //Right
        15,16,17,18,19,20,21,22,23,24,25,26,27,28,             //Top
        450,451,452,453,454,455,456,457,458,459,460,461,462,463//Bottom
        };

        public static List<Cell> TryGetPath()
        {
            return null;
        }

        public static DirectionType GetTeleporterSide(Cell teleporterCell)
        {
            int[] Left = { 44, 73, 102, 131, 160, 189, 218, 247, 276, 305, 334, 363, 392, 421 };
            int[] Right = { 57, 86, 115, 144, 173, 202, 231, 260, 289, 318, 347, 376, 405, 434 };
            int[] Top = { 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            int[] Bottom = { 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463 };
            if (Left.Contains(teleporterCell.Id))
                return DirectionType.LEFT;
            if (Right.Contains(teleporterCell.Id))
                return DirectionType.RIGHT;
            if (Top.Contains(teleporterCell.Id))
                return DirectionType.TOP;
            if (Bottom.Contains(teleporterCell.Id))
                return DirectionType.BOTTOM;
            return DirectionType.NONE;
        }

        public static List<Cell> GetMapTeleporters(Map map) => map.Cells.Where(x => x.IsTeleporter() && TeleportersCellIds.Contains(x.Id)).ToList();

        public static List<Cell> GetAccessiblesTeleporters(Client client, Map map)
        {
            List<Cell> TeleportersCell = GetMapTeleporters(map);
            List<Cell> Accessible = new List<Cell>();
            foreach (var teleporterCell in TeleportersCell)
            {
                bool val = client.PathFinderManager.CanGetPath(map, teleporterCell.Id);
                if (val)
                    Accessible.Add(teleporterCell);
            }

            return Accessible;
        }
    }

    public class PathInfos
    {
        private readonly Map _map;

        public PathInfos()
        {
        }
    }
}