using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBlockChain
{
    public class Block
    {
        #region Properties
        public string Hash { get; set;}
        public string PreviousHash { get; set; }
        public List<Transaction> TransactionList { get; set; }
        #endregion

        #region Constructors

        public Block(string previousHash)
        {
            this.PreviousHash = previousHash;
            this.TransactionList = new List<Transaction>();
        }

        #endregion

        #region Public methods
        public void AddTransaction(double amount, string from, string to)
        {
            this.TransactionList.Add(new Transaction
            {
                Amount = amount,
                From = from,
                To = to
            });
        }
        #endregion
    }
}
