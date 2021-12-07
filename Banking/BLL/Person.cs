using System;

namespace BLL
{
    public class Person
    {
        //etape 1 mettre les champs en private => encapsulation
        //etape 2 créer des getters pour chaque champs
        //etape 3 créer des setters => permettre de modifier le contenu des champs mais en respectant les règles du business
        //propriete automatique  
        private string name;
        public string Name { get => name; set => name = value; } //lambda expression


        //propriete auto-implementée
        public string Firstname { get; set; }

        
        //ecriture d'une propriete
        //pour faire une propriete il faut la variable en private
        //full propertie
        private string email;
        public  string Email
        {
            get
            {
                return email;
            }
            set
            {
                string minuscules = value.ToLower(); //value la valeur par default que je donne 
                email = minuscules; 
            }
        }
        //fin ecriture propriete

        //propfull tabtab  pour les variables d'encapsulation avec m_ c'est mieux
        private Int64 m_IdentificationNumber;

        public string IdentificationNumber
        {
            get { return m_IdentificationNumber.ToString(); }

            set
            {
                //for (int i=0 ; i < value.Length ; i++)
                //{

                //}

                string copyValue = value;
                string cleanValue = string.Empty;

                foreach (char caract in copyValue)
                {
                    if (char.IsDigit(caract))
                        cleanValue += caract;
                }

                if (cleanValue.Length == 11)
                {
                    m_IdentificationNumber = Int64.Parse(cleanValue);
                    Console.WriteLine(cleanValue.Length);
                    //Console.WriteLine($"voici si la date est ok tada ou merde {this.birthDate}");
                }
                else
                    Console.WriteLine("Il y a une erreur coco trop grand !!!!");

                ////// testing last number
                DateTime myDate = new DateTime(1942, 01, 22);
                string stIdentificationNumber = m_IdentificationNumber.ToString();
                int nbLastTwoDigits = int.Parse(stIdentificationNumber.Substring(9, 2));
                string controlNumber = stIdentificationNumber.Substring(0, 9);
                int nbPremier = 97;

                if (myDate.Year > 2000)
                    controlNumber = "2" + controlNumber;

                int nbControlNumber = int.Parse(controlNumber);
                int nbVerified = nbControlNumber % nbPremier;

                if (nbVerified == 0)
                    nbVerified = 97;

                if (nbVerified == nbLastTwoDigits)
                    Console.WriteLine("It's ok baby");
                else
                    Console.WriteLine("There is an error with your Identification Number !!!");
            }
        }

        private string toString(long m_IdentificationNumber)
        {
            throw new NotImplementedException();
        }





        //propriete style java avec geter et seter
        private DateTime birthDate;

        public void SetBirthDate(DateTime pBirthdate)
        {
            if (pBirthdate > DateTime.Today)
                throw new ArgumentOutOfRangeException();
            birthDate = pBirthdate;
        }
        public DateTime GetBirthDate()
        {
            return birthDate;
        }
        public int GetAge()
        {
            return DateTime.Today.Year - birthDate.Year;
        }
    }
}