using CommunityToolkit.Mvvm.Input;
using lab2.Models;

namespace lab2.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}