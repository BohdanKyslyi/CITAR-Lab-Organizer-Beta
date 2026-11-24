using ReactiveUI;
using System.Collections.ObjectModel;

namespace CITAR_Lab_Organizer_Beta.ViewModels
{
    public class CourseContentViewModel : ViewModelBase
    {
        public string CourseName { get; }
        public ObservableCollection<string> Buttons { get; set; } = new ObservableCollection<string>();

        public CourseContentViewModel(string course)
        {
            CourseName = $"{course} курс";

            switch (course)
            {
                case "1":
                    Buttons.Add("Густина полого циліндра");
                    Buttons.Add("Густина суцільного циліндра");
                    Buttons.Add("Густина пластинки");
                    Buttons.Add("Густина кулі");
                    break;
                case "2":
                    Buttons.Add("Модель максимальної узагальненої корисності");
                    Buttons.Add("Критерій максимального математичного сподівання");
                    Buttons.Add("Критерій мінімальної дисперсії");
                    Buttons.Add("Критерій «очікуване значення – дисперсія»");
                    break;
                case "3":
                    Buttons.Add("Асимптотична частотна характеристика");
                    Buttons.Add("Кореневий критерій та критерій Лапласа");
                    Buttons.Add("Коефіцієнт серійності");
                    Buttons.Add("Кількість робочих місць, необхідних для виконання\nпроцесу виготовлення виробу");
                    Buttons.Add("Комплексний показник технологічності");
                    break;
                case "4":
                    Buttons.Add("НСАВ за методом Шумана та Лямбда");
                    Buttons.Add("НСАВ за методом Мілса");
                    Buttons.Add("НСАВ за моделлю Джелінскі-Моранді");
                    Buttons.Add("НСАВ за моделлю Нельсона");
                    break;
            }
        }
    }
}
