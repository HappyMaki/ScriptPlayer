﻿namespace ScriptPlayer.Shared
{
    public struct Resolution
    {
        public int Horizontal { get; set; }
        public int Vertical { get; set; }

        public Resolution(int horizonal, int vertical)
        {
            Horizontal = horizonal;
            Vertical = vertical;
        }
    }
}