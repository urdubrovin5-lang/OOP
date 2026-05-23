namespace ProjectFighter;


public class EntityFighter
{
    public int Speed { get; private set; }
    public double Weight { get; private set; }
    public Color BodyColor { get; private set; }
    public EngineCountType EngineCount { get; private set; }

    
    public double Step => Speed * 100 / Weight;

    public void Init(int speed, double weight, Color bodyColor, EngineCountType engineCount)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodyColor;
        EngineCount = engineCount;
    }
}