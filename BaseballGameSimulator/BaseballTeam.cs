namespace BaseballGameSimulator
{
    class BaseballTeam
    {
        //private fields
        private string _name;
        private string _stadium;
        private int _wins = 0;
        private int _losses = 0;
        private int _draws = 0;

        //public property for the team's record
        public double Record
        {
            get
            {
                int played = this._wins + this._losses + this._draws;
                return (double)this._wins / played;
            }
        }

        //public property for the team's ballpark so it can be changed or modified
        public string BallPark
        {
            get { return this._stadium; }
            set
            {
                this._stadium = value;
            }
        }

        //initial constructor
        public BaseballTeam(string name, string stadium)
        {
            this._name = name;
            this._stadium = stadium;
        }

        //play game method looks increments wins and losses depending on runsFor or against
        public void PlayGame(int runsFor, int runsAgainst)
        {
            if (runsFor > runsAgainst)
                this._wins++;
            else if(runsFor == runsAgainst)
            {
                this._draws++;
            }
            else
                this._losses++;
        }

        //prints end result
        public override string ToString()
        {
            return this._name + ", play at " + this._stadium + ": " + "W " + this._wins + " L " + this._losses + " D " + this._draws;
        }

        //override for PlayGame, checks enums and increments
        public void PlayGame(ResultEnums result)
        {
            if (result == ResultEnums.Win)
                this._wins++;
            else if (result == ResultEnums.Lose)
                this._losses++;
            else
            {
                this._draws++;
            }
        }
    }
}
