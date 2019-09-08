public class Singleton
{
    public static string text = "Hello, world!";
    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        return NestedSingleton.instance;
    }

    private class NestedSingleton
    {
        static NestedSingleton() { }
        internal static readonly Singleton instance = new Singleton();
    }
}

/*
Данная реализация со вложенным классом была выбрана для того,
чтобы можно было получить доступ к статичным полям без создания объекта Одиночки 
*/