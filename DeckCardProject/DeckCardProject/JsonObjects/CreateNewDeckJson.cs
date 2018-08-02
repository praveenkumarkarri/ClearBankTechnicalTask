namespace DeckCardProject.JsonObjects
{

    public class CreateNewDeckJson
    {
        public string deck_id { get; set; }
        public bool shuffled { get; set; }
        public int remaining { get; set; }
        public bool success { get; set; }
    }

}
