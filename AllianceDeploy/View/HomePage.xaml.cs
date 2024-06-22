namespace AllianceDeploy.View;

public partial class HomePage : ContentPage
{
	string nombreemp ="Juan Medina SRL";
	
	public HomePage()
	{
		InitializeComponent();
		NSistema.Text = nombreemp.ToUpper();
        
    }
}