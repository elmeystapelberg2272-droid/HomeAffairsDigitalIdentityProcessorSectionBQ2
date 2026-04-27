using System;
// Elmey Nicolene Stapelberg
// Software Design & Testing with C# 
// SDT621 - Formative Assessment 1 
// Section B - Question 2
namespace HomeAffairsDigitalIdentityProcessorSectionBQ2
{
    internal class CitizenProfile
    {
        // Properties as required by the assessment
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        // Constructor handles the assignment and age calculation
        public CitizenProfile(string name, string id, string citizenship)
        {
            FullName = name;
            IDNumber = id;
            CitizenshipStatus = citizenship;
            Age = CalculateAge(id);
        }

        // Method to extract the birth date from ID (YYMMDD) and compute age
        private int CalculateAge(string id)
        {
            try
            {
                if (id.Length < 6) return 0;

                int yearPart = int.Parse(id.Substring(0, 2));
                int month = int.Parse(id.Substring(2, 2));
                int day = int.Parse(id.Substring(4, 2));

                // Century logic: 00-26 (2000s), 27-99 (1900s)
                int fullYear = (yearPart <= 26) ? 2000 + yearPart : 1900 + yearPart;

                DateTime birthDate = new DateTime(fullYear, month, day);
                int age = DateTime.Now.Year - birthDate.Year;

                // Adjustment for birthday not yet reached this year
                if (DateTime.Now < birthDate.AddYears(age)) age--;
                return age;
            }
            catch
            {
                return 0; // Return 0 if date format is invalid
            }
        }

        // Validation Method
        public string ValidateID()
        {
            // Requirement: Exactly 13 digits and numeric
            if (IDNumber.Length != 13 || !long.TryParse(IDNumber, out _))
            {
                return "Invalid ID: Must be exactly 13 numeric digits.";
            }

            if (Age <= 0)
            {
                return "Invalid ID: Birth date in ID is invalid.";
            }

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}