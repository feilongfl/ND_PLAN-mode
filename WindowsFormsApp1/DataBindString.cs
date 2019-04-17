using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataBindString : INotifyPropertyChanged
    {
        private string _DataValue = string.Empty;

        public string DataValue
        {
            get { return _DataValue; }
            set
            {
                if (string.IsNullOrEmpty(value) && value == _DataValue)
                    return;

                _DataValue = value;
                NotifyPropertyChanged(() => DataValue);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged<T>(Expression<Func<T>> property)
        {
            if (PropertyChanged == null)
                return;

            var memberExpression = property.Body as MemberExpression;
            if (memberExpression == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
        }

        /// <summary>
        /// bind editor to label
        /// </summary>
        /// <param name="textEditor"></param>
        /// <param name="textLabel"></param>
        public void Bind(TextBox textEditor, Label textLabel)
        {
            textEditor.DataBindings.Add("Text", this, "DataValue", false, DataSourceUpdateMode.OnPropertyChanged);
            textLabel.DataBindings.Add("Text", this, "DataValue", false, DataSourceUpdateMode.Never);
        }

        public DataBindString(String str)
        {
            DataValue = str;
        }
    }
}
