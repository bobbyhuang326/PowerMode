﻿namespace BigEgg.Tools.PowerMode.Services
{
    using System;
    using System.Drawing;

    using BigEgg.Tools.PowerMode.Utils;

    public class ComboService
    {
        private static readonly int HIT_THRESHOLD = 30;
        private static readonly int MAX_LEVEL = 15;
        private static readonly Color POWER_COLOR = Color.FromArgb(78, 255, 161);
        private static readonly int LEVEL_COLOR_SPIN_ANGLE = 30;
        private static readonly int DEFAULT_FONT_SIZE = 20;
        private static readonly int LEVEL_FONT_SIZE = 1;
        private static readonly float LEVEL_PEN_WIDTH = 0.5f;


        public static int GetPowerLevel(int comboHit)
        {
            return Math.Min(comboHit / HIT_THRESHOLD, MAX_LEVEL);
        }

        public static Color GetPowerLevelColor(int comboHit)
        {
            var level = GetPowerLevel(comboHit);
            return POWER_COLOR.SpinColor(LEVEL_COLOR_SPIN_ANGLE * level);
        }

        public static int GetPowerLevelPenWidth(int comboHit)
        {
            return (int)(GetPowerLevel(comboHit) * LEVEL_PEN_WIDTH);
        }

        public static int GetPowerLevelFontSize(int comboHit)
        {
            var level = GetPowerLevel(comboHit);
            return DEFAULT_FONT_SIZE + level * LEVEL_FONT_SIZE;
        }

        public static string GetExclamation()
        {
            return "Stupendous!";
        }
    }
}
