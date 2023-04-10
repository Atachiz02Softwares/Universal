using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void pick_Click(object sender, RoutedEventArgs e)
        {
            // Randomized array of integers between 1 and 60
            Random random = new Random();
            int[] sequence = new int[60];

            for (int i = 1; i <= sequence.Length; i++) sequence[i - 1] = i;
            for (int j = 0; j < sequence.Length; j++)
            {
                int k = random.Next() % sequence.Length;
                int l = sequence[j];
                sequence[j] = k;
                sequence[k] = l;
            }

            // Note: a Label is called TextBlock in UWP apps
            // Insert statements to assign six array element values to the <TextBlock> components
            one.Text = sequence[1].ToString();
            two.Text = sequence[2].ToString();
            three.Text = sequence[3].ToString();
            four.Text = sequence[4].ToString();
            five.Text = sequence[5].ToString();
            six.Text = sequence[6].ToString();

            // Button active states
            pick.IsEnabled = false;
            reset.IsEnabled = true;
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            // Reset TextBoxes to default text: "..."
            one.Text = "...";
            two.Text = "...";
            three.Text = "...";
            four.Text = "...";
            five.Text = "...";
            six.Text = "...";

            // Button active states
            pick.IsEnabled = true;
            reset.IsEnabled = false;
        }
    }
}
