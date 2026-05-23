namespace ProjectFighter;

public partial class FormFighter : Form
{
    private readonly CanvasForFighter _canvas;
    private DirectionType _checkBordersState;

    public FormFighter()
    {
        InitializeComponent();

        _canvas = new CanvasForFighter();
        _canvas.SetPictureSize(pictureBoxFighter.Width, pictureBoxFighter.Height);
        _checkBordersState = DirectionType.None;
    }

    private void Draw()
    {
        pictureBoxFighter.Image = _canvas.DrawCanvas();
    }

    private void UpdateStats(int speed, double weight, EngineCountType engineCount)
    {
        labelSpeed.Text = $"Скорость: {speed} ед/с";
        labelWeight.Text = $"Вес: {weight} кг";
        labelEngineCount.Text = $"Двигателей: {(int)engineCount}";
    }

    private void ButtonCreateFighter_Click(object sender, EventArgs e)
    {
        Random random = new Random();

        int speed = random.Next(100, 300);
        double weight = random.Next(1000, 3000);
        Color bodyColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

        Array engineValues = Enum.GetValues(typeof(EngineCountType));
        EngineCountType engineCount = (EngineCountType)(engineValues.GetValue(random.Next(engineValues.Length)) ?? EngineCountType.TwoEngines);

        DrawingFighter fighter = new DrawingFighter();
        fighter.Init(speed, weight, bodyColor, engineCount);

        if (_canvas.InsertFighter(fighter))
        {
            _canvas.SetFighterPosition(random.Next(10, 100), random.Next(10, 100));
            Draw();
            UpdateStats(speed, weight, engineCount);
        }
    }

    private void ButtonMove_Click(object sender, EventArgs e)
    {
        Button? button = sender as Button;
        if (button == null) return;

        DirectionType direction = DirectionType.None;

        switch (button.Name)
        {
            case "buttonUp":
                direction = DirectionType.Up;
                break;
            case "buttonDown":
                direction = DirectionType.Down;
                break;
            case "buttonLeft":
                direction = DirectionType.Left;
                break;
            case "buttonRight":
                direction = DirectionType.Right;
                break;
        }

        if (_canvas.MoveTransport(direction))
        {
            Draw();
        }
    }

    private void ButtonCheckBorders_Click(object sender, EventArgs e)
    {
        Random random = new Random();

        switch (_checkBordersState)
        {
            case DirectionType.None:
            case DirectionType.Down:
                _canvas.SetFighterPosition(random.Next(10, 100) - 1000, random.Next(10, 100));
                _checkBordersState = DirectionType.Left;
                break;

            case DirectionType.Left:
                _canvas.SetFighterPosition(random.Next(10, 100), random.Next(10, 100) - 1000);
                _checkBordersState = DirectionType.Up;
                break;

            case DirectionType.Up:
                _canvas.SetFighterPosition(random.Next(10, 100) + 1000, random.Next(10, 100));
                _checkBordersState = DirectionType.Right;
                break;

            case DirectionType.Right:
                _canvas.SetFighterPosition(random.Next(10, 100), random.Next(10, 100) + 1000);
                _checkBordersState = DirectionType.Down;
                break;
        }

        Draw();
    }
}