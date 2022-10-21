namespace DesafioProjetoHospedagem.Models
{
    public class Booking
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Booking() { }

        public Booking(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("Capacidade da suite é insuficiente para o numero de hóspedes recebidos.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetQuantityGuests() => Guests.Count;

        public decimal CalculateDailyValue()
        {
            decimal dailyValue = 0;

            if (ReservedDays >= 10)
            {
                decimal discount = (ReservedDays * Suite.DailyValue) * 0.10M;
                dailyValue = (ReservedDays * Suite.DailyValue);
                dailyValue -= discount;
            }
            else
            {
                dailyValue = (ReservedDays * Suite.DailyValue);
            }

            return dailyValue;
        }
    }
}