    public class Program
    {
        void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {

                uint.TryParse(line, out uint puissance);

                uint new_puissance = Calcul(puissance);

                Console.WriteLine(puissance);
            }
            // Vous pouvez aussi effectuer votre traitement ici après avoir lu toutes les données 
        }

        public uint Calcul(uint puissance)
        {
            for (int i = 0; i < 4; i++)
            {
                puissance= (puissance % 2 == 0)? puissance /= 2
                        :  (puissance % 3 == 0) ? puissance /= 3
                        :  puissance -= 1;
            }
            return puissance;
        }
    }
