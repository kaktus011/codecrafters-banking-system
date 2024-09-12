﻿namespace BankingManagementSystem.Core.Models.Account
{
    using Transaction;

    public class AccountDetailsDto
    {
        public string? CreatorId { get; set; }

        public string? Creator { get; set; }

        public long AccountId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Iban { get; set; } = string.Empty;

        public decimal Balance { get; set; }

        public long CustomerId { get; set; }

        public ICollection<TransactionDetailsDTO> TransactionsFrom { get; set; } 
            = new List<TransactionDetailsDTO>();

        public ICollection<TransactionDetailsDTO> TransactionsTo { get; set; } 
            = new List<TransactionDetailsDTO>();
    }
}