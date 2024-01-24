using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Newtonsoft.Json;


namespace QuizNania3._0_.Models
{
    internal class JSON
    {
        public static async void Folder()
        {
            string folderPath = FolderPath();

            if (!Directory.Exists(folderPath))
            {
                AllQuizQuestions allQuizQuestion = new AllQuizQuestions();
                Directory.CreateDirectory(folderPath);
                MessageBox.Show("Folder have been created!");
                await SaveList(allQuizQuestion._allQuizQuestions);
            }
        }

        public static Task SaveList(List<Question> _questions)
        {
            var Json = JsonConvert.SerializeObject(_questions,Formatting.Indented);
            File.WriteAllText(FullPath(), Json);

            return Task.CompletedTask;
        }




        public static IEnumerable<Question> GetAllQuizQuestionsJSON()
        {
            if (Directory.Exists(FullPath()))
            {
                string json = FullPath();
                if (json != string.Empty)
                {
                    json = File.ReadAllText(FullPath());
                    return JsonConvert.DeserializeObject<List<Question>>(json);
                }
            }
            else
            {
                Folder();
                string json = FullPath();
                if (json != string.Empty)
                {
                    json = File.ReadAllText(FullPath());
                    return JsonConvert.DeserializeObject<List<Question>>(json);
                }
                MessageBox.Show("!");
                return null;
            }
            MessageBox.Show("!!!");
            return null;
        }

        private static string FolderPath()
        {
            string folderName = "QuizFolderr";
            string DocPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folderPath = System.IO.Path.Combine(DocPath, folderName);

            return folderPath;
        }

        private static string TextPath(string folderPath)
        {
            string textName = "ListofQuestion.txt";
            string textPath = System.IO.Path.Combine(folderPath, textName);
            return textPath;
        }
        private static string FullPath()
        {
            string folderPath = FolderPath();
            string textPath = TextPath(folderPath);
            return textPath;
        }
    }
}
