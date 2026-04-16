using System.Windows;
using System.Windows.Controls;

namespace WpfSet;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    /// NOTE: Alternative if you wish, my child
    //List<List<string>> clubOfIdiots = new List<List<string>>()
    //{
    //    new List<string> { "Աննա", "Մոնիկա", "Դավիթ" },
    //    new List<string> { "Մոնիկա", "Սառա", "Դավիթ", "Էրիկ", "Կարեն" }
    //};

    // Տվյալների բառարանը
    Dictionary<string, List<string>> collections = new Dictionary<string, List<string>>()
    {
        { "Reading", new List<string> { "Աննա", "Մոնիկա", "Դավիթ" } },
        { "Writing", new List<string> { "Մոնիկա", "Սառա", "Դավիթ", "Էրիկ", "Կարեն" } }
    };


    /// NOTE: Use the 'SetLib', my child


    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        // Մաքրում ենք հին տարրերը (եթե կան) և լցնում նորերը
        leftSet.Items.Clear();
        rightSet.Items.Clear();
        operation.Items.Clear();

        /// NOTE: Alternative
        //foreach (var key in clubOfIdiots[0])
        //{
        //    leftSet.Items.Add(key);
        //    rightSet.Items.Add(key);
        //}

        foreach (var key in collections.Keys)
        {
            leftSet.Items.Add(key);
            rightSet.Items.Add(key);
        }

        operation.Items.Add("UNION");
        operation.Items.Add("INTERSECTION");
        operation.Items.Add("DIFFERENCE");
        operation.Items.Add("SYMMETRIC DIFFERENCE");

        leftSet.SelectedIndex = 0;
        rightSet.SelectedIndex = 1;
        operation.SelectedIndex = 0;
    }

    private void Set_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (leftSet.SelectedItem != null && leftMembers != null)
        {
            leftMembers.ItemsSource = collections[leftSet.SelectedItem.ToString()];
        }

        if (rightSet.SelectedItem != null && rightMembers != null)
        {
            rightMembers.ItemsSource = collections[rightSet.SelectedItem.ToString()];
        }
    }

    private void evaluateButton_Click(object sender, RoutedEventArgs e)
    {
        if (leftSet.SelectedItem == null || rightSet.SelectedItem == null || operation.SelectedItem == null)
        {
            MessageBox.Show("Խնդրում ենք ընտրել բոլոր դաշտերը:");
            return;
        }

        var set1 = collections[leftSet.SelectedItem.ToString()];
        var set2 = collections[rightSet.SelectedItem.ToString()];

        IEnumerable<string> result = null;
        string selectedOp = operation.SelectedItem.ToString();

        if (selectedOp == "UNION")
        {
            result = set1.Union(set2);
        }
        else if (selectedOp == "INTERSECTION")
        {
            result = set1.Intersect(set2);
        }
        else if (selectedOp == "DIFFERENCE")
        {
            result = set1.Except(set2);
        }
        else if (selectedOp == "SYMMETRIC DIFFERENCE")
        {
            // Սիմետրիկ տարբերություն: (A \ B) ∪ (B \ A)
            var diff1 = set1.Except(set2);
            var diff2 = set2.Except(set1);
            result = diff1.Union(diff2);
        }

        // ԿԱՐԵՎՈՐ: Մաքրում ենք հին ItemsSource-ը, որպեսզի UI-ը թարմանա
        resultSet.ItemsSource = null;
        resultSet.ItemsSource = result?.ToList();
    }
}