using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DuDu.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>

        private string qqShowForFriend;
        public string QQShowForFriend
        {
            get
            {
                return qqShowForFriend;
            }

            set
            {
                Set(ref qqShowForFriend, value);
            }
        }

        private string qqShowForUser;
        public string QQShowForUser
        {
            get
            {
                return qqShowForUser;
            }

            set
            {
                Set(ref qqShowForUser, value);
            }
        }

        private string headPortraitForUser;
        public string HeadPortraitForUser
        {
            get
            {
                return headPortraitForUser;
            }

            set
            {
                Set(ref headPortraitForUser, value);
            }
        }

        private string sendTextInfo;
        public string SendTextInfo
        {
            get { return sendTextInfo; }
            set { Set(ref sendTextInfo, value); }
        }

        public string chattingHistory;
        public string ChattingHistory
        {
            get { return chattingHistory; }
            set { Set(ref chattingHistory, value); }
        }


        ICommand SendCommand;
        ICommand ClearCommand;

        public MainViewModel()
        {
            QQShowForFriend = "Resources/qqShow_friend.jpg.png";
            QQShowForUser = "Resources/qqShow_user.jpg.png";
            HeadPortraitForUser = "Resources/userHeadPortrait.jpg";
            SendCommand = new RelayCommand(OnSend);
            ClearCommand = new RelayCommand(OnClear);
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private void OnSend()
        {

        }

        private void OnClear()
        {

        }

    }
}