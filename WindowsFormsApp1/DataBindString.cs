using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataBindString : INotifyPropertyChanged
    {
        private string _theValue = string.Empty;

        public string TheValue
        {
            get { return _theValue; }
            set
            {
                if (string.IsNullOrEmpty(value) && value == _theValue)
                    return;

                _theValue = value;
                NotifyPropertyChanged(() => TheValue);
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

        public void Bind(TextBox textEditor, Label textLabel)
        {
            textEditor.DataBindings.Add("Text", this, "TheValue", false, DataSourceUpdateMode.OnPropertyChanged);
            textLabel.DataBindings.Add("Text", this, "TheValue", false, DataSourceUpdateMode.Never);
        }

        public DataBindString(String str)
        {
            TheValue = str;
        }
    }
}
