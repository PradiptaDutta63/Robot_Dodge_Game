using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window mainWindow = new Window ("RobotDodge", 800, 800);
        RobotDodge robotDodge = new RobotDodge(mainWindow);
        while (! mainWindow.CloseRequested && !robotDodge.Quit)
        {
            robotDodge.HandleInput();
            robotDodge.Update();

            mainWindow.Clear(Color.White);
            robotDodge.Draw();
            mainWindow.Refresh(60);
        }
        mainWindow.Close();
        
    }
}
