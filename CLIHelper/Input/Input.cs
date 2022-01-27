namespace CLIHelper;

#nullable enable
public class Input : IInput
{
	public string? ReadLine() =>
		Console.ReadLine();
}