
namespace WindowsClipSolver.Core;
public class ScreenCapture : Form
{
    private Point startPt;
    private Point endPt;

    private Rectangle imageRect = Rectangle.Empty;
    private Bitmap? buff = null;

    private bool flag, pressedFlag = false;
    private int X = 0, Y = 0, WIDTH = 0, HEIGHT = 0;
    private Color selectionColor;

    public ScreenCapture() : this(Color.Gray)
    {
    }

    public ScreenCapture(Color selectionColor)
    {
        this.selectionColor = selectionColor;

        startPt = new Point();
        endPt = new Point();

        // Setting full screen size;
        this.WindowState = FormWindowState.Maximized;

        // Mouse Listener and Mouse Motion Listener;
        this.MouseClick += new MouseEventHandler(MouseClicked);
        this.MouseDown += new MouseEventHandler(MousePressed);
        this.MouseMove += new MouseEventHandler(MouseMoved);
        this.MouseUp += new MouseEventHandler(MouseReleased);

        // Making the form transparent;
        this.FormBorderStyle = FormBorderStyle.None;
        this.Opacity = 0.2;
    }

    public void CaptureImage()
    {
        flag = false;
        this.Visible = true;

        while (!flag)
        {
            System.Threading.Thread.Sleep(100);
            Application.DoEvents();
        }
    }

    // Painting selected region;
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (pressedFlag)
        {
            SetValues();
            using (SolidBrush brush = new SolidBrush(selectionColor))
            {
                e.Graphics.FillRectangle(brush, X, Y, WIDTH, HEIGHT);
            }
        }
    }

    // Calculating start point and width & height;
    private void SetValues()
    {
        X = Math.Min(startPt.X, endPt.X);
        Y = Math.Min(startPt.Y, endPt.Y);
        WIDTH = Math.Abs(startPt.X - endPt.X);
        HEIGHT = Math.Abs(startPt.Y - endPt.Y);
    }

    public void SetSelectionColor(Color color)
    {
        this.selectionColor = color;
    }
    // Starting point of selected region;
    private void MousePressed(object sender, MouseEventArgs e)
    {
        pressedFlag = true;
        startPt = e.Location;
    }
    private void MouseReleased(object sender, MouseEventArgs e)
    {
        if (WIDTH == 0 || HEIGHT == 0)
        {
            flag = true;
            this.Dispose();
            return;
        }
        this.Visible = false;
        // imageRect is selected region;
        imageRect = new Rectangle(X, Y, WIDTH, HEIGHT);
        try
        {
            // Capturing image of selected region;
            buff = new Bitmap(imageRect.Width, imageRect.Height);
            using (Graphics g = Graphics.FromImage(buff))
            {
                g.CopyFromScreen(imageRect.Location, Point.Empty, imageRect.Size);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        flag = true;
        pressedFlag = false;
        this.Dispose();
    }
    private void MouseMoved(object sender, MouseEventArgs e)
    {
        endPt = e.Location;
        this.Invalidate();
    }
    private void MouseClicked(object sender, MouseEventArgs e)
    {
    }
    public bool IsImageCaptured()
    {
        return (buff != null);
    }
    public Bitmap GetImage()
    {
        return buff;
    }
    public Image GetImageIcon()
    {
        return buff;
    }
}


