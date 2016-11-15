using System;
using PKW.ControlCenter.Data;

namespace PKW.ControlCenter
{
    public class DataInit
    {
        public static void Load(IDataRepository repository)
        {
            for (int i = 1; i <= 100; i++)
            {
                repository.Add(new ConstituencyModel() {Id = i, Name = String.Format("Okręg wyborczy numer {0}", i)});
            }

            repository.Add(new CandidatesModel() {Id = 1, Name = "Adam Kowalski", ConstituencyId = 1});
            repository.Add(new CandidatesModel() {Id = 2, Name = "Jan Nowak", ConstituencyId = 1});
            repository.Add(new CandidatesModel() {Id = 3, Name = "Pan Kleks", ConstituencyId = 1});
            repository.Add(new CandidatesModel() {Id = 4, Name = "Chuck Norris", ConstituencyId = 1});
            repository.Add(new CandidatesModel() {Id = 5, Name = "Krzysztof Kononowicz", ConstituencyId = 1});
            repository.Add(new CandidatesModel() {Id = 6, Name = "Bruce Lee", ConstituencyId = 1});
            repository.Add(new CandidatesModel() {Id = 7, Name = "Grzegorz Kowalski", ConstituencyId = 2});
            repository.Add(new CandidatesModel() {Id = 8, Name = "Jerzy Nowak", ConstituencyId = 2});
            repository.Add(new CandidatesModel() {Id = 9, Name = "Mr Kleks", ConstituencyId = 3});
            repository.Add(new CandidatesModel() {Id = 10, Name = "Marlon Brando", ConstituencyId = 3});
            repository.Add(new CandidatesModel() {Id = 11, Name = "Anna Zielona", ConstituencyId = 3});
            repository.Add(new CandidatesModel() {Id = 12, Name = "John Travolta", ConstituencyId = 4});
            for (int i = 5; i <= 100; i++)
            {
                repository.Add(new CandidatesModel()
                {
                    Id = i*10 + 1,
                    Name = String.Format("Adam Kowalski{0}", i),
                    ConstituencyId = i
                });
                repository.Add(new CandidatesModel()
                {
                    Id = i*10 + 2,
                    Name = String.Format("Jan Nowak{0}", i),
                    ConstituencyId = i
                });
                repository.Add(new CandidatesModel()
                {
                    Id = i*10 + 3,
                    Name = String.Format("Pan Kleks{0}", i),
                    ConstituencyId = i
                });
                repository.Add(new CandidatesModel()
                {
                    Id = i*10 + 4,
                    Name = String.Format("Chuck Norris{0}", i),
                    ConstituencyId = i
                });
                repository.Add(new CandidatesModel()
                {
                    Id = i*10 + 5,
                    Name = String.Format("Krzysztof Kononowicz{0}", i),
                    ConstituencyId = i
                });
                repository.Add(new CandidatesModel()
                {
                    Id = i*10 + 6,
                    Name = String.Format("Bruce Lee{0}", i),
                    ConstituencyId = i
                });
            }
        }
    }
}