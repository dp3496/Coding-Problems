using Hackerrank.Interface;

namespace Hackerrank
{
    public class TeamMatchesFinder : IRunnable
    {
        public string Run(string[] args)
        {
            var input = int.Parse(args[0]);
            var currentTeams = input;
            int matches = 0;

            while (true)
            {
                if(currentTeams == 1)
                {
                    break;
                }

                var presentMatches = currentTeams / 2;
                matches += presentMatches;
                currentTeams -= presentMatches;
            }

            return matches.ToString();
        }
    }
}