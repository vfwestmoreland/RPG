﻿namespace RPG.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Pumpkin the Great!";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass RpgClass { get; set; } = RpgClass.Knight;
    }
}
