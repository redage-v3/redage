﻿using GTANetworkAPI;
using NeptuneEvo.Handles;

namespace NeptuneEvo.Fractions.Table.Board
{
    public class Events : Script
    {
        [RemoteEvent("server.frac.main.getBoard")]
        public void Get(ExtPlayer player, int index) => 
            Repository.Get(player, index);
        
        [RemoteEvent("server.frac.main.addBoard")]
        public void Add(ExtPlayer player, string title, string text) => 
            Repository.Add(player, title, text);

        [RemoteEvent("server.frac.main.updateBoard")]
        public void Update(ExtPlayer player, int index, string title, string text) =>
            Repository.Update(player, index, title, text);
                
        [RemoteEvent("server.frac.main.deleteBoard")]
        public void DeleteBoard(ExtPlayer player, int index) => 
            Repository.Delete(player, index);
    }
}