using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Calculatrice2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        List<string> elements = new List<string>();
        bool isResult = false;

        private ObservableCollection<Historique> _historiques;

        public ObservableCollection<Historique> Historiques
        {
            get
            {
                if (_historiques == null) _historiques = new ObservableCollection<Historique>();
                return _historiques;
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private Dictionary<string, object> _propertyValues = new Dictionary<string, object>();

        public T GetValue<T>([CallerMemberName] string propertyName = null)
        {
            if (_propertyValues.ContainsKey(propertyName))
                return (T)_propertyValues[propertyName];
            return default(T);
        }
        public bool SetValue<T>(T newValue, [CallerMemberName] string propertyName = null)
        {
            var currentValue = GetValue<T>(propertyName);
            if (currentValue == null && newValue != null
             || currentValue != null && !currentValue.Equals(newValue))
            {
                _propertyValues[propertyName] = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }

        #endregion

        public string Result
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private string Traitement_calcul()
        {
            char[] parts = Result.ToCharArray();

            double result = 0.0;
            int y = 1;

            for (int i = 0; i < parts.Length; i+=y)
            {
                y = 0;
                if (Char.IsDigit(parts[i]))
                {
                    List<char> d = new List<char>();

                    while ((i+y < parts.Length && Char.IsDigit(parts[i+y])) || (i + y < parts.Length && parts[i + y] == '.'))
                    {
                        d.Add(parts[i+y]);
                        y++;
                    }
                    string number = new String(d.ToArray());
                    elements.Add(number);
                }
                else
                {
                    elements.Add(parts[i].ToString());
                    y = 1;
                }
            }

            Calcul clcRes = new Calcul();
            result = clcRes.Start(elements);

            resultHistorique(DisplaySpace(result), Result);
            return DisplaySpace(result);
        }

        public void resultHistorique(string res, string calc)
        {
            Historique histo = new Historique();
            histo.CalculHisto = calc;
            histo.ResultatHisto = res;
            this.Historiques.Add(histo);
        }

        public void resultClear()
        {
            if (isResult == true)
            {
                Result="";
                elements.Clear();
                isResult = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result = Traitement_calcul();
            isResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "+";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "0";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "*";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "/";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += ".";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "-";
        }

        private void Correct_Click(object sender, RoutedEventArgs e)
        {
            Result = "";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "(";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += ")";
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "^";
        }

        private void Calcul_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.NumPad0:
                    resultClear();
                    Result += '0';
                    break;
                case Key.NumPad1:
                    resultClear();
                    Result += '1';
                    break;
                case Key.NumPad2:
                    resultClear();
                    Result += '2';
                    break;
                case Key.NumPad3:
                    resultClear();
                    Result += '3';
                    break;
                case Key.NumPad4:
                    resultClear();
                    Result += '4';
                    break;
                case Key.NumPad5:
                    resultClear();
                    Result += '5';
                    break;
                case Key.NumPad6:
                    resultClear();
                    Result += '6';
                    break;
                case Key.NumPad7:
                    resultClear();
                    Result += '7';
                    break;
                case Key.NumPad8:
                    resultClear();
                    Result += '8';
                    break;
                case Key.NumPad9:
                    resultClear();
                    Result += '9';
                    break;
                case Key.Add:
                    resultClear();
                    Result += '+';
                    break;
                case Key.Multiply:
                    resultClear();
                    Result += '*';
                    break;
                case Key.Divide:
                    resultClear();
                    Result += '/';
                    break;
                case Key.D5:
                    resultClear();
                    Result += '(';
                    break;
                case Key.OemOpenBrackets:
                    resultClear();
                    Result += ')';
                    break;
                case Key.OemMinus:
                    resultClear();
                    Result += '-';
                    break;
                case Key.OemPeriod:
                    resultClear();
                    Result += '.';
                    break;
                case Key.Oem6:
                    resultClear();
                    Result += '^';
                    break;
                case Key.Enter:
                    Result = Traitement_calcul();
                    isResult = true;
                    break;
                case Key.Delete:
                    Result = "";
                    break;
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            resultClear();
            Result += "√";
        }

        private string DisplaySpace(double d)
        {
            var f = new NumberFormatInfo { NumberGroupSeparator = " " };
            return d.ToString("n", f);
        }
    }
}
