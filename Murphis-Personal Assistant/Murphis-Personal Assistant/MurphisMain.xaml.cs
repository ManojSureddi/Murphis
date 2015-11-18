using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Murphis_Personal_Assistant
{
    /// <summary>
    /// Interaction logic for MurphisMain.xaml
    /// </summary>
    public partial class MurphisMain : Window
    {
        public MurphisMain()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            MurphisSpeechRecognizer recognizer = new MurphisSpeechRecognizer();
        }
    }
}
