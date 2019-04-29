using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace YourDay.MClass
{
    public partial class MVModel
    {
        public ICommand CloseCommand { protected set; get; }
        public ICommand FirstCommand { protected set; get; }
        public ICommand SecondCommand { protected set; get; }
        public ICommand ThirdCommand { protected set; get; }
        public ICommand FourthCommand { protected set; get; }
        public ICommand FifthCommand { protected set; get; }
        public ICommand SixthCommand { protected set; get; }
        public ICommand SeventhCommand { protected set; get; }
        public ICommand EightCommand { protected set; get; }
        public ICommand NinethCommand { protected set; get; }
        public ICommand TenthCommand { protected set; get; }

        protected internal delegate void FirstCommandMeth();
        protected internal FirstCommandMeth MethodForFirstCommand { get; set; }

        protected internal delegate void SecondCommandMeth();
        protected internal SecondCommandMeth MethodForSecondCommand { get; set; }

        protected internal delegate void ThirdCommandMeth();
        protected internal ThirdCommandMeth MethodForThirdCommand { get; set; }

        protected internal delegate void FourthCommandMeth();
        protected internal FourthCommandMeth MethodForFourthCommand { get; set; }

        protected internal delegate void FifthCommandMeth();
        protected internal FifthCommandMeth MethodForFifthCommand { get; set; }

        protected internal delegate void SixthCommandMeth();
        protected internal SixthCommandMeth MethodForSixthCommand { get; set; }

        protected internal delegate void SeventhCommandMeth();
        protected internal SeventhCommandMeth MethodForSeventhCommand { get; set; }

        protected internal delegate void EightCommandMeth();
        protected internal EightCommandMeth MethodForEightCommand { get; set; }

        protected internal delegate void NinethCommandMeth();
        protected internal NinethCommandMeth MethodForNinethCommand { get; set; }

        protected internal delegate void TenthCommandMeth();
        protected internal TenthCommandMeth MethodForTenthCommand { get; set; }


    }
}
