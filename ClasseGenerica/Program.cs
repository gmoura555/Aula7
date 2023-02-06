using ClasseGenerica;
using System.Collections;

namespace ClasseGenerica
{
    public class PilhaGenerica<T>
    {

        private List<T> elementos = new List<T>();

        public T Top
        {
            get => elementos[elementos.Count - 1];
        }
        public void Push(T item)
        {
            elementos.Add(item);
        }
        public T Pop()
        {
            T aux = default(T);
            if (elementos.Count == 0)
            {
                return aux;
            }
            aux = Top;
            elementos.RemoveAt(elementos.Count - 1);
            return aux;

        }
        public string MetodoGenerico<T>(T elemento)
        {
            return elemento.ToString();
        }
    }

}
internal class Program
{
    static void Main(string[] args)
    {
        PilhaGenerica<string> pilhaString = new PilhaGenerica<string>();
        pilhaString.Push("Fernando");
        pilhaString.Push("Romulo");
        pilhaString.Push("Vinicius");
        


        Console.WriteLine($"Elemento no TOpo: " + pilhaString.Pop());
        Console.WriteLine(new String('-', 50));

        PilhaGenerica<int> pilhaInt = new PilhaGenerica<int>();
        pilhaInt.Push(345);
        pilhaInt.Push(456);
        pilhaInt.Push(234);
        Console.WriteLine(pilhaString.MetodoGenerico(pilhaString));
        Console.WriteLine($"Elemento no TOpo: " + pilhaInt.Pop());

    }
}