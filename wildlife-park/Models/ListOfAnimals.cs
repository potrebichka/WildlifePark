using System;
using System.Collections.Generic;

namespace WildLifePark.Models {
    class ListOfAnimals {
        private List<Animal> _animals;
        private int _currentId = 0;
        public ListOfAnimals() {
            _animals = new List<Animal>(){};
        }

        public void AddAnimal(string species, string name, int age) {
            Animal animal = new Animal(species,name,age, _currentId);
            _animals.Add(animal);
            _currentId++;
        }

        public bool RemoveAnimalById(int id) {
            for (int i = 0; i < _animals.Count; i++) {
                if (_animals[i].GetId() == id) {
                    _animals.Remove(_animals[i]);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveAnimalByName(string name) {
            for (int i = 0; i < _animals.Count; i++) {
                if (_animals[i].GetName() == name) {
                    _animals.Remove(_animals[i]);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveAnimalBySpecies(string species) {
            bool flag = false;
            for (int i = _animals.Count-1; i >= 0; i--) {
                if (_animals[i].GetSpecies() == species) {
                    _animals.Remove(_animals[i]);
                    flag = true;
                }
            }
            return flag;
        }

        public string FindAnimalById(int id) {
            for (int i = 0; i < _animals.Count; i++) {
                if (_animals[i].GetId() == id) {
                    return "Id: " + _animals[i].GetId() + " / Name: " + _animals[i].GetName() + " / Age: " + _animals[i].GetAge() + " / Species: " + _animals[i].GetSpecies();
                }
            }
            return "No animals were found with this id.";
        }

        public string FindAnimalByName(string name) {
            for (int i = 0; i < _animals.Count; i++) {
                if (_animals[i].GetName() == name) {
                    return "Id: " + _animals[i].GetId() + " / Name: " + _animals[i].GetName() + " / Age: " + _animals[i].GetAge() + " / Species: " + _animals[i].GetSpecies();
                }
            }
            return "No animals were found with this name.";
        }

        public string FindAnimalsBySpecies(string species) {
            string matchedAnimals = "";
            for (int i = 0; i < _animals.Count; i++) {
                if (_animals[i].GetSpecies() == species) {
                    matchedAnimals += "Id: " + _animals[i].GetId() + " / Name: " + _animals[i].GetName() + " / Age: " + _animals[i].GetAge() + " / Species: " + _animals[i].GetSpecies() + "\n";
                }
            }
            if (matchedAnimals == "") {
                return "No animals were found within this species.";
            }
            return matchedAnimals;
        }

        public string GetListOfAnimals() {
            string matchedAnimals = "";
            for (int i = 0; i < _animals.Count; i++) {
                matchedAnimals += "Id: " + _animals[i].GetId() + " / Name: " + _animals[i].GetName() + " / Age: " + _animals[i].GetAge() + " / Species: " + _animals[i].GetSpecies() + "\n";
            }
            if (matchedAnimals == "") {
                return "No animals were found.";
            }
            return matchedAnimals;
    }
    }
}