using Kan_Do.WPF.State.Authenticators;
using Kan_Do.WPF.State.SaveState;
using Kan_Do.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.WPF.Commands
{
    public class SaveCommand : AsyncCommandBase
    {
        private readonly KanbanBoardViewModel _kanbanBoardViewModel;
        private readonly ISaveState _saveState;

        public SaveCommand(KanbanBoardViewModel kanbanBoardViewModel, ISaveState saveState)
        {
            _kanbanBoardViewModel = kanbanBoardViewModel;
            _saveState = saveState;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _saveState.Save(_kanbanBoardViewModel.Authenticator.CurrentAccount.AccountHolder.Id, _kanbanBoardViewModel);
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Something went wrong while saving");
            }
        }
    }
}
