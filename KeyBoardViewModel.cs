namespace WpfKeyboardEnterStyle
{
    public class KeyBoardViewModel : ViewModelBase
    {
        private string _input;

        private DelegateCommand _keyPressed;

        private KeyBoardModel _model;

        public KeyBoardViewModel(KeyBoardModel model)
        {
            _model = model;
        }

        public string Input
        {
            get
            {
                return _input;
            }
            set
            {
                _input = value;
                OnPropertyChanged();
            }
        }

        public DelegateCommand KeyPressed
        {
            get
            {
                if (_keyPressed == null)
                    _keyPressed = new DelegateCommand(OnKeyPressed);
                return _keyPressed;
            }
        }

        private void OnKeyPressed(object obj)
        {
            if (obj == null) return;
            Input += obj.ToString();
        }
    }
}