namespace _36_ValidSudoku
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}
	}
	public class Solution
	{
		public bool IsValidSudoku(char[][] board)
		{

			Dictionary<int, HashSet<char>> col = new Dictionary<int, HashSet<char>>();
			Dictionary<int, HashSet<char>> row = new Dictionary<int, HashSet<char>>();
			Dictionary<string, HashSet<char>> box = new Dictionary<string, HashSet<char>>(); // Key = (row/3 , col/3)

			for (int r = 0; r < 9; r++)
			{
				for (int c = 0; c < 9; c++)
				{
					if (board[r][c] == '.')
					{
						continue;
					}

					string squarekey = (r / 3) + "," + (c / 3);


					if (row.ContainsKey(r) && row[r].Contains(board[r][c]) ||
						col.ContainsKey(c) && col[c].Contains(board[r][c]) ||
						box.ContainsKey(squarekey) && box[squarekey].Contains(board[r][c]))
					{
						return false;
					}

					if (!row.ContainsKey(r))
					{
						row[r] = new HashSet<char>();
					}

					if (!col.ContainsKey(c))
					{
						col[c] = new HashSet<char>();
					}

					if (!box.ContainsKey(squarekey))
					{
						box[squarekey] = new HashSet<char>();
					}

					row[r].Add(board[r][c]);
					col[c].Add(board[r][c]);
					box[squarekey].Add(board[r][c]);

				}
			}
			return true;
		}

	}
}
