namespace Unit03.Game
{
    public class Director
    {
        private Hider hider = new Hider();
        private bool isPlaying = true;
        private Seeker seeker = new Seeker();
        private TerminalService terminalService = new TerminalService();

        public Director()
        {
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void GetInputs()
        {
            terminalService.WriteText(hider.location.ToString());
            int location = terminalService.ReadNumber("\nEnter a location [1-1000]: ");
            seeker.MoveLocation(location);
        }

        private void DoUpdates()
        {
            hider.WatchSeeker(seeker);
        }

        private void DoOutputs()
        {
            string hint = hider.GetHint();
            terminalService.WriteText(hint);
            if (hider.IsFound())
            {
                isPlaying = false;
            }
            
        }
    }
}