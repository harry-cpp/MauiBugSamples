namespace iOSBuggedTitle;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("SubPage", typeof(SubPage));
    }
}

