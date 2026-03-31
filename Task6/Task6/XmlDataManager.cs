using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Task6
{
    public static class XmlDataManager
    {
        private static string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "questions.xml");

        public static string FilePath
        {
            get => _filePath;
            private set => _filePath = value;
        }

        public static TestData LoadDataFromFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите XML-файл с вопросами";
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = openFileDialog.FileName;
                    return LoadData();
                }
            }
            return null;
        }

        public static TestData LoadData()
        {
            TestData data = new TestData();

            if (!File.Exists(FilePath))
            {
                CreateSampleData();
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(FilePath);

            // Читаем заголовок
            XmlNode headNode = doc.SelectSingleNode("//head");
            if (headNode != null)
                data.Head = headNode.InnerText;

            // Читаем описание
            XmlNode descNode = doc.SelectSingleNode("//description");
            if (descNode != null)
                data.Description = descNode.InnerText;

            // Создаем темы (у нас одна тема - "Природные достопримечательности")
            Theme mainTheme = new Theme { Name = "Природные достопримечательности России и Европы" };

            // Читаем вопросы 1 уровня (легкий)
            Level level1 = new Level { Difficulty = 1 };
            XmlNodeList easyQuestions = doc.SelectNodes("//qeasy/q");
            foreach (XmlNode qNode in easyQuestions)
            {
                level1.Questions.Add(ParseQuestion(qNode));
            }
            mainTheme.Levels.Add(level1);

            // Читаем вопросы 2 уровня (средний)
            Level level2 = new Level { Difficulty = 2 };
            XmlNodeList medQuestions = doc.SelectNodes("//qmed/q");
            foreach (XmlNode qNode in medQuestions)
            {
                level2.Questions.Add(ParseQuestion(qNode));
            }
            mainTheme.Levels.Add(level2);

            // Читаем вопросы 3 уровня (сложный)
            Level level3 = new Level { Difficulty = 3 };
            XmlNodeList hardQuestions = doc.SelectNodes("//qhard/q");
            foreach (XmlNode qNode in hardQuestions)
            {
                level3.Questions.Add(ParseQuestion(qNode));
            }
            mainTheme.Levels.Add(level3);

            data.Themes.Add(mainTheme);

            return data;
        }

        // Парсинг одного вопроса
        private static Question ParseQuestion(XmlNode qNode)
        {
            Question question = new Question();
            question.Text = qNode.Attributes["text"]?.Value;
            question.ImagePath = qNode.Attributes["src"]?.Value;

            int index = 0;
            foreach (XmlNode aNode in qNode.SelectNodes("a"))
            {
                Answer answer = new Answer();
                answer.Text = aNode.InnerText;
                answer.IsRight = aNode.Attributes["right"]?.Value == "yes";
                question.Answers.Add(answer);

                if (answer.IsRight)
                    question.CorrectAnswerIndex = index;

                index++;
            }

            return question;
        }

        // Создание примера данных, если файл не найден
        private static void CreateSampleData()
        {
            string sampleXml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<root>
    <head>Тест: Природные достопримечательности России и Европы</head>
    <description>Описание теста: Вам предлагаются вопросы с вариантами ответов, только один из вариантов правильный. Всего в тесте 3 уровня сложности, следующая сложность открывается после завершения прошлого на минимум 80 баллов из 100. На один вопрос даётся 30 секунд</description>
    <qeasy>
        <q text=""Какое озеро в России является самым глубоким в мире?"" src=""baikal.jpg"">
            <a right=""no"">Ладожское</a>
            <a right=""yes"">Байкал</a>
            <a right=""no"">Онежское</a>
        </q>
        <q text=""В какой стране находятся самые знаменитые фьорды?"" src=""fjords.jpg"">
            <a right=""no"">Швеция</a>
            <a right=""no"">Финляндия</a>
            <a right=""yes"">Норвегия</a>
        </q>
    </qeasy>
    <qmed>
        <q text=""Как называются гигантские каменные столбы в республике Коми?"" src=""manpupuner.jpg"">
            <a right=""no"">Ленские столбы</a>
            <a right=""yes"">Маньпупунёр</a>
            <a right=""no"">Дивногорье</a>
        </q>
    </qmed>
    <qhard>
        <q text=""Как называется самый высокий водопад в России?"" src=""talnikovy.jpg"">
            <a right=""yes"">Тальниковый</a>
            <a right=""no"">Кивач</a>
            <a right=""no"">Зейгалан</a>
        </q>
    </qhard>
</root>";

            File.WriteAllText(FilePath, sampleXml);
        }

        // Сохранение данных (для администратора)
        public static void SaveData(TestData data)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(decl);

            XmlElement root = doc.CreateElement("root");
            doc.AppendChild(root);

            // Сохраняем заголовок
            XmlElement head = doc.CreateElement("head");
            head.InnerText = data.Head;
            root.AppendChild(head);

            // Сохраняем описание
            XmlElement description = doc.CreateElement("description");
            description.InnerText = data.Description;
            root.AppendChild(description);

            // Сохраняем вопросы по уровням
            if (data.Themes.Count > 0)
            {
                var theme = data.Themes[0];
                foreach (var level in theme.Levels)
                {
                    string levelName = level.Difficulty == 1 ? "qeasy" :
                                      level.Difficulty == 2 ? "qmed" : "qhard";

                    XmlElement levelElement = doc.CreateElement(levelName);
                    root.AppendChild(levelElement);

                    foreach (var q in level.Questions)
                    {
                        XmlElement qElement = doc.CreateElement("q");
                        qElement.SetAttribute("text", q.Text);
                        qElement.SetAttribute("src", q.ImagePath);

                        foreach (var a in q.Answers)
                        {
                            XmlElement aElement = doc.CreateElement("a");
                            aElement.SetAttribute("right", a.IsRight ? "yes" : "no");
                            aElement.InnerText = a.Text;
                            qElement.AppendChild(aElement);
                        }

                        levelElement.AppendChild(qElement);
                    }
                }
            }

            doc.Save(FilePath);
        }

        public static string GetCurrentFilePath()
        {
            return _filePath;
        }

        // Открыть другой файл
        public static TestData OpenAnotherFile()
        {
            return LoadDataFromFile();
        }

        // Получение вопросов по уровню
        public static List<Question> GetQuestions(TestData data, int difficulty)
        {
            if (data.Themes.Count == 0) return new List<Question>();
            var theme = data.Themes[0];
            var level = theme.Levels.FirstOrDefault(l => l.Difficulty == difficulty);
            return level?.Questions ?? new List<Question>();
        }

        // Добавление вопроса
        public static void AddQuestion(TestData data, int difficulty, Question question)
        {
            if (data.Themes.Count == 0)
                data.Themes.Add(new Theme { Name = "Природные достопримечательности России и Европы" });

            var theme = data.Themes[0];
            var level = theme.Levels.FirstOrDefault(l => l.Difficulty == difficulty);
            if (level == null)
            {
                level = new Level { Difficulty = difficulty };
                theme.Levels.Add(level);
            }

            level.Questions.Add(question);
            SaveData(data);
        }

        // Удаление вопроса
        public static void RemoveQuestion(TestData data, int difficulty, int index)
        {
            var questions = GetQuestions(data, difficulty);
            if (index >= 0 && index < questions.Count)
            {
                questions.RemoveAt(index);
                SaveData(data);
            }
        }
    }
}
