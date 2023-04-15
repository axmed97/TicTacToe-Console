string[,] gameBoard =
{
    {"-", "-", "-" },
    {"-", "-", "-" },
    {"-", "-", "-" },
};

bool players = true;
int coordinateX = 0, coordinateY = 0;

Start:
string card = players ? "X" : "O";


for (int i = 0; i < gameBoard.GetLength(0); i++)
{
    for (int j = 0; j < gameBoard.GetLength(1); j++)
    {
        Console.Write(gameBoard[i, j]);
    }
    Console.WriteLine("");
}

if (WinGame(gameBoard, card))
{
    Console.WriteLine("Siz qalibsiniz!!!");
    return;
}
else
{
    Console.Write("Enter X coordinate: ");
     coordinateX = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Y coordinate: ");
     coordinateY = Convert.ToInt32(Console.ReadLine());

}


/*
 
    true == x
    false == y
 
 */
// Ternary operator
if (!CheckGame(gameBoard, coordinateX, coordinateY))
{
    Console.WriteLine("Agziva geleni yazma Yuska");
    goto Start;
}


gameBoard[coordinateX, coordinateY] = card;

players = !players;
goto Start;



bool CheckGame(string[,] board, int x, int y)
{
    if (board[x, y].Contains("-"))
    {
        return true;
    }
    return false;
}

bool WinGame(string[,] board, string symbol)
{
    if (board[0,0].Contains(symbol) && board[0,1].Contains(symbol) && board[0, 2].Contains(symbol))
    {
        return true;
    }
    return false;
}
