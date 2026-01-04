using System.Windows.Input;

namespace ViewModel.MyLib
{
    public class RelayCommand : ICommand
    {
        private readonly Action ex;
        private readonly Func<bool>? ce;
        public RelayCommand(Action e, Func<bool>? c = null) { ex = e; ce = c; }
        public RelayCommand(Action action) => ex = action;  
        public bool CanExecute(object? p) => ce?.Invoke() ?? true; public void Execute(object? p) => ex();
        public event EventHandler? CanExecuteChanged;
    }
}
