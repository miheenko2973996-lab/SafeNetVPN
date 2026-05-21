using CommunityToolkit.Mvvm.Input;
using SafeNetVPN.Models;

namespace SafeNetVPN.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}