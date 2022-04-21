using Kan_Do.Domain.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kan_Do.Domain.Services
{
    public class SaveStateService : ISaveStateService
    {
        private readonly IBoardService _boardService;
        private readonly IColumnService _columnService;
        private readonly ICardService _cardService;
        private readonly IAccountService _accountService;

        public SaveStateService(IBoardService boardService, IColumnService columnService, ICardService cardService, IAccountService accountService)
        {
            _boardService = boardService;
            _columnService = columnService;
            _cardService = cardService;
            _accountService = accountService;
        }

        public async Task<IEnumerable<Board>> LoadBoards(int accountId)
        {
             return await _boardService.GetByUserId(accountId);
        }

        public async Task<IEnumerable<Card>> LoadCards(int accountId)
        {
            return await _cardService.GetByUserId(accountId);
        }

        public async Task<IEnumerable<Column>> LoadColumns(int accountId)
        {
            return await _columnService.GetByUserId(accountId);
        }

        public async Task Save(int accountId, int boardId, string boardName, ObservableCollection<KanbanColumn> boardColumns)
        {

            //save boards
            Board board = new Board()
            {
                BoardCreator = _boardService.Get(boardId).Result.BoardCreator,
                BoardName = boardName
            };
            Board boardEntity = await _boardService.Update(boardId, board);

            //save columns
            Column column;
            Column columnEntity;
            for (int i = 0; i < boardColumns.Count; i++)
            {
                column = new Column()
                {
                    ColumnName = boardColumns[i].ColumnName,
                    Position = boardColumns[i].ColumnNumber,
                    Board = await _boardService.Get(boardId)
                };
                columnEntity = await _columnService.GetByPositionOnBoard(boardId, boardColumns[i].ColumnNumber);
                if (columnEntity == null)
                {
                    await _columnService.Create(column);
                }
                else if (columnEntity.ColumnName != column.ColumnName)
                {
                    await _columnService.Update(columnEntity.Id, column);
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("Bro, how could this happen to meeeE??");
                }
            }

            //save cards
            Card card;
            Card cardEntity;
            for (int i = 0; i < boardColumns.Count; i++)
            {
                for (int j = 0; j < boardColumns[i].column_cards.Count; j++)
                {
                    card = new Card()
                    {
                        CardReferenceNumber = boardColumns[i].column_cards[j].CardID,
                        CardName = boardColumns[i].column_cards[j].CardName,
                        Assignee = boardColumns[i].column_cards[j].Assignee,
                        DateCreated = boardColumns[i].column_cards[j].DateCreated,
                        DueDate = boardColumns[i].column_cards[j].DueDate,
                        Priority = boardColumns[i].column_cards[j].Priority,
                        TaskDescription = boardColumns[i].column_cards[j].TaskDescription,
                        Column = await _columnService.GetByPositionOnBoard(boardId, boardColumns[i].ColumnNumber)
                    };
                    cardEntity = await _cardService.GetByColumnAndDate(boardColumns[i].ColumnNumber, boardColumns[i].column_cards[j].DateCreated);
                    
                    if (cardEntity == null)
                    {
                        await _cardService.Create(card);
                    }
                    else if (cardEntity.CardName != card.CardName ||
                        cardEntity.Assignee != card.Assignee ||
                        cardEntity.DueDate != card.DueDate ||
                        cardEntity.Priority != card.Priority ||
                        cardEntity.TaskDescription != card.TaskDescription ||
                        cardEntity.Column.Id != card.Column.Id)
                    {
                        await _cardService.Update(cardEntity.Id, card);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Bro, how could this happen to meeeE??");
                    }
                }
            }
        }

        public async Task<int> AddBoard(string boardName, Account currentAccount)
        {
            Board board = new Board()
            {
                BoardName = boardName,
                BoardCreator = await _accountService.GetByEmail(currentAccount.AccountHolder.Email)
            };
            Board entity = await _boardService.Create(board);
            return entity.Id;
        }
    }
}
