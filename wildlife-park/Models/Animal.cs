namespace WildLifePark {
    class Animal {
        private string _species;
        private string _name;
        private int _age;
        private int _id;

        public void Animal(string species, string name, int age, int id) {
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

        public string GetAge() {
            return _age;
        }

        public string GetId() {
            return _id;
        }
    }
}