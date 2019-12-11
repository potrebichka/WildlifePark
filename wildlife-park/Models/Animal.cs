namespace WildLifePark.Models {
    class Animal {
        private string _species;
        private string _name;
        private int _age;
        private int _id;

        public Animal(string species, string name, int age, int id) {
            _species = species;
            _name = name;
            _age = age;
            _id = id;
        }

        public string GetSpecies() {
            return _species;
        }

        public string GetName() {
            return _name;
        }

        public int GetAge() {
            return _age;
        }

        public int GetId() {
            return _id;
        }
    }
}