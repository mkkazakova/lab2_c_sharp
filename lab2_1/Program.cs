using System;
using System.Xml.Linq;

class Pupil
{

    protected string Name;
    public Pupil(string name)
    {
        Name = name;
    }
    public virtual void Study()
    {
        Console.WriteLine(Name + " studies");
    }

    public virtual void Read()
    {
        Console.WriteLine(Name + " reads");
    }

    public virtual void Write()
    {
        Console.WriteLine(Name + " writes");
    }

    public virtual void Relax()
    {
        Console.WriteLine(Name + " relaxes");
    }
}

class ExcelentPupil : Pupil
{
    public ExcelentPupil(string name) : base(name) { }
    public override void Study()
    {
        Console.WriteLine("Excelent pupil " + Name + " studies a lot");
    }

    public override void Read()
    {
        Console.WriteLine("Excelent pupil " + Name + " reads a lot of books");
    }

    public override void Write()
    {
        Console.WriteLine("Excelent pupil " + Name + " writes a lot of essays");
    }

    public override void Relax()
    {
        Console.WriteLine("Excelent pupil " + Name + " is not relaxing");
    }
}

class GoodPupil : Pupil
{
    public GoodPupil(string name) : base(name) { }
    public override void Study()
    {
        Console.WriteLine("Good pupil " + Name + " is studying well");
    }

    public override void Read()
    {
        Console.WriteLine("Good pupil " + Name + " reads sometimes");
    }

    public override void Write()
    {
        Console.WriteLine("Good pupil " + Name + " writes good essays");
    }

    public override void Relax()
    {
        Console.WriteLine("Good pupil " + Name + " is relaxing after school");
    }
}

class BadPupil : Pupil
{
    public BadPupil(string name) : base(name) { }
    public override void Study()
    {
        Console.WriteLine("Bad pupil " + Name + " is not studying enough");
    }

    public override void Read()
    {
        Console.WriteLine("Bad pupil " + Name + " not reads book");
    }

    public override void Write()
    {
        Console.WriteLine("Bad pupil " + Name + " not writes essays");
    }

    public override void Relax()
    {
        Console.WriteLine("Bad pupil " + Name + " is relaxing too much");
    }
}

class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
        this.pupils = pupils;
    }

    public void Study()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Study();
        }
    }

    public void Read()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Read();
        }
    }

    public void Write()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Write();
        }
    }

    public void Relax()
    {
        foreach (Pupil pupil in pupils)
        {
            pupil.Relax();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаём класс из 4 учеников

        Pupil pupil1 = new ExcelentPupil("Masha");
        Pupil pupil2 = new GoodPupil("Egor");
        Pupil pupil3 = new BadPupil("Ksenia");
        Pupil pupil4 = new ExcelentPupil("Fedor");

        ClassRoom classRoom1 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom1.Study();
        classRoom1.Read();
        classRoom1.Write();
        classRoom1.Relax();

        Console.WriteLine("   ");

        // Создаём класс из 2 учеников

        Pupil pupil5 = new GoodPupil("Petr");
        Pupil pupil6 = new BadPupil("Sofia");

        ClassRoom classRoom2 = new ClassRoom(pupil5, pupil6);
        classRoom2.Study();
        classRoom2.Read();
        classRoom2.Write();
        classRoom2.Relax();

        // Console.ReadLine();
    }
}