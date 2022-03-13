namespace CLIHelper;

public class ConsoleOutMock 
    : OutMock
    , IOutput
{
    public void Write(string? text) =>
        Buffer.Append(text);

    public void WriteLine(string? text) =>
        Buffer.AppendLine(text);

    public void Clear() => 
        Buffer.Clear();

    public void Log(string? text) =>
        Buffer.AppendLine($"--> {text}");
}