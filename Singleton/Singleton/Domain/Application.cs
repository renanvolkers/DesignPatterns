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
                    vetorExercice.VetorOrdenador[i - 1] = vetorExercice.VetorInicial[i - 1];
                    vetorExercice.VetorOrdenador[i] = vetorExercice.VetorInicial[i];
                }
            }
            return vetorExercice;
        }

        public VetorExercice<string> SameInstance()
        {
            // Conseguimos obter a instancia do nosso singleton através do método GetSingleton
            var mySingleton = SingletonApp.GetMySingleton();

            // Adicionamos uma string na lista para avaliar se ele realmente irá retornar a mesma instancia.
            mySingleton.TestSingleton.Add("Linha 1");

            // Criamos outra variável para testar se esta é a mesma instancia da classe MySingleton.
            var sameSingleton = SingletonApp.GetMySingleton();

            // Adicionamos outra string na lista
            sameSingleton.TestSingleton.Add("Linha 2");
        }
    }
    public class VetorExercice<T>where T : new()
    {
        public T[] VetorInicial { get; set; } = new T[50];
        public T[] VetorOrdenador { get; set; } = new T[50];
    }
}
