using System.Text;

namespace CLIHelper;

public class OutputLog
	: IOutputLog
{
	public StringBuilder StringBuilder { get; }

    public OutputLog() => 
        StringBuilder = new StringBuilder();

    public void Write(string? text) =>
        StringBuilder.Append(text);

    public void WriteLine(string? text) =>
        StringBuilder.AppendLine(text);

    public void Clear() => 
        StringBuilder.Clear();

    public void Log(string? text) =>
        StringBuilder.AppendLine($"--> {text}");
}