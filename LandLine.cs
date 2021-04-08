namespace OpConcept
{
    public class LandLine : Phone
    {
        private int _weight;

        public int GetWeight()
        {
            return _weight;
        }
        public void SetWeight(int weight)
        {
            _weight = weight;
        }
    }
}