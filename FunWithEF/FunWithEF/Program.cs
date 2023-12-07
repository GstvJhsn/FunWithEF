// See https://aka.ms/new-console-template for more information
using FunWithEF.Data;
using FunWithEF.Model;

using (var context = new FishContext())
{
    var fish = new Fish { Species = "Perch", Color = "Green" };
    context.Shoal.Add(fish);
    context.SaveChanges();
}

