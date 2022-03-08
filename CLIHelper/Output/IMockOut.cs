namespace CLIHelper;

public interface IMockOut 
	: IOutput
{
	string OutText { get; }

	string[] Lines { get; }
}