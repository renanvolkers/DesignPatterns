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
            VetorExercice<string> vetor 
            var mySingleton = SingletonApp.GetMySingleton();

            mySingleton.TestSingleton.Add("Linha 1");

            var sameSingleton = SingletonApp.GetMySingleton();

            sameSingleton.TestSingleton.Add("Linha 2");



        }
    }
    public class VetorExercice<T>where T : new()
    {
        public T[] VetorInicial { get; set; } = new T[50];
        public T[] VetorOrdenador { get; set; } = new T[50];
    }
}
