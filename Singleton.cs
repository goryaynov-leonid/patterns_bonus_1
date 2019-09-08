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
������ ���������� �� ��������� ������� ���� ������� ��� ����,
����� ����� ���� �������� ������ � ��������� ����� ��� �������� ������� �������� 
*/