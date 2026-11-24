using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive;
using Avalonia.Controls;
using CITAR_Lab_Organizer_Beta.Views;

namespace CITAR_Lab_Organizer_Beta.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object? _selectedCourseContent;
        public object? SelectedCourseContent
        {
            get => _selectedCourseContent;
            set => this.RaiseAndSetIfChanged(ref _selectedCourseContent, value);
        }

        public ReactiveCommand<string, Unit> SelectCourseCommand { get; }

        public MainWindowViewModel()
        {
            SelectCourseCommand = ReactiveCommand.Create<string>(OnCourseSelected);
        }

        private void OnCourseSelected(string course)
        {
            SelectedCourseContent = new CourseContentView { DataContext = new CourseContentViewModel(course) };

        }
    }
}
