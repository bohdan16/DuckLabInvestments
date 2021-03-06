//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuckLab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        public Game()
        {
            this.GameUsers = new HashSet<GameUser>();
            this.UserStocks = new HashSet<UserStock>();
        }
    
        public int gameId { get; set; }
        public string gameName { get; set; }
        public int adminId { get; set; }
        public string gameStatus { get; set; }
        public string gameType { get; set; }
        public Nullable<decimal> startingBalance { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<GameUser> GameUsers { get; set; }
        public virtual ICollection<UserStock> UserStocks { get; set; }
    }
}
