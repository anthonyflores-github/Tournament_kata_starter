namespace Tournaments.Services
{
    using System;
    using System.Collections.Generic;
    using Tournaments.Model;

    public class TournamentRepository
    {
        private static readonly Dictionary<string, Tournament> Tournaments = new ();

        public string CreateTournament(TournamentToCreate tournamentToCreate)
        {
            var id = Guid.NewGuid().ToString();
            Tournaments.Add(id, new Tournament
            {
                Id = id,
                Name = tournamentToCreate.Name
            });
            return id;
        }

        public Tournament GetTournament(string id)
        {
            return Tournaments[id];
        }
    }
}