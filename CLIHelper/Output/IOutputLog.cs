using System.Text;

namespace CLIHelper;

public interface IOutputLog : IOutput
{
	StringBuilder StringBuilder { get; } 
}