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
		RegisterOutput();
		RegisterColumnCalculators();
		RegisterTableProviders();
	}

	private void RegisterOutput()
	{
		Container
			.AddSingleton<IOutput, ConsoleOut>();
	}

	protected virtual void RegisterColumnCalculators() { }

	protected virtual void RegisterTableProviders() { }
}