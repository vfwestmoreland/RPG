﻿namespace RPG.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = "Pumpkin the Great!";

        public int HitPoints { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass RpgClass { get; set; } = RpgClass.Knight;

    }
}
