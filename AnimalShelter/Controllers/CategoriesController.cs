[HttpPost]("/animals/{animalId}/types")
public ActionResult Create(int animalsId, string typeName)
{
    Dictionary<string, object> model = new Dictionary<string, object>();
    Animal foundAnimal = Animal.Find(AnimalId);
    Type newType = new Type(typeName);
    newType.Save();
    foundAnimal.AddAnimal(newType);
    List<Type> animalTypes = foundAnimal.Types;
    model.Add("types", animalTypes);
    model.Add("animals", foundAnimal);
    return View("Show", model);
}