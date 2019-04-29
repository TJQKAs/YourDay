using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace YourDay.MClass
{
    public partial class MVModel
    {
        protected internal bool DebugMode { get; set; }

        private DateTime _first_DateTime;

        protected internal DateTime FirstDateTime
        {
            get { return _first_DateTime; }
            set
            {
                _first_DateTime = value;
                OnPropertyChanged(nameof(FirstDateTime));
            }
        }

        private DateTime _second_DateTime;

        protected internal DateTime SecondDateTime
        {
            get { return _second_DateTime; }
            set
            {
                _second_DateTime = value;
                OnPropertyChanged(nameof(SecondDateTime));
            }
        }


        private DateTime _third_DateTime;

        protected internal DateTime ThirdDateTime
        {
            get { return _third_DateTime; }
            set
            {
                _third_DateTime = value;
                OnPropertyChanged(nameof(ThirdDateTime));
            }
        }


        private string _first_string;
        /// <summary>
        /// FirstString - Path to folder where the error files were stored
        /// </summary>
        protected internal string FirstString
        {
            get { return _first_string; }
            set
            {
                _first_string = value;
                OnPropertyChanged(nameof(FirstString));
            }
        }


        private string _second_string;
        /// <summary>
        /// SecondString - Extension of error file  f.e. "*.txt"
        /// </summary>
        protected internal string SecondString
        {
            get { return _second_string; }
            set
            {
                _second_string = value;
                OnPropertyChanged(nameof(SecondString));
            }
        }



        private string _third_string;

        protected internal string ThirdString
        {
            get { return _third_string; }
            set
            {
                _third_string = value;
                OnPropertyChanged(nameof(ThirdString));
            }
        }

        private string _fourth_string;

        protected internal string FourthString
        {
            get { return _fourth_string; }
            set
            {
                _fourth_string = value;
                OnPropertyChanged(nameof(FourthString));
            }
        }



        private string _fifth_string;

        protected internal string FifthString
        {
            get { return _fifth_string; }
            set
            {
                _fifth_string = value;
                OnPropertyChanged(nameof(FifthString));
            }
        }



        private string _sixth_string;

        protected internal string SixthString
        {
            get { return _sixth_string; }
            set
            {
                _sixth_string = value;
                OnPropertyChanged(nameof(SixthString));
            }
        }


        private string _seventh_string;

        protected internal string SeventhString
        {
            get { return _seventh_string; }
            set
            {
                _seventh_string = value;
                OnPropertyChanged(nameof(SeventhString));
            }
        }

        private int _first_int;
        /// <summary>
        /// Firstint -   Macchina id
        /// </summary>
        protected internal int Firstint
        {
            get { return _first_int; }
            set
            {
                _first_int = value;
                OnPropertyChanged(nameof(Firstint));
            }
        }


        private int _second_int;

        protected internal int Secondint
        {
            get { return _second_int; }
            set
            {
                _second_int = value;
                OnPropertyChanged(nameof(Secondint));
            }
        }

        private int _third_int;

        protected internal int Thirdint
        {
            get { return _third_int; }
            set
            {
                _third_int = value;
                OnPropertyChanged(nameof(Thirdint));
            }
        }

        private int _fourth_int;

        protected internal int Fourthint
        {
            get { return _fourth_int; }
            set
            {
                _fourth_int = value;
                OnPropertyChanged(nameof(Fourthint));
            }
        }


        private int _fifth_int;

        protected internal int Fifthint
        {
            get { return _fifth_int; }
            set
            {
                _fifth_int = value;
                OnPropertyChanged(nameof(Fifthint));
            }
        }

        private int _sixth_int;

        protected internal int Sixthint
        {
            get { return _sixth_int; }
            set
            {
                _sixth_int = value;
                OnPropertyChanged(nameof(Sixthint));
            }
        }


        private int _seventh_int;

        protected internal int Seventhint
        {
            get { return _seventh_int; }
            set
            {
                _seventh_int = value;
                OnPropertyChanged(nameof(Seventhint));
            }
        }


        private int _eight_int;

        protected internal int Eightint
        {
            get { return _eight_int; }
            set
            {
                _eight_int = value;
                OnPropertyChanged(nameof(Eightint));
            }
        }

        private int _nine_int;

        protected internal int Nineint
        {
            get { return _nine_int; }
            set
            {
                _nine_int = value;
                OnPropertyChanged(nameof(Nineint));
            }
        }

        private int _ten_int;

        protected internal int Ten_int
        {
            get { return _ten_int; }
            set
            {
                _ten_int = value;
                OnPropertyChanged(nameof(Ten_int));
            }
        }

        private int _eleven_int;

        protected internal int Eleven_int
        {
            get { return _eleven_int; }
            set
            {
                _eleven_int = value;
                OnPropertyChanged(nameof(Eleven_int));
            }
        }


        private bool _show_errors;

        protected internal bool ShowErrors
        {
            get { return _show_errors; }
            set
            {
                _show_errors = value;
                OnPropertyChanged(nameof(ShowErrors));
            }
        }

        private bool _first_bool;

        protected internal bool FirstBool
        {
            get { return _first_bool; }
            set
            {
                _first_bool = value;
                OnPropertyChanged(nameof(FirstBool));
            }
        }


        private List<string> _first_string_list;
        protected internal List<string> FirstStringList
        {
            get { return _first_string_list; }
            set
            {
                _first_string_list = value;
                OnPropertyChanged(nameof(FirstStringList));
            }
        }
        private ObservableCollection<string> _first_string_coll;

        protected internal ObservableCollection<string> FirstStringColl
        {
            get { return _first_string_coll; }
            set
            {
                _first_string_coll = value;
                OnPropertyChanged(nameof(FirstStringColl));
            }
        }
        private ObservableCollection<string> _second_string_coll;

        protected internal ObservableCollection<string> SecondStringColl
        {
            get { return _second_string_coll; }
            set
            {
                _second_string_coll = value;
                OnPropertyChanged(nameof(SecondStringColl));
            }
        }
        protected internal void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
