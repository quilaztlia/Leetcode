namespace Review;

//https://learn.microsoft.com/en-us/dotnet/api/system.array.exists?view=net-6.0
//https://code-maze.com/csharp-copy-array-elements-to-new-array/
//Shallow(reference) vs Deep: https://www.codingninjas.com/codestudio/library/explain-the-difference-between-shallow-copy-and-deep-copy
public class Array_Review
{
    public void AsignArray()
    {
        string[] names = new string[] { "Adriana", "Joy", "Cat", "Dog" };

        //ASSING is by reference
        var namesCopy = names;

        Console.WriteLine($"names {names}");
        Console.WriteLine($"namesCopy {namesCopy}");

        names.Append("Add in names ONLY");

        Console.WriteLine($"After append: names {names}");
        Console.WriteLine($"After append:namesCopy {namesCopy}");
    }

    public void CopyArray()
    {
        string[] names = new string[] { "Adriana", "Joy", "Cat", "Dog" };       
        string[] namesCopy = new string[names.Length];
        string[] namesCopyWithArray = new string[names.Length];

        Array.Copy(names, namesCopyWithArray, 3);

        names.CopyTo(namesCopy, 0);

        Console.WriteLine($"names {names}");
        Console.WriteLine($"namesCopy {namesCopy}");

        names.Append("Add in NAMES");
        namesCopy.Append("Add in COPY");

        Console.WriteLine($"names {names}");
        Console.WriteLine($"namesCopy {namesCopy}");
    }


    //O(n)
    public void CloneArray()
    {
        string[] names = new string[] { "Adriana", "Joy", "Cat", "Dog" };
      
        string[] namesCopy = new string[names.Length];
        string[] namesCopyWithArray = new string[names.Length];

        var namesClone = names.Clone();
        var namesCloneTyped = (string[])namesClone;
        Console.WriteLine($"names {names}");
        Console.WriteLine($"namesCopy {namesCopy}");
        Console.WriteLine($"namesClone {namesClone}");

        names.Append("Add in NAMES");
        names.Append("Add in COPY");
        names.Append("Add in CLONE");

        Console.WriteLine($"names {names}");
        Console.WriteLine($"namesCopy {namesCopy}");
    }

    public void Shallow_vs_Deep()
    {
        string[] names = new string[] { "Adriana", "Joy", "Cat", "Dog" };

        var shallow = names.Select(x => x); //ToArray();
        var deep = names.Select(x => new string(x)); //ToArray();
        //.Select(x => new Article { Title = x.Title, LastUpdate = x.LastUpdate })
        names.Append("Check shallow & deep");
    }

    public void Slicing()
    {
        string[] names = new string[] { "Adriana", "Joy", "Cat", "Dog" };
        var slice = names[2..3];
    }
}
