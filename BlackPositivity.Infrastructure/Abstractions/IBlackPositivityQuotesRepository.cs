﻿using BlackPositivity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackPositivity.Infrastructure
{
    public interface IBlackPositivityQuotesRepository
    {
        Task<IEnumerable<BlackPositivityQuote>> GetAllQuotes();

        Task<BlackPositivityQuote> GetQuote(Guid id);

        Task<bool> UpdateQuote(Guid id, BlackPositivityQuote quote);

        Task<BlackPositivityQuote> CreateQuote(BlackPositivityQuote quote);

        Task<BlackPositivityQuote> DeleteQuote(Guid id);

        bool QuoteExists(Guid id);

        Task<bool> ResetQuotes();

        Task<BlackPositivityQuote> FreshQuote();
    }
}
