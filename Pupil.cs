using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task1_lab02
{
    public class Pupil
    {
        public Pupil() { }
        public virtual void Study() { Console.WriteLine("I'm trying to do a physics lab."); }
        public virtual void Read() { Console.WriteLine("I'm reading, how to do a physics lab."); }
        public virtual void Write() { Console.WriteLine("I'm writing my physics lab."); }
        public virtual void Relax() { Console.WriteLine("I'm resting."); }
    }

    public class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("It's so hard to do a physics lab."); }
        public override void Read() { Console.WriteLine("I can't understand it."); }
        public override void Write() { Console.WriteLine("Let's write something, but I don't know, what."); }
        public override void Relax() { Console.WriteLine("It's time to relax."); }
    }
    public class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("It's really hard to do a physics lab."); }
        public override void Read() { Console.WriteLine("I understand a little bit."); }
        public override void Write() { Console.WriteLine("Let's write it."); }
        public override void Relax() { Console.WriteLine("It's time to relax."); }
    }

    public class ExcelentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("What is it?"); }
        public override void Read() { Console.WriteLine("I can't understand at all."); }
        public override void Write() { Console.WriteLine("Help me, please ..."); }
        public override void Relax() { Console.WriteLine("I have no time to relax."); }
    }

    public class ClassRoom
    {
        private Pupil[] _massive;
        public ClassRoom(params Pupil[] massive)
        {
            _massive = massive;
        }
        public void Information()
        {
            if (_massive.Length > 3)
            {
                for (int i = 0; i < _massive.Length; i++)
                {
                    this.get_massive[i].Study();
                    this.get_massive[i].Read();
                    this.get_massive[i].Write();
                    this.get_massive[i].Relax();
                    Console.WriteLine();
                }
            }
            else { Console.WriteLine("Error "); }
        }
        public Pupil[] get_massive { get { return _massive; } }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            BadPupil pupil1 = new BadPupil();
            GoodPupil pupil2 = new GoodPupil();
            ExcelentPupil pupil3 = new ExcelentPupil();
            Pupil pupil4 = new Pupil();
            ClassRoom room = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
            room.Information();
        }
    }
}
