using Raylib_CsLo;
public static class Program
{
    public static Task Main(string[] args)
    {
        Raylib.InitWindow(800, 600, "Snake");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Raylib.LIGHTGRAY);
            
            Raylib.DrawText("Bienvenue sur ce jeu de snake !", 10, 10, 20, Raylib.BLACK);

            Raylib.EndDrawing();
        }
        

        Raylib.CloseWindow();
        return Task.CompletedTask;
    }
    
}