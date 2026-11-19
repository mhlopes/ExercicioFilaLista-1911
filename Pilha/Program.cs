using Lista;

List<Contato> contacts = new();

string[] nomes = ["Matheus", "joao", "felipe"];

for (int i = 0; i < nomes.Length; i++)
{
    contacts.Add(new Contato(nomes[i]));
}

foreach (var contact in contacts)
{
    Console.WriteLine(contact.Name);
}
