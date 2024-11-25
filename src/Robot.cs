using System;
using SplashKitSDK;

public abstract class Robot
{
    public double X { get; private set; }
    public double Y { get; private set; }
    public Color MainColor { get; set; }
    private Vector2D Velocity { get; set; }

    public int Width
    {
        get { return 50; }
    }
    public int Height
    {
        get { return 50; }
    }

    public Circle CollisionCircle
    {
        get
        {
            return SplashKit.CircleAt(X, Y, 20);
        }
    }
    public abstract void Draw();
    public Robot(Window gameWindow, Player player)
    {
        MainColor = SplashKit.RandomRGBColor(200);
        if (SplashKit.Rnd() < 0.05)
        {
            //gives random position left to right
            X = SplashKit.Rnd(gameWindow.Width);

            //checks if robot is top or bottom
            if (SplashKit.Rnd() < 0.05)
                Y = -Height; //top
            else
                Y = gameWindow.Height; //bottom
        }
        else
        {

            Y = SplashKit.Rnd(gameWindow.Width);


            if (SplashKit.Rnd() < 0.05)
                X = -Height;
            else
                X = gameWindow.Height;

        }

        const int SPEED = 4;

        //get a point for the robot
        Point2D fromPt = new Point2D()
        {
            X = X,
            Y = Y
        };

        //get a point for the player
        Point2D toPt = new Point2D()
        {
            X = player.X,
            Y = player.Y
        };

        //calculate the direction to head
        Vector2D dir;
        dir = SplashKit.UnitVector(SplashKit.VectorPointToPoint(fromPt, toPt));

        //set the speed and assign to the Velocity
        Velocity = SplashKit.VectorMultiply(dir, SPEED);
        //generate a random color for robot
        MainColor = Color.RandomRGB(200);
    }

    public void Update() //moves the robot 
    {
        X = X + Velocity.X;
        Y = Y + Velocity.Y;
    }
    public bool IsOffscreen(Window screen)
    {
        /*if (X < -Width || X > screen.Width || Y < -Height || Y > screen.Height)
        return true;
        else 
        return false;*/

        return (X < -Width || X > screen.Width || Y < -Height || Y > screen.Height) ? true : false;
    }
}

public class Boxy : Robot
{
    public Boxy(Window gameWindow, Player player) : base(gameWindow, player)
    {
        ;
    }
    public override void Draw()
    {

        
        double rightX; rightX = X + 27;
        double leftX; leftX = X + 12;
        double eyeY; eyeY = Y + 10;
        double mouthY; mouthY = Y + 30;

        SplashKit.FillRectangle(Color.Black, X, Y, 50, 50);
        SplashKit.FillRectangle(MainColor, leftX, eyeY, 10, 10);
        SplashKit.FillRectangle(MainColor, rightX, eyeY, 10, 10);
        SplashKit.FillRectangle(MainColor, leftX, mouthY, 25, 10);
        SplashKit.FillRectangle(MainColor, leftX + 2, mouthY + 2, 21, 6);

    }
}

public class Roundy : Robot
{
    public Roundy(Window gameWindow, Player player) : base(gameWindow, player)
    {
        ;
    }
    public override void Draw()
    {

       
        double rightX; rightX = X + 33;
        double leftX; leftX = X + 17;
        double midX; midX = X + 25;
        double eyeY; eyeY = Y + 20;
        double midY; midY = X + 25;
        double mouthY; mouthY = Y + 35;

       
        SplashKit.FillCircle(MainColor, leftX, eyeY, 5);
        SplashKit.FillCircle(MainColor, rightX, eyeY, 5);
        SplashKit.FillEllipse(Color.Gray, X, eyeY, 50, 30);
        SplashKit.DrawLine(Color.Black, X, mouthY, X + 50, Y + 35);

    }
}

public class frag : Robot
{
    public frag(Window gameWindow, Player player) : base(gameWindow,player)
    {
        ;
    }
    public override void Draw()
    {

        
        
        double rightX; rightX=X+12;
        double leftX; leftX= X + 10;
        double eyeY; eyeY = Y + 8;
        double mouthY; mouthY = Y + 14;

     
        SplashKit.FillRectangle(Color.Black, X, Y, 25, 25);
        SplashKit.FillRectangle(MainColor, leftX, eyeY, 10, 10);
        SplashKit.FillRectangle(MainColor, rightX, eyeY, 10, 10);
        SplashKit.FillRectangle(MainColor, leftX, mouthY, 25, 10);
        SplashKit.FillRectangle(MainColor, leftX+2, mouthY+2, 21, 6);
        
    }
}
