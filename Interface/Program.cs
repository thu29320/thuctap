using System;

namespace Interface
{
    internal interface IPet //khai bao Interface voi hai phuong thuc
    {
        //mo ta phuong thuc, ko co than
        void Feed();
        void Sound();
    }
    internal interface IBird
    {
        void Fly();
        void Sound();
        void Feed();
    }
    internal class Cat:IPet //cat ke thua IPet
    {
        public Cat() => Console.WriteLine("I'm a Cat.");
        //thuc thi cho phuong thuc Feed va Sound theo kieu Implicit
        public void Feed() => Console.WriteLine("Fish, please.");
        public void Sound() => Console.WriteLine("Meo meo meo.");
    }
    internal class Dog: IPet
    {
        public Dog() => Console.WriteLine("I'm a Dog.");
        // thuc thi cho phuong thuc Feed va Sound theo kieu Explicit
        //Object ko the goi 2 phuong thuc nay,nen chi co the goi qua giao dien IPet
        void IPet.Feed() => Console.WriteLine("Bone, please.");
        void IPet.Sound() => Console.WriteLine("Gau gau gau.");
    }

    internal class Parrot: IPet,IBird
    {
        public Parrot() => Console.WriteLine("I'm a Parrot.");
        //hai phuong thuc thuc thi kieu Implicit => goi tu object cua Parrot
        public void Feed() => Console.WriteLine("Nut, please.");
        public void Fly() => Console.WriteLine("I can fly.");

        //hai phuong thuc thuc thi theo kieu Explicit=>can't goi object
        //cua Parrot, goi qua giao dien Ipet/IBird
        void IPet.Sound() => Console.WriteLine("I can speak.");
        void IBird.Sound() => Console.WriteLine("I can sing, too.");
    }
    internal class PetLover
    {
        private IPet _pet;
        public PetLover(IPet pet) => _pet = pet;
        public PetLover() { }
        public void Play()
        {
            //_pet co the goi du cac phuong thuc cua IPet
            Console.Write("what do you like to eat?  ");
            _pet.Feed();
            Console.Write("Now say something?  ");
            _pet.Sound();
        }
    }
    internal class BirdLover
    {
        private IBird _bird;
        public BirdLover(IBird bird) => bird = _bird;
        public void Play()
        {
            //_bird co the goi du phuong thuc cua IBird
            Console.Write("Fly  ");
            _bird.Fly();
            Console.Write("Say something  ");
            _bird.Sound();
            Console.Write("What do you like to eat?   ");
            _bird.Feed();
        }
    }
    internal class Program
    {
        private static void Main()
        {
            IPet pet1 = new Cat();
            PetLover petLover1 = new PetLover(pet1);
            petLover1.Play();
            Console.WriteLine();

            IPet pet = new Dog();
            PetLover petLover = new PetLover(pet);
            petLover.Play();
            Console.WriteLine();

            petLover = new PetLover(new Parrot());
            petLover.Play();
            Console.WriteLine();

            BirdLover birdLover = new BirdLover(new Parrot());
            birdLover.Play();

            Cat cat = new Cat();
            //cat co the goi dc Feed va Sound
            cat.Feed();
            cat.Sound();

            IPet cat2 = new Cat();
            //cat2 co the goi Feed va Sound
            cat2.Feed();
            cat2.Sound();

            Parrot parrot = new Parrot();
            //goi qua object, chi goi dc Feed vaf Fly, ko goi dc Sound
            parrot.Feed();
            parrot.Fly();

            IBird parrot2 = new Parrot();
            //goi qua giao dien, parrot2 co the goi dc 3 phuong thuc cua IBird
            parrot2.Feed();
            parrot2.Fly();
            parrot2.Sound();


            
            Dog dog = new Dog();
            //goi qua object, dog ko goi dc phuong thuc nao (ca 2 phuong thuc cua Dog deu goi kieu Explicit)

            IPet dog2 = new Dog();
            //goi qua giao dien, dog 2 goi dc ca Feed va Sound
            dog2.Feed();
            dog2.Sound();

            Console.ReadLine();

        }
    }
}
