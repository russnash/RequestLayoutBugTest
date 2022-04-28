namespace RequestLayoutBugTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		// Create enough labels to make the view scrollable, thus showing the performance degradation
		CreateLabels();
	}

	private void CreateLabels()
    {
		for(int i = 0; i < 50; i++)
        {
			Label label = new Label();
			label.Text = i.ToString();
			layout.Add(label);
        }
    }
}

