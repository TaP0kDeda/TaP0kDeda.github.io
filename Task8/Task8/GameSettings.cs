using System;
using System.Drawing;

namespace Task8
{
    public enum Difficulty { Easy, Medium, Hard }

    [Serializable]
    public class GameSettings
    {
        public int TimeSeconds { get; set; } = 60;
        public int TargetMeteors { get; set; } = 10;
        public Difficulty Difficulty { get; set; } = Difficulty.Medium;
        public Color RocketColor { get; set; } = Color.Green;
        public Color LargeMeteorColor { get; set; } = Color.Red;
        public Color SmallMeteorColor { get; set; } = Color.Yellow;
        public int RocketSpeed { get; set; } = 12;
        public int MeteorBaseSpeed { get; set; } = 5;
        public int SpawnIntervalMs { get; set; } = 800;
        public float LargeMeteorProbability { get; set; } = 0.3f;
    }
}
