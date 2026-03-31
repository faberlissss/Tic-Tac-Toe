string[,] gameBoard = new string[3, 3];

int count = 1;

for (int r = 0; r < gameBoard.GetLength(0); r++)
{
    Console.WriteLine("----------- ");

    for (int c = 0; c < gameBoard.GetLength(1); c++)
    {
        gameBoard[r, c] = count.ToString();
        count++;
        Console.Write(gameBoard[r,c] + " | ");
    }
    Console.WriteLine();
}

/////////////////////

for (int userTurn = 0; userTurn < gameBoard.Length; userTurn++)
{
    string player;
    
    if (userTurn % 2 == 0)
    {
        player = "X";
    }
    else
    {
        player = "O";
    }
    
    Console.Write($" {player}  Введiть своє число ходу: ");
    string? userNumMove = Console.ReadLine();

    for (int r = 0; r < gameBoard.GetLength(0); r++)
    {
        for (int c = 0; c < gameBoard.GetLength(1); c++)
        {
            
            if (gameBoard[r, c] == userNumMove)
            {
                gameBoard[r, c] = player;
            }
            
        }
        
    }
    for (int r = 0; r < gameBoard.GetLength(0); r++)
    {
        Console.WriteLine("----------- ");

        for (int c = 0; c < gameBoard.GetLength(1); c++)
        {
            Console.Write(gameBoard[r,c] + " | ");
        }
        Console.WriteLine();
    }
     
    bool win = false;
    
    for (int r = 0; r < gameBoard.GetLength(0); r++)
    {
        bool winR = true;
        bool winC = true;

        for (int c = 0; c < gameBoard.GetLength(1); c++)
        {
            if (gameBoard[r, c] != player)
            {
                winR = false;
            }
            if (gameBoard[c, r] != player)
            {
                winC = false;
            }
            
        }
        if (winR || winC)
        {
            win = true;
            break;
        }
        
    }
    
    bool winD1 = gameBoard[0, 0] == player && gameBoard[1, 1] == player && gameBoard[2, 2] == player;
    bool winD2 = gameBoard[0, 2] == player && gameBoard[1, 1] == player && gameBoard[2, 0] == player;

    if (winD1 || winD2)
    {
        win = true;
    }
    
    if (win)
    {
        Console.Write($"Перемога гравця {player}!");
        break;
    }
    
}






 

 

 
