namespace Singleton.Domain
{
    public class Application
    {
        public VetorExercice<int> VerificarVetor()
        {
            var vetorExercice = new VetorExercice<int>();

            for (int i = 0; i < vetorExercice.VetorInicial.Length; i++)
            {
                vetorExercice.VetorInicial[i]= new Random().Next(0,200);
            }

            for (int i = 1; i < vetorExercice.VetorInicial.Length; i++)
            {
               if(vetorExercice.VetorInicial[i-1] > vetorExercice.VetorInicial[i])
                {
                    vetorExercice.VetorResultado[i - 1] = vetorExercice.VetorInicial[i - 1];
                    vetorExercice.VetorResultado[i] = vetorExercice.VetorInicial[i];
                }
            }
            vetorExercice.ConfigVetorResultado = "Order";
            return vetorExercice;
        }

        public VetorExercice<string> SameInstance()
        {
            var vetorSingleton = new VetorExercice<string>();
            var mySingleton = SingletonApp.GetMySingleton();

            mySingleton.TestSingleton.Add("Dog");
            mySingleton.TestSingleton.Add("Cat");

            var sameSingleton = SingletonApp.GetMySingleton();

            sameSingleton.TestSingleton.Add("Gavião");
            sameSingleton.TestSingleton.Add("EAGLE");

            vetorSingleton.VetorResultado = mySingleton.TestSingleton.ToArray();
            vetorSingleton.VetorInicial = sameSingleton.TestSingleton.ToArray();
            vetorSingleton.ConfigVetorResultado = "User same instance";
            return vetorSingleton;

        }
        public VetorExercice<int> bubbleSort()
        {
            var vetorExercice = new VetorExercice<int>();

            vetorExercice.VetorInicial[0] = 99;
            for (int i = 1; i < vetorExercice.VetorInicial.Length; i++)
            {

                vetorExercice.VetorInicial[i] = new Random().Next(0, 200);
                vetorExercice.VetorResultado[i] = vetorExercice.VetorInicial[i];
            }
            int tamanho = vetorExercice.VetorResultado.Length;

            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vetorExercice.VetorResultado[j] > vetorExercice.VetorResultado[j + 1])
                    {
                        int aux = vetorExercice.VetorResultado[j];
                        vetorExercice.VetorResultado[j] = vetorExercice.VetorResultado[j + 1];
                        vetorExercice.VetorResultado[j + 1] = aux;
                    }
                }
            }

            return vetorExercice;
        }
    }
    public class VetorExercice<T>
    {
        public T[] VetorInicial { get; set; } = new T[50];
        public T[] VetorResultado { get; set; } = new T[50];
        public string? ConfigVetorResultado { get; set; }

    }
}
