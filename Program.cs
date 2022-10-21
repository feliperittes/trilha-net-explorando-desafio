using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> guests = new List<Person>();

Person person1 = new Person(name: "Hóspede 1");
Person person2 = new Person(name: "Hóspede 2");

guests.Add(person1);
guests.Add(person2);

// Cria a suíte
Suite suite = new Suite(typeSuite: "Premium", capacity: 2, dailyValue: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Booking booking = new Booking(reservedDays: 5);
booking.RegisterSuite(suite);
booking.RegisterGuests(guests);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {booking.GetQuantityGuests()}");
Console.WriteLine($"Valor diária: {booking.CalculateDailyValue()}");