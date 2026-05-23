namespace ProjectFighter;


public class CanvasForFighter
{
    private DrawingFighter? _drawingFighter;
    private int? _canvasWidth;
    private int? _canvasHeight;

    public void SetPictureSize(int width, int height)
    {
        _canvasWidth = width;
        _canvasHeight = height;
    }

   
    public bool InsertFighter(DrawingFighter fighter)
    {
       
        if (!_canvasWidth.HasValue || !_canvasHeight.HasValue)
        {
            return false;
        }

     
        if (fighter.Width > _canvasWidth.Value || fighter.Height > _canvasHeight.Value)
        {
            return false;
        }

        _drawingFighter = fighter;
        return true;
    }

    
    public void SetFighterPosition(int x, int y)
    {
        if (!_canvasWidth.HasValue || !_canvasHeight.HasValue || _drawingFighter is null)
        {
            return;
        }

        int newX = x;
        int newY = y;

        
        if (newX < 0)
        {
            newX = 0;
        }
        if (newX + _drawingFighter.Width > _canvasWidth.Value)
        {
            newX = _canvasWidth.Value - _drawingFighter.Width;
        }

        
        if (newY < 0)
        {
            newY = 0;
        }
        if (newY + _drawingFighter.Height > _canvasHeight.Value)
        {
            newY = _canvasHeight.Value - _drawingFighter.Height;
        }

        _drawingFighter.SetPosition(newX, newY);
    }

    
    public bool MoveTransport(DirectionType direction)
    {
        if (!_canvasWidth.HasValue || !_canvasHeight.HasValue ||
            _drawingFighter is null || !_drawingFighter.PosX.HasValue ||
            !_drawingFighter.PosY.HasValue || !_drawingFighter.Step.HasValue)
        {
            return false;
        }

        int currentX = _drawingFighter.PosX.Value;
        int currentY = _drawingFighter.PosY.Value;
        int step = (int)_drawingFighter.Step.Value;

        switch (direction)
        {
            case DirectionType.Left:
                if (currentX - step > 0)
                {
                    _drawingFighter.MoveLeft();
                    return true;
                }
                else if (currentX > 0)
                {
                    _drawingFighter.SetPosition(0, currentY);
                    return true;
                }
                break;

            case DirectionType.Up:
                if (currentY - step > 0)
                {
                    _drawingFighter.MoveUp();
                    return true;
                }
                else if (currentY > 0)
                {
                    _drawingFighter.SetPosition(currentX, 0);
                    return true;
                }
                break;

            case DirectionType.Right:
                if (currentX + step + _drawingFighter.Width < _canvasWidth.Value)
                {
                    _drawingFighter.MoveRight();
                    return true;
                }
                else if (currentX + _drawingFighter.Width < _canvasWidth.Value)
                {
                    _drawingFighter.SetPosition(_canvasWidth.Value - _drawingFighter.Width, currentY);
                    return true;
                }
                break;

            case DirectionType.Down:
                if (currentY + step + _drawingFighter.Height < _canvasHeight.Value)
                {
                    _drawingFighter.MoveDown();
                    return true;
                }
                else if (currentY + _drawingFighter.Height < _canvasHeight.Value)
                {
                    _drawingFighter.SetPosition(currentX, _canvasHeight.Value - _drawingFighter.Height);
                    return true;
                }
                break;
        }

        return false;
    }

    public Bitmap? DrawCanvas()
    {
        if (!_canvasWidth.HasValue || !_canvasHeight.HasValue)
        {
            return null;
        }

        Bitmap bmp = new Bitmap(_canvasWidth.Value, _canvasHeight.Value);

        using (Graphics graphics = Graphics.FromImage(bmp))
        {
            graphics.Clear(Color.SkyBlue);
            _drawingFighter?.DrawTransport(graphics);
        }

        return bmp;
    }
}