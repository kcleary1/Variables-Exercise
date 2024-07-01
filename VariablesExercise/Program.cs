namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Dennis";
            int homeRuns = 38;
            char hittingGrade = 'A';
            bool willBe = (homeRuns >= 35);
            string lower = willBe.ToString().ToLower();
            
           

            double numberOfPlayersWithGradeA = 10;
            decimal percentageOfPlayersWithGradeA = 0.513M;


            Console.WriteLine($"It is {lower}, {name} will be considered for induction into the Baseball Hall of Fame, since he ended the season with {homeRuns} home runs. This earned him a hitting grade of \"{hittingGrade}\". The number of players with this grade was {numberOfPlayersWithGradeA}. This was {percentageOfPlayersWithGradeA} percent of all players in the league.");
        }
    }
}
