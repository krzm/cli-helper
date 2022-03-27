using DIHelper.MicrosoftDI;
using Microsoft.Extensions.DependencyInjection;

namespace CLIHelper.MDI;

public class AppOutput 
	: MDIDependencySet
{
	public AppOutput(
		IServiceCollection container)
		: base(container)
	{
	}

	public override void Register()
	{
		Container
			.AddSingleton<IOutput, ConsoleOut>();
	}
}