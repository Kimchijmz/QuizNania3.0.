using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNania3._0_.Models
{
    internal class AllQuizQuestions
    {
        public static List<Quiz> ListNewQuiz = new List<Quiz>();
        public static List<Question> ListNewQuestions = new List<Question>();
        public List<Question> _allQuizQuestions = new List<Question>()
        {
            // HIPHOP CATEGORY
            new Question("Who is known as ´King of HipHop´ and have won 21 Grammy Awards?", new string[]{"Eminem", "Jay-Z", "Kanye West"}, 2, "HipHop","\\QuizImages\\HipHop.jpg",1 ),
            new Question("Which HipHop group released the album 'Straight Outta Compton´?", new string[]{"N.W.A", "Wu-Tang Clan", "Public Enemy" }, 1, "HipHop", "\\QuizImages\\HipHop.jpg",2),
            new Question("Which rappers name is 'Marshall Mathers'?", new string[]{"50 Cent", "Snoop Dog", "Eminem"}, 3, "HipHop","\\QuizImages\\HipHop.jpg",3),
            new Question("Which rapper and actor appeared in the movie 'Boyz n the Hood'?", new string[]{"Ice Cube", "LL Cool J", "Will Smith"}, 1, "HipHop", "\\QuizImages\\HipHop.jpg",4),
            
            // SPORTS CATEGORY
            new Question("Which basketball player is known as 'The Black Mamba'?", new string[]{"Kobe Bryant","LeBron James", "Kevin Durant"}, 1, "Sports","\\QuizImages\\Sports.jpg",5),
            new Question("In which city are the summer Olympics 2024 planning to be held in?", new string[]{"Tokyo", "Paris", "Los Angeles"}, 2, "Sports","\\QuizImages\\Sports.jpg",6),
            new Question("Which country has won the most FIFA World Cup titles in soccer?", new string[]{"Brazil", "Argentina", "Germany"}, 1, "Sports", "\\QuizImages\\Sports.jpg",7),
            new Question("Who holds the record for the career home runs in Major Leauge Baseball?", new string[] {"Babe Ruth", "Hank Aaron", "Barry Bonds"}, 3, "Sports", "\\QuizImages\\Sports.jpg",8),
            
            // CARS CATEGORY
            new Question("What does 'SUV' stand for?", new string[] { "Sport Utility Vechicle", "Super Urban Vechile", "Sport Urban Vechicle" }, 1, "Cars", "\\QuizImages\\Cars.jpg",9),
            new Question("Which italian car manufacturer is known for the Hurrucan?", new string[]{"Alfa Romeo", "Ferrari", "Lamborghini" }, 3, "Cars", "\\QuizImages\\Cars.jpg",10),
            new Question("What does 'ABS' stand for?", new string[]{"Anti-Brake System", "Anti-Brake Solution", "Anti-Lock Braking System"}, 3, "Cars", "\\QuizImages\\Cars.jpg",11),
            new Question("Which brand produces the S-Class and C-CLass cars?", new string[] { "BMW", "Mercedez-Benz", "Audi" } , 2, "Cars", "\\QuizImages\\Cars.jpg",12),
            
            // BRANDS CATEGORY 
            new Question("Which luxury brand is known for is double G logo?", new string[]{"Golden Goose", "Gucci","Givenchy"}, 2, "Brands","\\QuizImages\\BrandS.jpg",13),
            new Question("Which luxury Swiss watchmaker is famous for its sports and diving watches?", new string[] { "Patek Philippe", "Audemars Piguet", "Rolex" }, 3, "BrandS", "\\QuizImages\\BrandS.jpg",14),
            new Question("Which french luxury brand is recognized for the Birkin?", new string[]{"Fendi", "Hermes", "Prada"}, 2, "Brands", "\\QuizImages\\BrandS.jpg",15),
           // new Question("Which luxury automobile manufacturer is based in Stuttgart, Germany?", new string[]{"Porsche","Audi","Mercedez-Benz"}, 1, "Brands", "\\QuizImages\\BrandS.jpg"),

        };

        public static List<string> allCategories = new List<string>()
        {
            "HipHop", "Cars", "Sports","Brands"
        };

    }
}
