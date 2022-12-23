using System.Text.RegularExpressions;

using Exceptions;
using Configs;
using System.Text;

namespace LocalClasses
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string? _email = null;
        private DateTime? _birthDate = null;
        private DateTime _registrationDate;
        private string _login;

        public User(string login, string firstName, string lastName)
        {
            Fill(login, firstName, lastName, null, null);
        }

        public User(string login, string firstName, string lastName, string? email, DateTime? birthDate)
        {
            Fill(login, firstName, lastName, email, birthDate);
        }

        private void Fill(string login, string firstName, string lastName, string? email, DateTime? birthDate)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            RegistrationDate = DateTime.Now;
        }

        public void FillFromString(string str)
        {
            string[] splited = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (splited.Length != 5)
            {
                throw new UserException("String can contain only 5 elements or maybe invalid format (login, firstname, lastname, email, birthdate)!");
            }

            Login = splited[0].Trim();
            FirstName = splited[1].Trim();
            LastName = splited[2].Trim();

            Email = (splited[3] == " ") ? null : splited[3].Trim();

            if (splited[4] == " ")
            {
                BirthDate = null;
            }
            else
            {
                if (DateTime.TryParse(splited[4].Trim(), out DateTime date))
                {
                    BirthDate = date;
                }
                else
                {
                    throw new UserException("Wrong birthdate format!");
                }
            }
        }

        public override string ToString()
        {
            if (BirthDate is not null)
            {
                return $"{Login}, {FirstName}, {LastName}, {Email}, {BirthDate.Value.ToString("dd-MM-yyyy")}";
            }
            else
            {
                return $"{Login}, {FirstName}, {LastName}, {Email}, {BirthDate}";
            }
        }

        public string FirstName
        {
            set
            {
                if ((value.Length <= UserConfig.FirstNameLength) && Regex.IsMatch(value, UserConfig.FirstNamePattern))
                {
                    _firstName = value;
                }
                else
                {
                    throw new UserException(UserConfig.ErrorStart + UserConfig.FirstNameFormat);
                }
            }
            get 
            { 
                return _firstName; 
            }
        }

        public string LastName
        {
            set
            {
                if ((value.Length <= UserConfig.LastNameLength) && Regex.IsMatch(value, UserConfig.LastNamePattern))
                {
                    _lastName = value;
                }
                else
                {
                    throw new UserException(UserConfig.ErrorStart + UserConfig.LastNameFormat);
                }
            }
            get
            {
                return _lastName;
            }
        }
        public string? Email
        {
            set
            {
                if (value is null)
                {
                    _email = null;
                    return;
                }

                if (Regex.IsMatch(value, UserConfig.EmailPattern))
                {
                    _email = value;
                }
                else
                {
                    throw new UserException(UserConfig.ErrorStart + UserConfig.EmailFormat);
                }
            }
            get
            {
                return _email;
            }
        }

        public string Login
        {
            set
            {
                if ((value.Length <= UserConfig.LoginLength) && Regex.IsMatch(value, UserConfig.LoginPattern))
                {
                    _login = value;
                }
                else
                {
                    throw new UserException(UserConfig.ErrorStart + UserConfig.LoginFormat);
                }
            }
            get
            {
                return _login;
            }
        }
        public DateTime? BirthDate
        {
            set
            {
                if (value is null)
                {
                    _birthDate = null;
                    return;
                }

                if ((value > DateTime.Now))
                {
                    throw new UserException(UserConfig.ErrorStart + UserConfig.BirthFormat);
                }
                else
                {
                    _birthDate = value;
                }
            }
            get
            {
                return _birthDate;
            }
        }

        public DateTime RegistrationDate
        {
            set
            {
                _registrationDate = value;
            }
            get
            {
                return _registrationDate;
            }
        }
    }
}
