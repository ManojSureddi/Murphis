using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;


namespace Murphis_Personal_Assistant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainClose_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("close clicked");
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            BackgroundWorker bg = new BackgroundWorker() ;
            bg.WorkerReportsProgress = true;
            bg.DoWork += Bg_DoWork;
            bg.ProgressChanged += Bg_ProgressChanged;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            bg.RunWorkerAsync();
        }
        MurphisMain murph = null;
        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            if (murph == null) {
                murph = new MurphisMain();
            }
            murph.Show();
            this.Close();
        }

        private void Bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            inLoading.Value = e.ProgressPercentage;
        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(200);
            }

        }

    }
}
