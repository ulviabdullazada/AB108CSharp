namespace AccessModifiers.Models
{
    class Human
    {
        string _surname;
        private int _age;
        private string _name;
        public string Name { 
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 3 || value.Length > 12)
                    return;
                _name = value;
            }
        }
        //public int Abc;
        private int _sifirOlmaz;
        public int Abc { 
            get 
            { 
                return _sifirOlmaz; 
            } 
            set 
            { 
                if (value % 2 == 0) _sifirOlmaz = value; 
            } 
        }
        //private string _fatherName;

        //public string FatherName
        //{
        //    get { return _fatherName; }
        //    set { _fatherName = value; }
        //}


        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetSurname(string surname)
        //{
        //    if (surname.Length < 3 || surname.Length > 16)
        //        return;
        //    _surname = surname;
        //}
        //public Human(string name)
        //{
        //    SetName(name);
        //}
        //public int GetAge()
        //{
        //    return _age;
        //}
        //public void SetAge(int age)
        //{
        //    if (age < 0 || age > 200)
        //        return;
        //    _age = age;
        //}
        //public void SetName(string name)
        //{
        //    if (name.Length < 3 || name.Length > 12)
        //        return;
        //    _name = name;
        //}

        //public string GetSurname()
        //{
        //    return _surname;
        //}

    }
}
