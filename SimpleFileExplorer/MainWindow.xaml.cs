using SimpleFileExplorer.Models;
using System.IO;
using System.Linq;

namespace SimpleFileExplorer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDataContext();
        }

        private void InitializeDataContext()
        {
            //string stra = this.GetType().Assembly.Location;
            var fileTreeRoot = new TreeNode<FileInformation>(@"C:\Users\liwe\Desktop\Programming\SimpleFileExplorer_OK\SimpleFileExplorer - Answer\SimpleFileExplorer - Question");
        

           
            /*
             * TIP: You can configure "fileTreeRoot" instance here.
             * Directory.GetDirectories(path)
             * Directory.GetFiles(path)
             */
             
            DataContext = new MainWindowViewModel(fileTreeRoot);
        }

      
    
    }
}
