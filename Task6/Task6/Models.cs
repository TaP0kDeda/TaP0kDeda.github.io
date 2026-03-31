using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Task6
{
    public class Question
    {
        public string Text { get; set; }          // Текст вопроса
        public string ImagePath { get; set; }     // Путь к изображению
        public List<Answer> Answers { get; set; } // Варианты ответов
        public int CorrectAnswerIndex { get; set; } // Индекс правильного ответа

        public Question()
        {
            Answers = new List<Answer>();
        }
    }

    public class Answer
    {
        public string Text { get; set; }
        public bool IsRight { get; set; }
    }

    public class Level
    {
        public int Difficulty { get; set; }          // 1, 2, 3
        public List<Question> Questions { get; set; }

        public Level()
        {
            Questions = new List<Question>();
        }
    }

    public class Theme
    {
        public string Name { get; set; }
        public List<Level> Levels { get; set; }

        public Theme()
        {
            Levels = new List<Level>();
        }
    }

    public class TestData
    {
        public string Head { get; set; }
        public string Description { get; set; }
        public List<Theme> Themes { get; set; }

        public TestData()
        {
            Themes = new List<Theme>();
        }
    }
}
