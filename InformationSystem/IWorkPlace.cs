using System.Collections.ObjectModel;

namespace InformationSystem
{
    public interface IWorkPlace
    {
        ObservableCollection<IExplorable> Children { get; set; }
        Chief Superior { get; set; }
    }
}