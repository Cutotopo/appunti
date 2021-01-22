using metro = Elysium.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using System.Runtime.InteropServices;
using System.Diagnostics;

/// <summary>
/// Appunti
/// App di Cutotopo
/// 
/// github.com/Cutotopo/appunti
/// Licenza MIT
/// </summary>



namespace APPUNTI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : metro::Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (TextPanel.Text != "")
            {
                if (pathnamebox.Text == "")
                {
                    MessageBoxResult result = MessageBox.Show("Salvare il contenuto su un file?", "Warning", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Cancel)
                    {
                        e.Cancel = true;
                        
                    }
                    if (result == MessageBoxResult.Yes)
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "File appunti|*.fnotes";
                        string Text = TextPanel.Text;
                        if (saveFileDialog1.ShowDialog() == true)
                        {
                            TextWriter tw = new StreamWriter(saveFileDialog1.FileName);
                            tw.Write(Text);
                            tw.Close();
                        }
                        PathName.Content = saveFileDialog1.FileName;
                        pathnamebox.Text = saveFileDialog1.FileName;
                        AutoSaveStatusBool.Content = "Sì";
                    }
                    if (result == MessageBoxResult.No)
                    {
                        System.Windows.Application.Current.Shutdown();
                    }
                }
            }
        }

        private void TestoCambiato(object sender, RoutedEventArgs e)
        {
            string text2 = " ";
            text2 = TextPanel.Text;
            int textLength = text2.Length;
            /// - - - Metodo alternativo di conteggio delle lettere - - -
            ///text2.Count(char.IsLetter);
            ///text2.Split(' ').ToDictionary(n => n, n => n.Length);
            ///text2.Split(' ');
            ///int text3 = 0;
            ///text2.Split(' ').Select(n => new KeyValuePair<string, int>(n, n.Length));
            ///text3 = text2.Length;
            ///string Text4 = Convert.ToString(text3);
            charNum.Content = textLength;
            string TextWrt = TextPanel.Text;
            if ((pathnamebox.Text == ""))
            {

            } else
            {
                string PathName2 = Convert.ToString(pathnamebox.Text);
                TextWriter tw = new StreamWriter(PathName2);
                tw.Write(TextWrt);
                tw.Close();

            }
        }

        private void TopMostTrue(object sender, RoutedEventArgs e)
        { 
            if (this.Topmost == true)
            {
                this.Topmost = false;
                TopMostBtn.Content = "Mantieni in primo piano (disattivato)";
            }
            else
            {
                this.Topmost = true;
                TopMostBtn.Content = "Mantieni in primo piano (attivato)";
            }
        }

        private void ExportFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File appunti|*.fnotes";
            string Text = TextPanel.Text;
            if (saveFileDialog1.ShowDialog() == true)
            {
                TextWriter tw = new StreamWriter(saveFileDialog1.FileName);
                tw.Write(Text);
                tw.Close();
            }
            PathName.Content = saveFileDialog1.FileName;
            pathnamebox.Text = saveFileDialog1.FileName;
            AutoSaveStatusBool.Content = "Sì";
        }
        private void ImportFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File appunti|*.fnotes";
            if (openFileDialog1.ShowDialog() == true)
            {
                TextReader tr = new StreamReader(openFileDialog1.FileName);
                string textR = tr.ReadToEnd();
                string text1 = Convert.ToString(textR);
                TextPanel.Text = textR;

            }
            PathName.Content = openFileDialog1.FileName;
            pathnamebox.Text = openFileDialog1.FileName;
            AutoSaveStatusBool.Content = "Sì";
        }

        private void ViewGit(object sender, RoutedEventArgs e)
        {
            string giturl = "https://github.com/CUtotopo/appunti";
            LaunchGit(giturl);
        }
        private void LaunchGit(string giturl)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Cutotopo/appunti");
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    giturl = giturl.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {giturl}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", giturl);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", giturl);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
