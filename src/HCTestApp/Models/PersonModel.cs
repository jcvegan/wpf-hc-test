using Prism.Mvvm;
using System;
using System.ComponentModel;

namespace HCTestApp.Models
{
    public class PersonModel : BindableBase, IEditableObject
    {
        private bool _isEdting = false;
        private PersonModel _backup = null;

        private string firsName;
        private string lastName;
        private DateTime birthDate;

        public string FirstName
        {
            get => firsName;
            set => SetProperty(ref firsName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set => SetProperty(ref birthDate, value);
        }

        public void BeginEdit()
        {
            _isEdting = true;

            _backup = new PersonModel()
            {
                FirstName = this.firsName,
                LastName = this.lastName,
                BirthDate = this.birthDate
            };
        }

        public void CancelEdit()
        {
            FirstName = _backup.FirstName;
            LastName = _backup.LastName;
            birthDate = _backup.BirthDate;
            _isEdting = false;
            _backup = null;
        }

        public void EndEdit()
        {
            _isEdting = false;
            _backup = null;
        }
    }
}
