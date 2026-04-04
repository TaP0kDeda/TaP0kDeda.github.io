using System;

namespace Task8
{
    [Serializable]
    public class GameResult
    {
        public string Login { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }          // сколько собрано
        public int Required { get; set; }       // сколько требовалось
        public bool IsWin { get; set; }

        public override string ToString()
        {
            return $"{Date:dd.MM.yyyy HH:mm:ss} | {Score}/{Required} | {(IsWin ? "Победа" : "Поражение")}";
        }
    }
}