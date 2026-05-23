namespace ProjectFighter;


public class DrawingFighter
{
    private EntityFighter? _entityFighter;
    private int? _startPosX;
    private int? _startPosY;
    private readonly int _drawingWidth = 120;
    private readonly int _drawingHeight = 80;

    public int? PosX => _startPosX;
    public int? PosY => _startPosY;
    public double? Step => _entityFighter?.Step;
    public int Width => _drawingWidth;
    public int Height => _drawingHeight;

    public void Init(int speed, double weight, Color bodyColor, EngineCountType engineCount)
    {
        _entityFighter = new EntityFighter();
        _entityFighter.Init(speed, weight, bodyColor, engineCount);
        _startPosX = null;
        _startPosY = null;
    }

    public void SetPosition(int x, int y)
    {
        _startPosX = x;
        _startPosY = y;
    }

    public void MoveLeft()
    {
        if (_entityFighter is null || !_startPosX.HasValue) return;
        _startPosX -= (int)_entityFighter.Step;
    }

    public void MoveRight()
    {
        if (_entityFighter is null || !_startPosX.HasValue) return;
        _startPosX += (int)_entityFighter.Step;
    }

    public void MoveUp()
    {
        if (_entityFighter is null || !_startPosY.HasValue) return;
        _startPosY -= (int)_entityFighter.Step;
    }

    public void MoveDown()
    {
        if (_entityFighter is null || !_startPosY.HasValue) return;
        _startPosY += (int)_entityFighter.Step;
    }

    public void DrawTransport(Graphics g)
    {
        if (_entityFighter is null || !_startPosX.HasValue || !_startPosY.HasValue) return;

        int x = _startPosX.Value;
        int y = _startPosY.Value;

        using (SolidBrush bodyBrush = new SolidBrush(_entityFighter.BodyColor))
        {
            // Фюзеляж
            g.FillEllipse(bodyBrush, x, y + 20, _drawingWidth, 40);

            // Кабина пилота
            using (SolidBrush cockpitBrush = new SolidBrush(Color.LightBlue))
            {
                g.FillEllipse(cockpitBrush, x + 70, y + 15, 25, 20);
                g.DrawEllipse(Pens.Black, x + 70, y + 15, 25, 20);
            }

            // Нос самолета
            g.FillEllipse(bodyBrush, x + 100, y + 25, 30, 30);

            // Левое крыло
            Point[] leftWing = new Point[]
            {
                new Point(x + 20, y + 40),
                new Point(x - 40, y + 60),
                new Point(x + 20, y + 60)
            };
            g.FillPolygon(bodyBrush, leftWing);
            g.DrawPolygon(Pens.Black, leftWing);

            // Правое крыло
            Point[] rightWing = new Point[]
            {
                new Point(x + 60, y + 40),
                new Point(x + 120, y + 60),
                new Point(x + 60, y + 60)
            };
            g.FillPolygon(bodyBrush, rightWing);
            g.DrawPolygon(Pens.Black, rightWing);

            // Дополнительные крылья для маневренности (левое)
            Point[] extraLeftWing = new Point[]
            {
                new Point(x, y + 45),
                new Point(x - 20, y + 55),
                new Point(x, y + 55)
            };
            g.FillPolygon(bodyBrush, extraLeftWing);
            g.DrawPolygon(Pens.Black, extraLeftWing);

            // Дополнительные крылья для маневренности (правое)
            Point[] extraRightWing = new Point[]
            {
                new Point(x + 80, y + 45),
                new Point(x + 100, y + 55),
                new Point(x + 80, y + 55)
            };
            g.FillPolygon(bodyBrush, extraRightWing);
            g.DrawPolygon(Pens.Black, extraRightWing);

            // Хвостовое оперение
            Point[] tail = new Point[]
            {
                new Point(x + 5, y + 30),
                new Point(x - 10, y + 10),
                new Point(x + 5, y + 15)
            };
            g.FillPolygon(bodyBrush, tail);
            g.DrawPolygon(Pens.Black, tail);

            // Ракеты
            using (SolidBrush missileBrush = new SolidBrush(Color.Gray))
            {
                g.FillRectangle(missileBrush, x + 5, y + 65, 20, 6);
                g.FillEllipse(missileBrush, x + 3, y + 66, 5, 4);
                g.FillRectangle(missileBrush, x + 55, y + 65, 20, 6);
                g.FillEllipse(missileBrush, x + 53, y + 66, 5, 4);
            }

            // Двигатели (усложненная часть)
            using (SolidBrush engineBrush = new SolidBrush(Color.DarkGray))
            {
                int engineCount = (int)_entityFighter.EngineCount;
                int spacing = _drawingWidth / (engineCount + 1);

                for (int i = 1; i <= engineCount; i++)
                {
                    int engineX = x + (spacing * i) - 10;
                    g.FillEllipse(engineBrush, engineX, y + 50, 12, 8);
                    g.DrawEllipse(Pens.Black, engineX, y + 50, 12, 8);
                    g.FillEllipse(engineBrush, engineX + 3, y + 53, 6, 4);
                }
            }
        }

        g.DrawEllipse(Pens.Black, x, y + 20, _drawingWidth, 40);

        using (SolidBrush windowBrush = new SolidBrush(Color.LightGray))
        {
            g.FillEllipse(windowBrush, x + 30, y + 30, 8, 8);
            g.FillEllipse(windowBrush, x + 50, y + 30, 8, 8);
        }
    }
}