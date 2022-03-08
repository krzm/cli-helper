using System.Text;

namespace CLIHelper;

public class MockOut
	: IMockOut
{
	private readonly StringBuilder buffer;

    public string OutText => buffer.ToString();

    public string[] Lines => OutText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

    public MockOut() => 
        buffer = new StringBuilder();

    public void Write(string? text) =>
        buffer.Append(text);

    public void WriteLine(string? text) =>
        buffer.AppendLine(text);

    public void Clear() => 
        buffer.Clear();

    public void Log(string? text) =>
        buffer.AppendLine($"--> {text}");
}