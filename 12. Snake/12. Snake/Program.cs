using Raylib_CsLo;

public static class Program
{
    public static Task Main(string[] args)
    {
        // 1. Initialize and create the Window
        Raylib.InitWindow(800, 500, "Snake");

        // 2. Limit FPS
        Raylib.SetTargetFPS(60);

        //------------------------------------------------------------------------------------
        // Global Variables Declaration
        //------------------------------------------------------------------------------------
         int snakeX = 400;
         int snakeY = 250;


        int gridCols = 40;
        int gridRows = 30;
        int cellWidth = 800 / gridCols;
        int cellHeight = 600 / gridRows;



        // Game Loop
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib.LIGHTGRAY);

            for (int i = 0; i <= gridCols; i++)
            {
                Raylib.DrawLine(i * cellWidth, 0, i * cellWidth, 500, Raylib.GRAY);
            }

            for (int j = 0; j <= gridRows; j++)
            {
                Raylib.DrawLine(0, j * cellHeight, 800, j * cellHeight, Raylib.GRAY);
            }


            Raylib.DrawRectangle(snakeX, snakeY, 20, 20, Raylib.GREEN); // Snake

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                snakeX += 10;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                snakeX -= 10;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                snakeY -= 10;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                snakeY += 10;
            }

            Raylib.EndDrawing();
        } 
        
        

        Raylib.CloseWindow();
        return Task.CompletedTask;
    }
    
}